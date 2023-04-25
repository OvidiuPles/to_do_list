using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace tema1
{
    public partial class HomePage : Form
    {
        public static HomePage instance; // pentru accesare listView din AddTaskPage
        // am incercat sa fac static doar listView si functioneaza doar ca nu mai apare in HomePage[Design]
        public static List<Task> tasks = new List<Task>(); // stocarea datelor pentru View Details
        private List<Task> doneTasks = new List<Task>();
        StreamReader streamReader;
        StreamWriter streamWriter;
        public HomePage()
        {
            InitializeComponent();
            ReadFromFile("task.txt");
            ReadFromFile("done_task.txt");
            instance = this;
            ToolTip.SetToolTip(DeleteButton, "Deleted tasks can't be recovered");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTaskPage addTaskPage = new AddTaskPage();
            addTaskPage.Show();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            Task selectedTask = GetSelectedTask(tasks, ListView);
            ShowTaskDetails(selectedTask);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Task selectedTask = GetSelectedTask(tasks, ListView);
            if (selectedTask != null) 
            {
                DeleteTask(selectedTask);
            }
            else if (ListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selectati un singur task", "Eroare");
            }
            else
            {
                MessageBox.Show("Selectati un task", "Eroare");
            }
        }

        private void ReadFromFile(String filePath)
        {
            streamReader = new StreamReader(filePath);
            while (!streamReader.EndOfStream)
            {
                string name = streamReader.ReadLine();
                string description = streamReader.ReadLine();
                string location = streamReader.ReadLine();
                string deadline = streamReader.ReadLine();
                Task task = new Task(name, description, location, deadline);

                ListViewItem item = new ListViewItem(task.Name); //item pe prima coloana invizibila pe GUI
                item.SubItems.Add(task.Name);
                item.SubItems.Add(task.Deadline);

                if (filePath == "task.txt")
                {
                    ListView.Items.Add(item);
                    tasks.Add(task);
                }
                else
                {
                    ListViewDone.Items.Add(item);
                    doneTasks.Add(task);
                }
            }
            streamReader.Close();
        }

        private Task GetSelectedTask(List<Task> tasks, ListView listView)
        {
            Task selectedTask = null;
            if (listView.SelectedItems.Count == 1)
            {
                foreach (Task task in tasks)
                {
                    foreach (ListViewItem item in listView.SelectedItems)
                    {
                        if (task.Name == item.Text)
                        {
                            selectedTask = task;
                            break;
                        }
                    }

                }
                return selectedTask;
            }
            return null;
        }

        private void DeleteTask(Task task)
        {
            //stergere din fisier
            streamReader = new StreamReader("task.txt");
            string[] lines = File.ReadAllLines("task.txt");
            List<string> remainingLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == task.Name)
                {
                    for (int j = 0; j < 4; j++) //sarim peste cele 4 atribute ale task-ului
                    {
                        streamReader.ReadLine();
                    }
                    i += 3;
                }
                else
                {
                    remainingLines.Add(lines[i]);
                }
            }
            streamReader.Close();
            File.WriteAllLines("task.txt", remainingLines);

            //stergerea din List<Task>
            HomePage.tasks.Remove(task);
            ListView.Items.Remove(ListView.FindItemWithText(task.Name));
        }

        private void MarkDoneButton_Click(object sender, EventArgs e)
        {
            Task selectedTask = GetSelectedTask(tasks, ListView);
            if (ListView.SelectedItems.Count == 1 && selectedTask != null)
            {
                ListViewItem item = new ListViewItem(selectedTask.Name);
                item.SubItems.Add(selectedTask.Name);
                item.SubItems.Add(selectedTask.Deadline);
                ListViewDone.Items.Add(item);

                streamWriter = new StreamWriter("done_task.txt", true);
                streamWriter.WriteLine(selectedTask.Name);
                streamWriter.WriteLine(selectedTask.Description);
                streamWriter.WriteLine(selectedTask.Location);
                streamWriter.WriteLine(selectedTask.Deadline);
                streamWriter.Close();

                doneTasks.Add(selectedTask);
                DeleteTask(selectedTask);
            }
            else if (ListView.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selectati un singur task", "Eroare");
            }
            else
            {
                MessageBox.Show("Selectati un task", "Eroare");
            }
        }

        private void ViewDetailsDone_Click(object sender, EventArgs e)
        {
            Task selectedTask = GetSelectedTask(doneTasks, ListViewDone);
            ShowTaskDetails(selectedTask);
        }

        private void ShowTaskDetails(Task task)
        {
            if (task != null)
            {
                TaskDetails taskDetails = new TaskDetails(task);
                taskDetails.Show();
            }
            else if (ListView.SelectedItems.Count > 1 || ListViewDone.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selectati un singur task", "Eroare");
            }
            else
            {
                MessageBox.Show("Selectati un task", "Eroare");
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            doneTasks.Clear();
            ListViewDone.Items.Clear();
            File.WriteAllText("done_task.txt", string.Empty);
        }
    }
}

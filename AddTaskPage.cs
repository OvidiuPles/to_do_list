using System;
using System.IO;
using System.Windows.Forms;

namespace tema1
{
    public partial class AddTaskPage : Form
    {
        StreamWriter streamWriter;

        public AddTaskPage()
        {
            InitializeComponent();
        }

        private void AddTaskPage_Load(object sender, EventArgs e)
        {
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "hh:mm tt";
            SetDeadlineVisibility(false);
        }

        private void DeadlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeadlineCheckBox.Checked)
            {
                SetDeadlineVisibility(true);
            }
            else
            {
                SetDeadlineVisibility(false);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "")
            {
                Task task;
                if (DeadlineCheckBox.Checked) //nu adaugam valoarea deafault de la DateTimePicker
                {
                    task = new Task(NameTextBox.Text, DescriptionTextBox.Text,
                                    LocationTextBox.Text, DateTimePicker.Text + " " + TimePicker.Text);
                }
                else
                {
                    task = new Task(NameTextBox.Text, DescriptionTextBox.Text,
                                    LocationTextBox.Text, "");
                }

                /*nu am putut sa setez TextAlign centre pentru prima coloana in ListView
                 *asa ca am facut o coloana in plus (prima coloana) cu width = 0 si care are 
                 *aceeasi valoare ca a doua coloana (prima care este vizibila in GUI)
                */
                ListViewItem item = new ListViewItem(task.Name); //item pe prima coloana invizibila pe GUI
                item.SubItems.Add(task.Name);
                if (DeadlineCheckBox.Checked)
                {
                    item.SubItems.Add(task.Deadline);
                }
                HomePage.instance.ListView.Items.Add(item);
                HomePage.tasks.Add(task);
                WriteInFile(task);
                this.Close();
            }
            else
            {
                MessageBox.Show("Campul marcat cu * este obligatoriu", "Eroare");
            }
        }

        private void SetDeadlineVisibility(bool visibility)
        {
            DateTimePicker.Visible = visibility;
            TimePicker.Visible = visibility;
            DateLabel.Visible = visibility;
            TimeLabel.Visible = visibility;
        }

        private void WriteInFile(Task task)
        {
            streamWriter = new StreamWriter("task.txt", true);
            streamWriter.WriteLine(task.Name);
            streamWriter.WriteLine(task.Description);
            streamWriter.WriteLine(task.Location);
            if (DeadlineCheckBox.Checked)
            {
                streamWriter.WriteLine(task.Deadline);
            }
            else
            {
                streamWriter.WriteLine(" ");
            }
            streamWriter.Close();
        }
    }
}

using System.Windows.Forms;

namespace tema1
{
    public partial class TaskDetails : Form
    {
        public TaskDetails(Task task)
        {
            InitializeComponent();
            NameTextBox.Text = task.Name;
            DescriptionTextBox.Text = task.Description;
            LocationTextBox.Text = task.Location;
            DeadLineTextBox.Text = task.Deadline;
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

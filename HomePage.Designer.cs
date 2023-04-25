namespace tema1
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ToDoPage = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MarkDoneButton = new System.Windows.Forms.Button();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.DonePage = new System.Windows.Forms.TabPage();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.ViewDetailsDone = new System.Windows.Forms.Button();
            this.ListViewDone = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TabControl.SuspendLayout();
            this.ToDoPage.SuspendLayout();
            this.DonePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ToDoPage);
            this.TabControl.Controls.Add(this.DonePage);
            this.TabControl.Location = new System.Drawing.Point(-3, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(839, 386);
            this.TabControl.TabIndex = 0;
            // 
            // ToDoPage
            // 
            this.ToDoPage.Controls.Add(this.DeleteButton);
            this.ToDoPage.Controls.Add(this.MarkDoneButton);
            this.ToDoPage.Controls.Add(this.ViewDetailsButton);
            this.ToDoPage.Controls.Add(this.ListView);
            this.ToDoPage.Controls.Add(this.AddButton);
            this.ToDoPage.Location = new System.Drawing.Point(4, 25);
            this.ToDoPage.Name = "ToDoPage";
            this.ToDoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ToDoPage.Size = new System.Drawing.Size(831, 357);
            this.ToDoPage.TabIndex = 0;
            this.ToDoPage.Text = "To do";
            this.ToDoPage.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(623, 261);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 24);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete task";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MarkDoneButton
            // 
            this.MarkDoneButton.Location = new System.Drawing.Point(623, 196);
            this.MarkDoneButton.Name = "MarkDoneButton";
            this.MarkDoneButton.Size = new System.Drawing.Size(116, 23);
            this.MarkDoneButton.TabIndex = 5;
            this.MarkDoneButton.Text = "Mark as done";
            this.MarkDoneButton.UseVisualStyleBackColor = true;
            this.MarkDoneButton.Click += new System.EventHandler(this.MarkDoneButton_Click);
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Location = new System.Drawing.Point(623, 130);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(116, 23);
            this.ViewDetailsButton.TabIndex = 4;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.columnHeader3,
            this.columnHeader1});
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(539, 347);
            this.ListView.TabIndex = 3;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Nume";
            this.columnHeader.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Deadline";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 200;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(623, 63);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add task";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DonePage
            // 
            this.DonePage.Controls.Add(this.ClearListButton);
            this.DonePage.Controls.Add(this.ViewDetailsDone);
            this.DonePage.Controls.Add(this.ListViewDone);
            this.DonePage.Location = new System.Drawing.Point(4, 25);
            this.DonePage.Name = "DonePage";
            this.DonePage.Padding = new System.Windows.Forms.Padding(3);
            this.DonePage.Size = new System.Drawing.Size(831, 357);
            this.DonePage.TabIndex = 1;
            this.DonePage.Text = "Done";
            this.DonePage.UseVisualStyleBackColor = true;
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(639, 224);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(104, 23);
            this.ClearListButton.TabIndex = 4;
            this.ClearListButton.Text = "Clear list";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // ViewDetailsDone
            // 
            this.ViewDetailsDone.Location = new System.Drawing.Point(639, 93);
            this.ViewDetailsDone.Name = "ViewDetailsDone";
            this.ViewDetailsDone.Size = new System.Drawing.Size(104, 23);
            this.ViewDetailsDone.TabIndex = 3;
            this.ViewDetailsDone.Text = "View details";
            this.ViewDetailsDone.UseVisualStyleBackColor = true;
            this.ViewDetailsDone.Click += new System.EventHandler(this.ViewDetailsDone_Click);
            // 
            // ListViewDone
            // 
            this.ListViewDone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.ListViewDone.FullRowSelect = true;
            this.ListViewDone.GridLines = true;
            this.ListViewDone.HideSelection = false;
            this.ListViewDone.Location = new System.Drawing.Point(0, 0);
            this.ListViewDone.Name = "ListViewDone";
            this.ListViewDone.Size = new System.Drawing.Size(538, 351);
            this.ListViewDone.TabIndex = 2;
            this.ListViewDone.UseCompatibleStateImageBehavior = false;
            this.ListViewDone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nume";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Deadline";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 375);
            this.Controls.Add(this.TabControl);
            this.Name = "HomePage";
            this.Text = "To-do list";
            this.TabControl.ResumeLayout(false);
            this.ToDoPage.ResumeLayout(false);
            this.DonePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ToDoPage;
        private System.Windows.Forms.TabPage DonePage;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader columnHeader;
        public System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Button MarkDoneButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView ListViewDone;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button ViewDetailsDone;
        private System.Windows.Forms.Button ClearListButton;
    }
}


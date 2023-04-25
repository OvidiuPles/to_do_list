namespace tema1
{
    partial class AddTaskPage
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DeadlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(219, 309);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.DateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume * : ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(116, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(370, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(151, 381);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 16);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Ora :";
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(219, 381);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(98, 22);
            this.TimePicker.TabIndex = 6;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(151, 309);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 16);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Data :";
            // 
            // DeadlineCheckBox
            // 
            this.DeadlineCheckBox.AutoSize = true;
            this.DeadlineCheckBox.Location = new System.Drawing.Point(30, 344);
            this.DeadlineCheckBox.Name = "DeadlineCheckBox";
            this.DeadlineCheckBox.Size = new System.Drawing.Size(84, 20);
            this.DeadlineCheckBox.TabIndex = 8;
            this.DeadlineCheckBox.Text = "Deadline";
            this.DeadlineCheckBox.UseVisualStyleBackColor = true;
            this.DeadlineCheckBox.CheckedChanged += new System.EventHandler(this.DeadlineCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Locatie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descriere :";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(116, 95);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(370, 95);
            this.DescriptionTextBox.TabIndex = 11;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(116, 218);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(370, 22);
            this.LocationTextBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(637, 370);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 27);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Adauga";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeadlineCheckBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "AddTaskPage";
            this.Text = "Add task";
            this.Load += new System.EventHandler(this.AddTaskPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.CheckBox DeadlineCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button AddButton;
    }
}
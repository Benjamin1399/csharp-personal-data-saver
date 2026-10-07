namespace PersonalDataSaver
{
    partial class PersonalDataForm
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
            this.appHeadingLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobCalender = new System.Windows.Forms.MonthCalendar();
            this.savePersonalDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appHeadingLabel
            // 
            this.appHeadingLabel.AutoSize = true;
            this.appHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appHeadingLabel.Location = new System.Drawing.Point(85, 9);
            this.appHeadingLabel.Name = "appHeadingLabel";
            this.appHeadingLabel.Size = new System.Drawing.Size(650, 36);
            this.appHeadingLabel.TabIndex = 0;
            this.appHeadingLabel.Text = "Welcome to Personal Data Saver Application";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(45, 80);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(288, 32);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Enter your First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(45, 148);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(287, 32);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Enter your Last Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(46, 214);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(228, 32);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Enter your D.O.B";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(350, 77);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(266, 38);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(350, 142);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(266, 38);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // dobCalender
            // 
            this.dobCalender.Location = new System.Drawing.Point(350, 214);
            this.dobCalender.MaxDate = new System.DateTime(2026, 10, 7, 0, 0, 0, 0);
            this.dobCalender.Name = "dobCalender";
            this.dobCalender.ShowToday = false;
            this.dobCalender.ShowTodayCircle = false;
            this.dobCalender.TabIndex = 6;
            // 
            // savePersonalDataButton
            // 
            this.savePersonalDataButton.Location = new System.Drawing.Point(52, 475);
            this.savePersonalDataButton.Name = "savePersonalDataButton";
            this.savePersonalDataButton.Size = new System.Drawing.Size(135, 41);
            this.savePersonalDataButton.TabIndex = 7;
            this.savePersonalDataButton.Text = "Save Data";
            this.savePersonalDataButton.UseVisualStyleBackColor = true;
            // 
            // PersonalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 555);
            this.Controls.Add(this.savePersonalDataButton);
            this.Controls.Add(this.dobCalender);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.appHeadingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PersonalDataForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appHeadingLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.MonthCalendar dobCalender;
        private System.Windows.Forms.Button savePersonalDataButton;
    }
}


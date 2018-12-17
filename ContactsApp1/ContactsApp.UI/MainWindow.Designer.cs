namespace ContactsApp.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.ProjectControl = new ContactsApp.UI.Controls.ProjectControl();
            this.ContactControl = new ContactsApp.UI.Controls.ContactControl();
            this.SuspendLayout();
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTextBox.Location = new System.Drawing.Point(330, 250);
            this.BirthdayTextBox.Multiline = true;
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.ReadOnly = true;
            this.BirthdayTextBox.Size = new System.Drawing.Size(409, 80);
            this.BirthdayTextBox.TabIndex = 2;
            // 
            // ProjectControl
            // 
            this.ProjectControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectControl.Location = new System.Drawing.Point(12, 8);
            this.ProjectControl.Name = "ProjectControl";
            this.ProjectControl.Project = null;
            this.ProjectControl.SelectedContact = null;
            this.ProjectControl.Size = new System.Drawing.Size(255, 340);
            this.ProjectControl.TabIndex = 1;
            // 
            // ContactControl
            // 
            this.ContactControl.BackColor = System.Drawing.SystemColors.Control;
            this.ContactControl.Enabled = false;
            this.ContactControl.Location = new System.Drawing.Point(312, 63);
            this.ContactControl.Name = "ContactControl";
            this.ContactControl.Size = new System.Drawing.Size(427, 175);
            this.ContactControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 360);
            this.Controls.Add(this.BirthdayTextBox);
            this.Controls.Add(this.ProjectControl);
            this.Controls.Add(this.ContactControl);
            this.MinimumSize = new System.Drawing.Size(776, 399);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ContactControl ContactControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.ProjectControl ProjectControl;
        private System.Windows.Forms.TextBox BirthdayTextBox;
    }
}


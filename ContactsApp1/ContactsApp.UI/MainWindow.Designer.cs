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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.happyBirthdayPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjectControl = new ContactsApp.UI.Controls.ProjectControl();
            this.ContactControl = new ContactsApp.UI.Controls.ContactControl();
            this.happyBirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BirthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BirthdayTextBox.Location = new System.Drawing.Point(103, 27);
            this.BirthdayTextBox.Multiline = true;
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.ReadOnly = true;
            this.BirthdayTextBox.Size = new System.Drawing.Size(381, 73);
            this.BirthdayTextBox.TabIndex = 2;
            // 
            // happyBirthdayPanel
            // 
            this.happyBirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.happyBirthdayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.happyBirthdayPanel.Controls.Add(this.BirthdayTextBox);
            this.happyBirthdayPanel.Controls.Add(this.pictureBox1);
            this.happyBirthdayPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.happyBirthdayPanel.Location = new System.Drawing.Point(273, 260);
            this.happyBirthdayPanel.Name = "happyBirthdayPanel";
            this.happyBirthdayPanel.Size = new System.Drawing.Size(487, 100);
            this.happyBirthdayPanel.TabIndex = 3;
            this.happyBirthdayPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(90, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.happyBirthdayPanel);
            this.Controls.Add(this.ProjectControl);
            this.Controls.Add(this.ContactControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(776, 399);
            this.Name = "MainWindow";
            this.Text = "ContactsApp";
            this.happyBirthdayPanel.ResumeLayout(false);
            this.happyBirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ContactControl ContactControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.ProjectControl ProjectControl;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.Panel happyBirthdayPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


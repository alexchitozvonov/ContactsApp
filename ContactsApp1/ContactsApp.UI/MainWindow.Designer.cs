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
            this.ProjectControl = new ContactsApp.UI.Controls.ProjectControl();
            this.ContactControl = new ContactsApp.UI.Controls.ContactControl();
            this.SuspendLayout();
            // 
            // ProjectControl
            // 
            this.ProjectControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectControl.Location = new System.Drawing.Point(13, 13);
            this.ProjectControl.Name = "ProjectControl";
            this.ProjectControl.Project = null;
            this.ProjectControl.Size = new System.Drawing.Size(250, 257);
            this.ProjectControl.TabIndex = 1;
            // 
            // ContactControl
            // 
            this.ContactControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactControl.Location = new System.Drawing.Point(269, 13);
            this.ContactControl.Name = "ContactControl";
            this.ContactControl.Size = new System.Drawing.Size(299, 151);
            this.ContactControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(561, 273);
            this.Controls.Add(this.ProjectControl);
            this.Controls.Add(this.ContactControl);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ContactControl ContactControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.ProjectControl ProjectControl;
    }
}


using System.ComponentModel;

namespace ContactsApp.UI.Controls
{
    [ToolboxItem(true)]
    partial class ContactControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BurthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vkcomLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BurthdayLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.VkcomTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(61, 8);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(199, 20);
            this.SurnameTextBox.TabIndex = 16;
            // 
            // BurthdayDateTimePicker
            // 
            this.BurthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BurthdayDateTimePicker.Location = new System.Drawing.Point(61, 60);
            this.BurthdayDateTimePicker.Name = "BurthdayDateTimePicker";
            this.BurthdayDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.BurthdayDateTimePicker.TabIndex = 15;
            // 
            // vkcomLabel
            // 
            this.vkcomLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vkcomLabel.AutoSize = true;
            this.vkcomLabel.Location = new System.Drawing.Point(10, 141);
            this.vkcomLabel.Name = "vkcomLabel";
            this.vkcomLabel.Size = new System.Drawing.Size(45, 13);
            this.vkcomLabel.TabIndex = 14;
            this.vkcomLabel.Text = "vk.com:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 115);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "E-mail:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(14, 90);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(41, 13);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Phone:";
            // 
            // BurthdayLabel
            // 
            this.BurthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BurthdayLabel.AutoSize = true;
            this.BurthdayLabel.Location = new System.Drawing.Point(3, 64);
            this.BurthdayLabel.Name = "BurthdayLabel";
            this.BurthdayLabel.Size = new System.Drawing.Size(52, 13);
            this.BurthdayLabel.TabIndex = 11;
            this.BurthdayLabel.Text = "Burthday:";
            this.BurthdayLabel.Click += new System.EventHandler(this.BurthdayLabel_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(3, 12);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 10;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(61, 34);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 20);
            this.NameTextBox.TabIndex = 17;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(61, 111);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(199, 20);
            this.EmailTextBox.TabIndex = 19;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(61, 86);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(199, 20);
            this.PhoneTextBox.TabIndex = 18;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged_1);
            // 
            // VkcomTextBox
            // 
            this.VkcomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkcomTextBox.Location = new System.Drawing.Point(61, 137);
            this.VkcomTextBox.Name = "VkcomTextBox";
            this.VkcomTextBox.Size = new System.Drawing.Size(199, 20);
            this.VkcomTextBox.TabIndex = 20;
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VkcomTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.BurthdayDateTimePicker);
            this.Controls.Add(this.vkcomLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.BurthdayLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(263, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vkcomLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BurthdayLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.TextBox SurnameTextBox;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.DateTimePicker BurthdayDateTimePicker;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.TextBox VkcomTextBox;
    }
}

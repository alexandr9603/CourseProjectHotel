namespace Course_Db
{
    partial class AdminPanel
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
            this.Info_admin = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Try = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info_admin
            // 
            this.Info_admin.AutoSize = true;
            this.Info_admin.ForeColor = System.Drawing.Color.Red;
            this.Info_admin.Location = new System.Drawing.Point(30, 82);
            this.Info_admin.Name = "Info_admin";
            this.Info_admin.Size = new System.Drawing.Size(242, 13);
            this.Info_admin.TabIndex = 0;
            this.Info_admin.Text = "Введите уникальный пароль администратора:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(95, 120);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            // 
            // Try
            // 
            this.Try.Location = new System.Drawing.Point(107, 157);
            this.Try.Name = "Try";
            this.Try.Size = new System.Drawing.Size(75, 23);
            this.Try.TabIndex = 2;
            this.Try.Text = "Проверить";
            this.Try.UseVisualStyleBackColor = true;
            this.Try.Click += new System.EventHandler(this.Try_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.ForeColor = System.Drawing.SystemColors.Control;
            this.Back.Location = new System.Drawing.Point(107, 217);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Try);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Info_admin);
            this.Name = "AdminPanel";
            this.Text = "Administrator panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info_admin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Try;
        private System.Windows.Forms.Button Back;
    }
}
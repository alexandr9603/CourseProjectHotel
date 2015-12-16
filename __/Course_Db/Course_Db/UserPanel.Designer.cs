namespace Course_Db
{
    partial class UserPanel
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
            this.Info_user = new System.Windows.Forms.Label();
            this.Comfort = new System.Windows.Forms.Label();
            this.Roominess = new System.Windows.Forms.Label();
            this.Choose_Comfort = new System.Windows.Forms.ComboBox();
            this.Choose_roominess = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info_user
            // 
            this.Info_user.AutoSize = true;
            this.Info_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info_user.Location = new System.Drawing.Point(39, 22);
            this.Info_user.Name = "Info_user";
            this.Info_user.Size = new System.Drawing.Size(221, 13);
            this.Info_user.TabIndex = 0;
            this.Info_user.Text = "Выберите параметры желаемого номера:";
            // 
            // Comfort
            // 
            this.Comfort.AutoSize = true;
            this.Comfort.ForeColor = System.Drawing.Color.Red;
            this.Comfort.Location = new System.Drawing.Point(39, 60);
            this.Comfort.Name = "Comfort";
            this.Comfort.Size = new System.Drawing.Size(85, 13);
            this.Comfort.TabIndex = 1;
            this.Comfort.Text = "Комфортность:";
            // 
            // Roominess
            // 
            this.Roominess.AutoSize = true;
            this.Roominess.ForeColor = System.Drawing.Color.Red;
            this.Roominess.Location = new System.Drawing.Point(39, 135);
            this.Roominess.Name = "Roominess";
            this.Roominess.Size = new System.Drawing.Size(79, 13);
            this.Roominess.TabIndex = 2;
            this.Roominess.Text = "Вместимость:";
            // 
            // Choose_Comfort
            // 
            this.Choose_Comfort.FormattingEnabled = true;
            this.Choose_Comfort.Location = new System.Drawing.Point(42, 93);
            this.Choose_Comfort.Name = "Choose_Comfort";
            this.Choose_Comfort.Size = new System.Drawing.Size(121, 21);
            this.Choose_Comfort.TabIndex = 3;
            // 
            // Choose_roominess
            // 
            this.Choose_roominess.FormattingEnabled = true;
            this.Choose_roominess.Location = new System.Drawing.Point(42, 169);
            this.Choose_roominess.Name = "Choose_roominess";
            this.Choose_roominess.Size = new System.Drawing.Size(121, 21);
            this.Choose_roominess.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(42, 239);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "Оформить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.ForeColor = System.Drawing.SystemColors.Control;
            this.Back.Location = new System.Drawing.Point(169, 239);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Choose_roominess);
            this.Controls.Add(this.Choose_Comfort);
            this.Controls.Add(this.Roominess);
            this.Controls.Add(this.Comfort);
            this.Controls.Add(this.Info_user);
            this.Name = "UserPanel";
            this.Text = "User Window";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info_user;
        private System.Windows.Forms.Label Comfort;
        private System.Windows.Forms.Label Roominess;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Back;
        public System.Windows.Forms.ComboBox Choose_Comfort;
        public System.Windows.Forms.ComboBox Choose_roominess;
    }
}
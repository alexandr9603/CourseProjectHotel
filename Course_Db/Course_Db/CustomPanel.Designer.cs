namespace Course_Db
{
    partial class CustomPanel
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
            this.Data_Field = new System.Windows.Forms.DataGridView();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FreeInfo = new System.Windows.Forms.ComboBox();
            this.ComfortInfo = new System.Windows.Forms.ComboBox();
            this.Pass = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Pledge = new System.Windows.Forms.Label();
            this.Pass_field = new System.Windows.Forms.TextBox();
            this.Pledge_field = new System.Windows.Forms.TextBox();
            this.Name_Field = new System.Windows.Forms.TextBox();
            this.Phone_field = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Field
            // 
            this.Data_Field.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Field.Location = new System.Drawing.Point(21, 37);
            this.Data_Field.Name = "Data_Field";
            this.Data_Field.Size = new System.Drawing.Size(515, 63);
            this.Data_Field.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(163, 281);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Оформить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton.Location = new System.Drawing.Point(386, 281);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FreeInfo
            // 
            this.FreeInfo.FormattingEnabled = true;
            this.FreeInfo.Location = new System.Drawing.Point(56, 37);
            this.FreeInfo.Name = "FreeInfo";
            this.FreeInfo.Size = new System.Drawing.Size(156, 21);
            this.FreeInfo.TabIndex = 3;
            // 
            // ComfortInfo
            // 
            this.ComfortInfo.FormattingEnabled = true;
            this.ComfortInfo.Location = new System.Drawing.Point(360, 37);
            this.ComfortInfo.Name = "ComfortInfo";
            this.ComfortInfo.Size = new System.Drawing.Size(156, 21);
            this.ComfortInfo.TabIndex = 4;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(231, 9);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(94, 13);
            this.Pass.TabIndex = 5;
            this.Pass.Text = "Номер паспорта:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(226, 74);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(180, 13);
            this.Name.TabIndex = 6;
            this.Name.Text = "Полное имя, фамилия и отчество:";
            // 
            // Pledge
            // 
            this.Pledge.AutoSize = true;
            this.Pledge.Location = new System.Drawing.Point(226, 142);
            this.Pledge.Name = "Pledge";
            this.Pledge.Size = new System.Drawing.Size(40, 13);
            this.Pledge.TabIndex = 7;
            this.Pledge.Text = "Залог:";
            // 
            // Pass_field
            // 
            this.Pass_field.Location = new System.Drawing.Point(229, 38);
            this.Pass_field.Name = "Pass_field";
            this.Pass_field.Size = new System.Drawing.Size(177, 20);
            this.Pass_field.TabIndex = 8;
            // 
            // Pledge_field
            // 
            this.Pledge_field.Location = new System.Drawing.Point(229, 167);
            this.Pledge_field.Name = "Pledge_field";
            this.Pledge_field.Size = new System.Drawing.Size(177, 20);
            this.Pledge_field.TabIndex = 9;
            // 
            // Name_Field
            // 
            this.Name_Field.Location = new System.Drawing.Point(229, 106);
            this.Name_Field.Name = "Name_Field";
            this.Name_Field.Size = new System.Drawing.Size(177, 20);
            this.Name_Field.TabIndex = 10;
            // 
            // Phone_field
            // 
            this.Phone_field.Location = new System.Drawing.Point(229, 236);
            this.Phone_field.Name = "Phone_field";
            this.Phone_field.Size = new System.Drawing.Size(177, 20);
            this.Phone_field.TabIndex = 11;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(226, 203);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(96, 13);
            this.Phone.TabIndex = 12;
            this.Phone.Text = "Номер телефона:";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(163, 281);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 13;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // CustomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 329);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Phone_field);
            this.Controls.Add(this.Name_Field);
            this.Controls.Add(this.Pledge_field);
            this.Controls.Add(this.Pass_field);
            this.Controls.Add(this.Pledge);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.ComfortInfo);
            this.Controls.Add(this.FreeInfo);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.Data_Field);
            this.Text = "CustomPanel";
            this.Load += new System.EventHandler(this.CustomPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Field;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox FreeInfo;
        private System.Windows.Forms.ComboBox ComfortInfo;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Pledge;
        private System.Windows.Forms.TextBox Pass_field;
        private System.Windows.Forms.TextBox Pledge_field;
        private System.Windows.Forms.TextBox Name_Field;
        private System.Windows.Forms.TextBox Phone_field;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button Send;
    }
}
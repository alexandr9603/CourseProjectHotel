namespace Course_Db
{
    partial class ControlPanel
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
            this.ControlInfo = new System.Windows.Forms.Label();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.Raise_Price = new System.Windows.Forms.Button();
            this.Delete_client = new System.Windows.Forms.Button();
            this.Pay_button = new System.Windows.Forms.Button();
            this.Field_to_show_data = new System.Windows.Forms.DataGridView();
            this.Clients_Info = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Price_raise = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.ComboBox();
            this.Payment_field = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthWork = new System.Windows.Forms.Button();
            this.MonthBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Field_to_show_data)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlInfo
            // 
            this.ControlInfo.AutoSize = true;
            this.ControlInfo.Location = new System.Drawing.Point(643, 36);
            this.ControlInfo.Name = "ControlInfo";
            this.ControlInfo.Size = new System.Drawing.Size(113, 13);
            this.ControlInfo.TabIndex = 0;
            this.ControlInfo.Text = "Выберите действие: ";
            // 
            // ShowInfo
            // 
            this.ShowInfo.Location = new System.Drawing.Point(646, 68);
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.Size = new System.Drawing.Size(83, 56);
            this.ShowInfo.TabIndex = 1;
            this.ShowInfo.Text = "Просмотреть информацию о клиентах";
            this.ShowInfo.UseVisualStyleBackColor = true;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // Raise_Price
            // 
            this.Raise_Price.Location = new System.Drawing.Point(627, 181);
            this.Raise_Price.Name = "Raise_Price";
            this.Raise_Price.Size = new System.Drawing.Size(146, 72);
            this.Raise_Price.TabIndex = 2;
            this.Raise_Price.Text = "Повысить цены в отеле(укажите в процентах, на сколько следует повысить цены)";
            this.Raise_Price.UseVisualStyleBackColor = true;
            this.Raise_Price.Click += new System.EventHandler(this.Raise_Price_Click);
            // 
            // Delete_client
            // 
            this.Delete_client.Location = new System.Drawing.Point(625, 312);
            this.Delete_client.Name = "Delete_client";
            this.Delete_client.Size = new System.Drawing.Size(121, 34);
            this.Delete_client.TabIndex = 3;
            this.Delete_client.Text = "Удалить клиента из базы";
            this.Delete_client.UseVisualStyleBackColor = true;
            this.Delete_client.Click += new System.EventHandler(this.Delete_client_Click);
            // 
            // Pay_button
            // 
            this.Pay_button.Location = new System.Drawing.Point(625, 403);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.Size = new System.Drawing.Size(121, 23);
            this.Pay_button.TabIndex = 4;
            this.Pay_button.Text = "Принять оплату";
            this.Pay_button.UseVisualStyleBackColor = true;
            this.Pay_button.Click += new System.EventHandler(this.Pay_button_Click);
            // 
            // Field_to_show_data
            // 
            this.Field_to_show_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Field_to_show_data.Location = new System.Drawing.Point(124, 111);
            this.Field_to_show_data.Name = "Field_to_show_data";
            this.Field_to_show_data.Size = new System.Drawing.Size(478, 272);
            this.Field_to_show_data.TabIndex = 6;
            // 
            // Clients_Info
            // 
            this.Clients_Info.BackColor = System.Drawing.Color.Red;
            this.Clients_Info.ForeColor = System.Drawing.Color.Cornsilk;
            this.Clients_Info.Location = new System.Drawing.Point(219, 48);
            this.Clients_Info.Name = "Clients_Info";
            this.Clients_Info.Size = new System.Drawing.Size(283, 20);
            this.Clients_Info.TabIndex = 7;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(336, 414);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Price_raise
            // 
            this.Price_raise.Location = new System.Drawing.Point(646, 155);
            this.Price_raise.Name = "Price_raise";
            this.Price_raise.Size = new System.Drawing.Size(100, 20);
            this.Price_raise.TabIndex = 9;
            // 
            // Delete
            // 
            this.Delete.FormattingEnabled = true;
            this.Delete.Location = new System.Drawing.Point(625, 271);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 21);
            this.Delete.TabIndex = 10;
            // 
            // Payment_field
            // 
            this.Payment_field.FormattingEnabled = true;
            this.Payment_field.Location = new System.Drawing.Point(627, 362);
            this.Payment_field.Name = "Payment_field";
            this.Payment_field.Size = new System.Drawing.Size(121, 21);
            this.Payment_field.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Отчетность:";
            // 
            // MonthWork
            // 
            this.MonthWork.Location = new System.Drawing.Point(12, 120);
            this.MonthWork.Name = "MonthWork";
            this.MonthWork.Size = new System.Drawing.Size(85, 55);
            this.MonthWork.TabIndex = 14;
            this.MonthWork.Text = "Получить отчет по складу залогов";
            this.MonthWork.UseVisualStyleBackColor = true;
            this.MonthWork.Click += new System.EventHandler(this.MonthWork_Click);
            // 
            // MonthBill
            // 
            this.MonthBill.Location = new System.Drawing.Point(10, 211);
            this.MonthBill.Name = "MonthBill";
            this.MonthBill.Size = new System.Drawing.Size(87, 62);
            this.MonthBill.TabIndex = 15;
            this.MonthBill.Text = "Получить отчет о доходах отеля";
            this.MonthBill.UseVisualStyleBackColor = true;
            this.MonthBill.Click += new System.EventHandler(this.MonthBill_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.MonthBill);
            this.Controls.Add(this.MonthWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Payment_field);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Price_raise);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Clients_Info);
            this.Controls.Add(this.Field_to_show_data);
            this.Controls.Add(this.Pay_button);
            this.Controls.Add(this.Delete_client);
            this.Controls.Add(this.Raise_Price);
            this.Controls.Add(this.ShowInfo);
            this.Controls.Add(this.ControlInfo);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Field_to_show_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ControlInfo;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Button Raise_Price;
        private System.Windows.Forms.Button Delete_client;
        private System.Windows.Forms.Button Pay_button;
        private System.Windows.Forms.DataGridView Field_to_show_data;
        private System.Windows.Forms.TextBox Clients_Info;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Price_raise;
        private System.Windows.Forms.ComboBox Delete;
        private System.Windows.Forms.ComboBox Payment_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MonthWork;
        private System.Windows.Forms.Button MonthBill;
    }
}
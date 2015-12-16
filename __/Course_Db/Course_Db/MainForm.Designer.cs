namespace Course_Db
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GoToAdminPanel = new System.Windows.Forms.Button();
            this.MakeCustom = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoToAdminPanel
            // 
            this.GoToAdminPanel.Location = new System.Drawing.Point(80, 109);
            this.GoToAdminPanel.Name = "GoToAdminPanel";
            this.GoToAdminPanel.Size = new System.Drawing.Size(122, 23);
            this.GoToAdminPanel.TabIndex = 1;
            this.GoToAdminPanel.Text = "Админ-панель отеля";
            this.GoToAdminPanel.UseVisualStyleBackColor = true;
            this.GoToAdminPanel.Click += new System.EventHandler(this.GoToAdminPanel_Click);
            // 
            // MakeCustom
            // 
            this.MakeCustom.Location = new System.Drawing.Point(80, 138);
            this.MakeCustom.Name = "MakeCustom";
            this.MakeCustom.Size = new System.Drawing.Size(122, 23);
            this.MakeCustom.TabIndex = 2;
            this.MakeCustom.Text = "Сделать заказ";
            this.MakeCustom.UseVisualStyleBackColor = true;
            this.MakeCustom.Click += new System.EventHandler(this.MakeCustom_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(80, 167);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(122, 23);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Выйти";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.MakeCustom);
            this.Controls.Add(this.GoToAdminPanel);
            this.Name = "MainForm";
            this.Text = "Hotel \"Cortez\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToAdminPanel;
        private System.Windows.Forms.Button MakeCustom;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label1;
    }
}


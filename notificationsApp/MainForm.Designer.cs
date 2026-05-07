namespace notificationsApp
{
    partial class MainForm
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMessage.Location = new System.Drawing.Point(23, 159);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(242, 34);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Tag = "";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.BackColor = System.Drawing.Color.SlateGray;
            this.comboBoxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(57, 117);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(171, 21);
            this.comboBoxServices.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(73, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBoxLogs.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxLogs.Location = new System.Drawing.Point(3, 22);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.Size = new System.Drawing.Size(290, 416);
            this.richTextBoxLogs.TabIndex = 3;
            this.richTextBoxLogs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Мессенджер";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxServices);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(365, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 311);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(692, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(121, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "deadline";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxLogs);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}


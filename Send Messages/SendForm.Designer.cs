
namespace Send_Messages
{
    partial class SendForm
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
            this.TextGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendingMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.SendLaterDate = new System.Windows.Forms.DateTimePicker();
            this.SendLaterRadio = new System.Windows.Forms.RadioButton();
            this.SendNowRadio = new System.Windows.Forms.RadioButton();
            this.ActionGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextGroupBox.SuspendLayout();
            this.SendingMethodGroupBox.SuspendLayout();
            this.ActionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextGroupBox
            // 
            this.TextGroupBox.Controls.Add(this.textBox1);
            this.TextGroupBox.Location = new System.Drawing.Point(13, 64);
            this.TextGroupBox.Name = "TextGroupBox";
            this.TextGroupBox.Size = new System.Drawing.Size(535, 210);
            this.TextGroupBox.TabIndex = 0;
            this.TextGroupBox.TabStop = false;
            this.TextGroupBox.Text = "Text:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 236);
            this.textBox1.TabIndex = 0;
            // 
            // SendingMethodGroupBox
            // 
            this.SendingMethodGroupBox.Controls.Add(this.SendLaterDate);
            this.SendingMethodGroupBox.Controls.Add(this.SendLaterRadio);
            this.SendingMethodGroupBox.Controls.Add(this.SendNowRadio);
            this.SendingMethodGroupBox.Location = new System.Drawing.Point(20, 281);
            this.SendingMethodGroupBox.Name = "SendingMethodGroupBox";
            this.SendingMethodGroupBox.Size = new System.Drawing.Size(522, 106);
            this.SendingMethodGroupBox.TabIndex = 1;
            this.SendingMethodGroupBox.TabStop = false;
            this.SendingMethodGroupBox.Text = "Sending Method";
            // 
            // SendLaterDate
            // 
            this.SendLaterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SendLaterDate.Location = new System.Drawing.Point(6, 67);
            this.SendLaterDate.Name = "SendLaterDate";
            this.SendLaterDate.Size = new System.Drawing.Size(146, 20);
            this.SendLaterDate.TabIndex = 2;
            // 
            // SendLaterRadio
            // 
            this.SendLaterRadio.AutoSize = true;
            this.SendLaterRadio.Location = new System.Drawing.Point(7, 44);
            this.SendLaterRadio.Name = "SendLaterRadio";
            this.SendLaterRadio.Size = new System.Drawing.Size(77, 17);
            this.SendLaterRadio.TabIndex = 1;
            this.SendLaterRadio.TabStop = true;
            this.SendLaterRadio.Text = "Send Later";
            this.SendLaterRadio.UseVisualStyleBackColor = true;
            this.SendLaterRadio.CheckedChanged += new System.EventHandler(this.SendLaterRadio_CheckedChanged);
            // 
            // SendNowRadio
            // 
            this.SendNowRadio.AutoSize = true;
            this.SendNowRadio.Checked = true;
            this.SendNowRadio.Location = new System.Drawing.Point(7, 20);
            this.SendNowRadio.Name = "SendNowRadio";
            this.SendNowRadio.Size = new System.Drawing.Size(75, 17);
            this.SendNowRadio.TabIndex = 0;
            this.SendNowRadio.TabStop = true;
            this.SendNowRadio.Text = "Send Now";
            this.SendNowRadio.UseVisualStyleBackColor = true;
            this.SendNowRadio.CheckedChanged += new System.EventHandler(this.SendNowRadio_CheckedChanged);
            // 
            // ActionGroupBox
            // 
            this.ActionGroupBox.Controls.Add(this.CancelBtn);
            this.ActionGroupBox.Controls.Add(this.SendBtn);
            this.ActionGroupBox.Location = new System.Drawing.Point(20, 393);
            this.ActionGroupBox.Name = "ActionGroupBox";
            this.ActionGroupBox.Size = new System.Drawing.Size(522, 108);
            this.ActionGroupBox.TabIndex = 2;
            this.ActionGroupBox.TabStop = false;
            this.ActionGroupBox.Text = "Action";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(348, 44);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(77, 44);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Send_Messages.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ActionGroupBox);
            this.Controls.Add(this.SendingMethodGroupBox);
            this.Controls.Add(this.TextGroupBox);
            this.Name = "SendForm";
            this.Text = "Send Form";
            this.TextGroupBox.ResumeLayout(false);
            this.TextGroupBox.PerformLayout();
            this.SendingMethodGroupBox.ResumeLayout(false);
            this.SendingMethodGroupBox.PerformLayout();
            this.ActionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TextGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox SendingMethodGroupBox;
        private System.Windows.Forms.DateTimePicker SendLaterDate;
        private System.Windows.Forms.RadioButton SendLaterRadio;
        private System.Windows.Forms.RadioButton SendNowRadio;
        private System.Windows.Forms.GroupBox ActionGroupBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
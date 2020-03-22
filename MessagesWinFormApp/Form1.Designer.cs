﻿namespace MessagesWinFormApp
{
    partial class frmMessageFormatting
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
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.cmbSelectFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMessages.Location = new System.Drawing.Point(311, 23);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(451, 405);
            this.rtbMessages.TabIndex = 0;
            this.rtbMessages.Text = "";
            this.rtbMessages.TextChanged += new System.EventHandler(this.rtbMessages_TextChanged_1);
            // 
            // cmbSelectFormat
            // 
            this.cmbSelectFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSelectFormat.FormattingEnabled = true;
            this.cmbSelectFormat.Items.AddRange(new object[] {
            "None",
            "UpperCase",
            "LowerCase",
            "End with DateTime"});
            this.cmbSelectFormat.Location = new System.Drawing.Point(26, 109);
            this.cmbSelectFormat.Name = "cmbSelectFormat";
            this.cmbSelectFormat.Size = new System.Drawing.Size(233, 32);
            this.cmbSelectFormat.TabIndex = 2;
            this.cmbSelectFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbSelectFormat.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose format for \r\ngenerating messages:";
            // 
            // frmMessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectFormat);
            this.Controls.Add(this.rtbMessages);
            this.MaximizeBox = false;
            this.Name = "frmMessageFormatting";
            this.Text = "Message Formatting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ComboBox cmbSelectFormat;
        private System.Windows.Forms.Label label1;
    }
}


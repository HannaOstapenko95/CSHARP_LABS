namespace MobileWinFormApp
{
    partial class Form1
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
            this.rdbIphoneHeadset = new System.Windows.Forms.RadioButton();
            this.rdbSamsungHeadset = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdbPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.rdbUnofficialPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.rdbPowerBank = new System.Windows.Forms.RadioButton();
            this.rdbCharger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbWalletCase = new System.Windows.Forms.RadioButton();
            this.rdbFolioCase = new System.Windows.Forms.RadioButton();
            this.rdbSlimCase = new System.Windows.Forms.RadioButton();
            this.rdbToughCase = new System.Windows.Forms.RadioButton();
            this.rdbBookCase = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbSingleTouch = new System.Windows.Forms.RadioButton();
            this.rdbMultiTouch = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbIphoneHeadset
            // 
            this.rdbIphoneHeadset.AutoSize = true;
            this.rdbIphoneHeadset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbIphoneHeadset.Location = new System.Drawing.Point(11, 41);
            this.rdbIphoneHeadset.Name = "rdbIphoneHeadset";
            this.rdbIphoneHeadset.Size = new System.Drawing.Size(210, 33);
            this.rdbIphoneHeadset.TabIndex = 0;
            this.rdbIphoneHeadset.TabStop = true;
            this.rdbIphoneHeadset.Text = "IPhoneHeadset";
            this.rdbIphoneHeadset.UseVisualStyleBackColor = true;
            this.rdbIphoneHeadset.CheckedChanged += new System.EventHandler(this.IphoneHeadset_CheckedChanged);
            // 
            // rdbSamsungHeadset
            // 
            this.rdbSamsungHeadset.AutoSize = true;
            this.rdbSamsungHeadset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSamsungHeadset.Location = new System.Drawing.Point(11, 89);
            this.rdbSamsungHeadset.Name = "rdbSamsungHeadset";
            this.rdbSamsungHeadset.Size = new System.Drawing.Size(236, 33);
            this.rdbSamsungHeadset.TabIndex = 1;
            this.rdbSamsungHeadset.TabStop = true;
            this.rdbSamsungHeadset.Text = "SamsungHeadset";
            this.rdbSamsungHeadset.UseVisualStyleBackColor = true;
            this.rdbSamsungHeadset.CheckedChanged += new System.EventHandler(this.rdbSamsungHeadset_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(12, 465);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(130, 72);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "APPLY";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(711, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 531);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rdbPhoneSpeaker
            // 
            this.rdbPhoneSpeaker.AutoSize = true;
            this.rdbPhoneSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbPhoneSpeaker.Location = new System.Drawing.Point(11, 136);
            this.rdbPhoneSpeaker.Name = "rdbPhoneSpeaker";
            this.rdbPhoneSpeaker.Size = new System.Drawing.Size(204, 33);
            this.rdbPhoneSpeaker.TabIndex = 4;
            this.rdbPhoneSpeaker.TabStop = true;
            this.rdbPhoneSpeaker.Text = "PhoneSpeaker";
            this.rdbPhoneSpeaker.UseVisualStyleBackColor = true;
            this.rdbPhoneSpeaker.CheckedChanged += new System.EventHandler(this.rdbPhoneSpeaker_CheckedChanged);
            // 
            // rdbUnofficialPhoneHeadset
            // 
            this.rdbUnofficialPhoneHeadset.AutoSize = true;
            this.rdbUnofficialPhoneHeadset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbUnofficialPhoneHeadset.Location = new System.Drawing.Point(10, 186);
            this.rdbUnofficialPhoneHeadset.Name = "rdbUnofficialPhoneHeadset";
            this.rdbUnofficialPhoneHeadset.Size = new System.Drawing.Size(312, 33);
            this.rdbUnofficialPhoneHeadset.TabIndex = 5;
            this.rdbUnofficialPhoneHeadset.TabStop = true;
            this.rdbUnofficialPhoneHeadset.Text = "UnofficialPhoneHeadset";
            this.rdbUnofficialPhoneHeadset.UseVisualStyleBackColor = true;
            this.rdbUnofficialPhoneHeadset.CheckedChanged += new System.EventHandler(this.rdbUnofficialPhoneHeadset_CheckedChanged);
            // 
            // rdbPowerBank
            // 
            this.rdbPowerBank.AutoSize = true;
            this.rdbPowerBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbPowerBank.Location = new System.Drawing.Point(8, 41);
            this.rdbPowerBank.Name = "rdbPowerBank";
            this.rdbPowerBank.Size = new System.Drawing.Size(164, 33);
            this.rdbPowerBank.TabIndex = 8;
            this.rdbPowerBank.TabStop = true;
            this.rdbPowerBank.Text = "PowerBank";
            this.rdbPowerBank.UseVisualStyleBackColor = true;
            this.rdbPowerBank.CheckedChanged += new System.EventHandler(this.rdbPowerBank_CheckedChanged);
            // 
            // rdbCharger
            // 
            this.rdbCharger.AutoSize = true;
            this.rdbCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbCharger.Location = new System.Drawing.Point(8, 90);
            this.rdbCharger.Name = "rdbCharger";
            this.rdbCharger.Size = new System.Drawing.Size(125, 33);
            this.rdbCharger.TabIndex = 9;
            this.rdbCharger.TabStop = true;
            this.rdbCharger.Text = "Charger";
            this.rdbCharger.UseVisualStyleBackColor = true;
            this.rdbCharger.CheckedChanged += new System.EventHandler(this.rdbCharger_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCharger);
            this.groupBox1.Controls.Add(this.rdbPowerBank);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Charger type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPhoneSpeaker);
            this.groupBox2.Controls.Add(this.rdbSamsungHeadset);
            this.groupBox2.Controls.Add(this.rdbUnofficialPhoneHeadset);
            this.groupBox2.Controls.Add(this.rdbIphoneHeadset);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 247);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Headset type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbWalletCase);
            this.groupBox3.Controls.Add(this.rdbFolioCase);
            this.groupBox3.Controls.Add(this.rdbSlimCase);
            this.groupBox3.Controls.Add(this.rdbToughCase);
            this.groupBox3.Controls.Add(this.rdbBookCase);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(351, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 255);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Case type:";
            // 
            // rdbWalletCase
            // 
            this.rdbWalletCase.AutoSize = true;
            this.rdbWalletCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbWalletCase.Location = new System.Drawing.Point(6, 203);
            this.rdbWalletCase.Name = "rdbWalletCase";
            this.rdbWalletCase.Size = new System.Drawing.Size(164, 33);
            this.rdbWalletCase.TabIndex = 14;
            this.rdbWalletCase.TabStop = true;
            this.rdbWalletCase.Text = "WalletCase";
            this.rdbWalletCase.UseVisualStyleBackColor = true;
            this.rdbWalletCase.CheckedChanged += new System.EventHandler(this.rdbWalletCase_CheckedChanged);
            // 
            // rdbFolioCase
            // 
            this.rdbFolioCase.AutoSize = true;
            this.rdbFolioCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbFolioCase.Location = new System.Drawing.Point(7, 164);
            this.rdbFolioCase.Name = "rdbFolioCase";
            this.rdbFolioCase.Size = new System.Drawing.Size(151, 33);
            this.rdbFolioCase.TabIndex = 13;
            this.rdbFolioCase.TabStop = true;
            this.rdbFolioCase.Text = "FolioCase";
            this.rdbFolioCase.UseVisualStyleBackColor = true;
            this.rdbFolioCase.CheckedChanged += new System.EventHandler(this.rdbFolioCase_CheckedChanged);
            // 
            // rdbSlimCase
            // 
            this.rdbSlimCase.AutoSize = true;
            this.rdbSlimCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSlimCase.Location = new System.Drawing.Point(7, 125);
            this.rdbSlimCase.Name = "rdbSlimCase";
            this.rdbSlimCase.Size = new System.Drawing.Size(143, 33);
            this.rdbSlimCase.TabIndex = 12;
            this.rdbSlimCase.TabStop = true;
            this.rdbSlimCase.Text = "SlimCase";
            this.rdbSlimCase.UseVisualStyleBackColor = true;
            this.rdbSlimCase.CheckedChanged += new System.EventHandler(this.rdbSlimCase_CheckedChanged);
            // 
            // rdbToughCase
            // 
            this.rdbToughCase.AutoSize = true;
            this.rdbToughCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbToughCase.Location = new System.Drawing.Point(6, 86);
            this.rdbToughCase.Name = "rdbToughCase";
            this.rdbToughCase.Size = new System.Drawing.Size(166, 33);
            this.rdbToughCase.TabIndex = 11;
            this.rdbToughCase.TabStop = true;
            this.rdbToughCase.Text = "ToughCase";
            this.rdbToughCase.UseVisualStyleBackColor = true;
            this.rdbToughCase.CheckedChanged += new System.EventHandler(this.rdbToughCase_CheckedChanged);
            // 
            // rdbBookCase
            // 
            this.rdbBookCase.AutoSize = true;
            this.rdbBookCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbBookCase.Location = new System.Drawing.Point(7, 47);
            this.rdbBookCase.Name = "rdbBookCase";
            this.rdbBookCase.Size = new System.Drawing.Size(151, 33);
            this.rdbBookCase.TabIndex = 10;
            this.rdbBookCase.TabStop = true;
            this.rdbBookCase.Text = "BookCase";
            this.rdbBookCase.UseVisualStyleBackColor = true;
            this.rdbBookCase.CheckedChanged += new System.EventHandler(this.rdbBookCase_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(148, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 72);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbSingleTouch);
            this.groupBox4.Controls.Add(this.rdbMultiTouch);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(355, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 138);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose Screen Touch type:";
            // 
            // rdbSingleTouch
            // 
            this.rdbSingleTouch.AutoSize = true;
            this.rdbSingleTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSingleTouch.Location = new System.Drawing.Point(8, 90);
            this.rdbSingleTouch.Name = "rdbSingleTouch";
            this.rdbSingleTouch.Size = new System.Drawing.Size(179, 33);
            this.rdbSingleTouch.TabIndex = 9;
            this.rdbSingleTouch.TabStop = true;
            this.rdbSingleTouch.Text = "SingleTouch";
            this.rdbSingleTouch.UseVisualStyleBackColor = true;
            this.rdbSingleTouch.CheckedChanged += new System.EventHandler(this.rdbSingleTouch_CheckedChanged);
            // 
            // rdbMultiTouch
            // 
            this.rdbMultiTouch.AutoSize = true;
            this.rdbMultiTouch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbMultiTouch.Location = new System.Drawing.Point(8, 41);
            this.rdbMultiTouch.Name = "rdbMultiTouch";
            this.rdbMultiTouch.Size = new System.Drawing.Size(160, 33);
            this.rdbMultiTouch.TabIndex = 8;
            this.rdbMultiTouch.TabStop = true;
            this.rdbMultiTouch.Text = "MultiTouch";
            this.rdbMultiTouch.UseVisualStyleBackColor = true;
            this.rdbMultiTouch.CheckedChanged += new System.EventHandler(this.rdbMultiTouch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1177, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnApply);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mobile Phone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbIphoneHeadset;
        private System.Windows.Forms.RadioButton rdbSamsungHeadset;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdbPhoneSpeaker;
        private System.Windows.Forms.RadioButton rdbUnofficialPhoneHeadset;
        private System.Windows.Forms.RadioButton rdbPowerBank;
        private System.Windows.Forms.RadioButton rdbCharger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbBookCase;
        private System.Windows.Forms.RadioButton rdbToughCase;
        private System.Windows.Forms.RadioButton rdbSlimCase;
        private System.Windows.Forms.RadioButton rdbFolioCase;
        private System.Windows.Forms.RadioButton rdbWalletCase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbSingleTouch;
        private System.Windows.Forms.RadioButton rdbMultiTouch;
    }
}


namespace MessagesWinFormApp
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
            this.lstView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbOr = new System.Windows.Forms.RadioButton();
            this.rdbAnd = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMessages
            // 
            this.rtbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMessages.Location = new System.Drawing.Point(854, 112);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(468, 405);
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
            this.cmbSelectFormat.Location = new System.Drawing.Point(854, 64);
            this.cmbSelectFormat.Name = "cmbSelectFormat";
            this.cmbSelectFormat.Size = new System.Drawing.Size(233, 32);
            this.cmbSelectFormat.TabIndex = 2;
            this.cmbSelectFormat.SelectedValueChanged += new System.EventHandler(this.cmbSelectFormat_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(849, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format for generating messages:";
            // 
            // lstView
            // 
            this.lstView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstView.FullRowSelect = true;
            this.lstView.GridLines = true;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(12, 303);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(544, 318);
            this.lstView.TabIndex = 4;
            this.lstView.TileSize = new System.Drawing.Size(50, 44);
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Tile;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search messages by user:";
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(324, 18);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(187, 28);
            this.cmbUser.TabIndex = 6;
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbSearch.Location = new System.Drawing.Point(324, 74);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(187, 26);
            this.txtbSearch.TabIndex = 7;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTo.Location = new System.Drawing.Point(225, 176);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(215, 21);
            this.dtpTo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search messages by text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 75);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search messages-\r\nFrom date:\r\nTo date:";
            // 
            // rdbOr
            // 
            this.rdbOr.AutoSize = true;
            this.rdbOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbOr.Location = new System.Drawing.Point(13, 40);
            this.rdbOr.Name = "rdbOr";
            this.rdbOr.Size = new System.Drawing.Size(53, 24);
            this.rdbOr.TabIndex = 11;
            this.rdbOr.TabStop = true;
            this.rdbOr.Text = "OR";
            this.rdbOr.UseVisualStyleBackColor = true;
            this.rdbOr.CheckedChanged += new System.EventHandler(this.rdbOr_CheckedChanged);
            // 
            // rdbAnd
            // 
            this.rdbAnd.AutoSize = true;
            this.rdbAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbAnd.Location = new System.Drawing.Point(83, 40);
            this.rdbAnd.Name = "rdbAnd";
            this.rdbAnd.Size = new System.Drawing.Size(64, 24);
            this.rdbAnd.TabIndex = 12;
            this.rdbAnd.TabStop = true;
            this.rdbAnd.Text = "AND";
            this.rdbAnd.UseVisualStyleBackColor = true;
            this.rdbAnd.CheckedChanged += new System.EventHandler(this.rdbAnd_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdbAnd);
            this.groupBox1.Controls.Add(this.rdbOr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select filtering logic for conditions:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 41);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFrom.Location = new System.Drawing.Point(225, 151);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(215, 21);
            this.dtpFrom.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(571, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 34);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add message";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(571, 353);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(216, 34);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove message";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1334, 633);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectFormat);
            this.Controls.Add(this.rtbMessages);
            this.MaximizeBox = false;
            this.Name = "frmMessageFormatting";
            this.Text = "Message Formatting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ComboBox cmbSelectFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbOr;
        private System.Windows.Forms.RadioButton rdbAnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}


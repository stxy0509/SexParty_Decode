namespace JqpdDecode
{
    partial class Decode_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLN = new System.Windows.Forms.Label();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.makePassword = new System.Windows.Forms.Button();
            this.optionString = new System.Windows.Forms.Button();
            this.decodeRecord = new System.Windows.Forms.Button();
            this.lockCountTB = new System.Windows.Forms.TextBox();
            this.labelLockCount = new System.Windows.Forms.Label();
            this.lineNumberTB = new System.Windows.Forms.TextBox();
            this.labelMachineNum = new System.Windows.Forms.Label();
            this.labelCheckCode = new System.Windows.Forms.Label();
            this.profitTB = new System.Windows.Forms.TextBox();
            this.machineNumTB = new System.Windows.Forms.TextBox();
            this.chkCodeTB = new System.Windows.Forms.TextBox();
            this.newLnMnTB = new System.Windows.Forms.TextBox();
            this.labelOption = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLN.Location = new System.Drawing.Point(144, 24);
            this.labelLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(40, 16);
            this.labelLN.TabIndex = 2;
            this.labelLN.Text = "线号";
            // 
            // labelGameTime
            // 
            this.labelGameTime.AutoSize = true;
            this.labelGameTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGameTime.Location = new System.Drawing.Point(144, 57);
            this.labelGameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(88, 16);
            this.labelGameTime.TabIndex = 2;
            this.labelGameTime.Text = "总游戏时间";
            // 
            // makePassword
            // 
            this.makePassword.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.makePassword.ForeColor = System.Drawing.Color.Blue;
            this.makePassword.Location = new System.Drawing.Point(92, 251);
            this.makePassword.Margin = new System.Windows.Forms.Padding(4);
            this.makePassword.Name = "makePassword";
            this.makePassword.Size = new System.Drawing.Size(140, 49);
            this.makePassword.TabIndex = 4;
            this.makePassword.Text = "生成密码";
            this.makePassword.UseVisualStyleBackColor = true;
            this.makePassword.Click += new System.EventHandler(this.DoDecode_Click);
            // 
            // optionString
            // 
            this.optionString.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optionString.Location = new System.Drawing.Point(230, 182);
            this.optionString.Margin = new System.Windows.Forms.Padding(4);
            this.optionString.Name = "optionString";
            this.optionString.Size = new System.Drawing.Size(100, 57);
            this.optionString.TabIndex = 25;
            this.optionString.Text = "20小时";
            this.optionString.UseVisualStyleBackColor = true;
            this.optionString.Click += new System.EventHandler(this.DecodeOptionButton_Click);
            // 
            // decodeRecord
            // 
            this.decodeRecord.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.decodeRecord.ForeColor = System.Drawing.Color.Fuchsia;
            this.decodeRecord.Location = new System.Drawing.Point(320, 251);
            this.decodeRecord.Name = "decodeRecord";
            this.decodeRecord.Size = new System.Drawing.Size(141, 49);
            this.decodeRecord.TabIndex = 12;
            this.decodeRecord.Text = "打码记录";
            this.decodeRecord.UseVisualStyleBackColor = true;
            this.decodeRecord.Click += new System.EventHandler(this.DbViewButton_Click);
            // 
            // lockCountTB
            // 
            this.lockCountTB.Location = new System.Drawing.Point(232, 117);
            this.lockCountTB.Name = "lockCountTB";
            this.lockCountTB.Size = new System.Drawing.Size(100, 26);
            this.lockCountTB.TabIndex = 23;
            this.lockCountTB.TextChanged += new System.EventHandler(this.lockCount_TextChanged);
            // 
            // labelLockCount
            // 
            this.labelLockCount.AutoSize = true;
            this.labelLockCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLockCount.Location = new System.Drawing.Point(144, 127);
            this.labelLockCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLockCount.Name = "labelLockCount";
            this.labelLockCount.Size = new System.Drawing.Size(72, 16);
            this.labelLockCount.TabIndex = 2;
            this.labelLockCount.Text = "打码次数";
            // 
            // lineNumberTB
            // 
            this.lineNumberTB.Location = new System.Drawing.Point(232, 14);
            this.lineNumberTB.Name = "lineNumberTB";
            this.lineNumberTB.Size = new System.Drawing.Size(100, 26);
            this.lineNumberTB.TabIndex = 18;
            this.lineNumberTB.TextChanged += new System.EventHandler(this.lineNum_TextChanged);
            // 
            // labelMachineNum
            // 
            this.labelMachineNum.AutoSize = true;
            this.labelMachineNum.Location = new System.Drawing.Point(144, 89);
            this.labelMachineNum.Name = "labelMachineNum";
            this.labelMachineNum.Size = new System.Drawing.Size(72, 16);
            this.labelMachineNum.TabIndex = 19;
            this.labelMachineNum.Text = "机台号码";
            // 
            // labelCheckCode
            // 
            this.labelCheckCode.AutoSize = true;
            this.labelCheckCode.Location = new System.Drawing.Point(144, 159);
            this.labelCheckCode.Name = "labelCheckCode";
            this.labelCheckCode.Size = new System.Drawing.Size(56, 16);
            this.labelCheckCode.TabIndex = 20;
            this.labelCheckCode.Text = "校验码";
            // 
            // profitTB
            // 
            this.profitTB.Location = new System.Drawing.Point(232, 47);
            this.profitTB.Name = "profitTB";
            this.profitTB.Size = new System.Drawing.Size(100, 26);
            this.profitTB.TabIndex = 21;
            this.profitTB.TextChanged += new System.EventHandler(this.profit_TextChanged);
            // 
            // machineNumTB
            // 
            this.machineNumTB.Location = new System.Drawing.Point(232, 82);
            this.machineNumTB.Name = "machineNumTB";
            this.machineNumTB.Size = new System.Drawing.Size(100, 26);
            this.machineNumTB.TabIndex = 22;
            this.machineNumTB.TextChanged += new System.EventHandler(this.machineNum_TextChanged);
            // 
            // chkCodeTB
            // 
            this.chkCodeTB.Location = new System.Drawing.Point(232, 149);
            this.chkCodeTB.Name = "chkCodeTB";
            this.chkCodeTB.Size = new System.Drawing.Size(100, 26);
            this.chkCodeTB.TabIndex = 24;
            this.chkCodeTB.TextChanged += new System.EventHandler(this.chkCode_TextChanged);
            // 
            // newLnMnTB
            // 
            this.newLnMnTB.Enabled = false;
            this.newLnMnTB.Location = new System.Drawing.Point(337, 199);
            this.newLnMnTB.Name = "newLnMnTB";
            this.newLnMnTB.Size = new System.Drawing.Size(100, 26);
            this.newLnMnTB.TabIndex = 26;
            this.newLnMnTB.Visible = false;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Location = new System.Drawing.Point(144, 202);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(72, 16);
            this.labelOption.TabIndex = 27;
            this.labelOption.Text = "打码选项";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPassword.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(88, 307);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 29);
            this.labelPassword.TabIndex = 28;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(338, 89);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(0, 16);
            this.labelLength.TabIndex = 29;
            // 
            // Decode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.newLnMnTB);
            this.Controls.Add(this.chkCodeTB);
            this.Controls.Add(this.machineNumTB);
            this.Controls.Add(this.profitTB);
            this.Controls.Add(this.labelCheckCode);
            this.Controls.Add(this.labelMachineNum);
            this.Controls.Add(this.lineNumberTB);
            this.Controls.Add(this.lockCountTB);
            this.Controls.Add(this.decodeRecord);
            this.Controls.Add(this.optionString);
            this.Controls.Add(this.makePassword);
            this.Controls.Add(this.labelLockCount);
            this.Controls.Add(this.labelGameTime);
            this.Controls.Add(this.labelLN);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Decode_Form";
            this.Text = "激情派对打码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DecodeForm_Closed);
            this.Load += new System.EventHandler(this.DecodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Button makePassword;
        private System.Windows.Forms.Button decodeRecord;
        public System.Windows.Forms.TextBox lockCountTB;
        private System.Windows.Forms.Label labelLockCount;
        private System.Windows.Forms.Label labelMachineNum;
        private System.Windows.Forms.Label labelCheckCode;
        private System.Windows.Forms.Label labelOption;
        public System.Windows.Forms.TextBox newLnMnTB;
        public System.Windows.Forms.Button optionString;
        public System.Windows.Forms.TextBox lineNumberTB;
        public System.Windows.Forms.TextBox profitTB;
        public System.Windows.Forms.TextBox machineNumTB;
        public System.Windows.Forms.TextBox chkCodeTB;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLength;
    }
}


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
            this.type = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.lineNum = new System.Windows.Forms.Label();
            this.machineNum = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.optionString = new System.Windows.Forms.Button();
            this.ln1 = new System.Windows.Forms.Button();
            this.mn1 = new System.Windows.Forms.Button();
            this.ln2 = new System.Windows.Forms.Button();
            this.ln3 = new System.Windows.Forms.Button();
            this.mn2 = new System.Windows.Forms.Button();
            this.mn3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lockCountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profitTB = new System.Windows.Forms.TextBox();
            this.machineNumTB = new System.Windows.Forms.TextBox();
            this.chkCodeTB = new System.Windows.Forms.TextBox();
            this.optionLnMn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(21, 24);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(40, 16);
            this.type.TabIndex = 2;
            this.type.Text = "线号";
            this.type.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time.Location = new System.Drawing.Point(21, 57);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(88, 16);
            this.time.TabIndex = 2;
            this.time.Text = "总游戏时间";
            this.time.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // lineNum
            // 
            this.lineNum.AutoSize = true;
            this.lineNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineNum.Location = new System.Drawing.Point(326, 25);
            this.lineNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineNum.Name = "lineNum";
            this.lineNum.Size = new System.Drawing.Size(40, 16);
            this.lineNum.TabIndex = 2;
            this.lineNum.Text = "线号";
            this.lineNum.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // machineNum
            // 
            this.machineNum.AutoSize = true;
            this.machineNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.machineNum.Location = new System.Drawing.Point(294, 81);
            this.machineNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.machineNum.Name = "machineNum";
            this.machineNum.Size = new System.Drawing.Size(72, 16);
            this.machineNum.TabIndex = 2;
            this.machineNum.Text = "机台号码";
            this.machineNum.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.Color.Blue;
            this.save.Location = new System.Drawing.Point(24, 254);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 64);
            this.save.TabIndex = 4;
            this.save.Text = "生成密码";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.DoDecode_Click);
            // 
            // optionString
            // 
            this.optionString.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.optionString.Location = new System.Drawing.Point(107, 182);
            this.optionString.Margin = new System.Windows.Forms.Padding(4);
            this.optionString.Name = "optionString";
            this.optionString.Size = new System.Drawing.Size(100, 57);
            this.optionString.TabIndex = 7;
            this.optionString.Text = "20小时";
            this.optionString.UseVisualStyleBackColor = true;
            this.optionString.Click += new System.EventHandler(this.DecodeOptionButton_Click);
            // 
            // ln1
            // 
            this.ln1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln1.Location = new System.Drawing.Point(384, 13);
            this.ln1.Margin = new System.Windows.Forms.Padding(4);
            this.ln1.Name = "ln1";
            this.ln1.Size = new System.Drawing.Size(43, 43);
            this.ln1.TabIndex = 8;
            this.ln1.Text = "1";
            this.ln1.UseVisualStyleBackColor = true;
            this.ln1.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn1
            // 
            this.mn1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn1.Location = new System.Drawing.Point(384, 64);
            this.mn1.Margin = new System.Windows.Forms.Padding(4);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(43, 43);
            this.mn1.TabIndex = 11;
            this.mn1.Text = "1";
            this.mn1.UseVisualStyleBackColor = true;
            this.mn1.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // ln2
            // 
            this.ln2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln2.Location = new System.Drawing.Point(440, 12);
            this.ln2.Margin = new System.Windows.Forms.Padding(4);
            this.ln2.Name = "ln2";
            this.ln2.Size = new System.Drawing.Size(43, 43);
            this.ln2.TabIndex = 8;
            this.ln2.Text = "0";
            this.ln2.UseVisualStyleBackColor = true;
            this.ln2.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // ln3
            // 
            this.ln3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ln3.Location = new System.Drawing.Point(497, 12);
            this.ln3.Margin = new System.Windows.Forms.Padding(4);
            this.ln3.Name = "ln3";
            this.ln3.Size = new System.Drawing.Size(43, 43);
            this.ln3.TabIndex = 8;
            this.ln3.Text = "0";
            this.ln3.UseVisualStyleBackColor = true;
            this.ln3.Click += new System.EventHandler(this.LineNumButton_Click);
            // 
            // mn2
            // 
            this.mn2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn2.Location = new System.Drawing.Point(440, 64);
            this.mn2.Margin = new System.Windows.Forms.Padding(4);
            this.mn2.Name = "mn2";
            this.mn2.Size = new System.Drawing.Size(43, 43);
            this.mn2.TabIndex = 11;
            this.mn2.Text = "2";
            this.mn2.UseVisualStyleBackColor = true;
            this.mn2.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // mn3
            // 
            this.mn3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mn3.Location = new System.Drawing.Point(497, 64);
            this.mn3.Margin = new System.Windows.Forms.Padding(4);
            this.mn3.Name = "mn3";
            this.mn3.Size = new System.Drawing.Size(43, 43);
            this.mn3.TabIndex = 11;
            this.mn3.Text = " 3";
            this.mn3.UseVisualStyleBackColor = true;
            this.mn3.Click += new System.EventHandler(this.MachineNumButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "打码记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DbViewButton_Click);
            // 
            // lockCountTB
            // 
            this.lockCountTB.Location = new System.Drawing.Point(107, 117);
            this.lockCountTB.Name = "lockCountTB";
            this.lockCountTB.Size = new System.Drawing.Size(100, 26);
            this.lockCountTB.TabIndex = 14;
            this.lockCountTB.TextChanged += new System.EventHandler(this.lockCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "打码次数";
            this.label1.Click += new System.EventHandler(this.AllLabels_Click);
            // 
            // lineNumberTB
            // 
            this.lineNumberTB.Location = new System.Drawing.Point(107, 14);
            this.lineNumberTB.Name = "lineNumberTB";
            this.lineNumberTB.Size = new System.Drawing.Size(100, 26);
            this.lineNumberTB.TabIndex = 18;
            this.lineNumberTB.TextChanged += new System.EventHandler(this.lineNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "机台号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "校验码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // profitTB
            // 
            this.profitTB.Location = new System.Drawing.Point(107, 47);
            this.profitTB.Name = "profitTB";
            this.profitTB.Size = new System.Drawing.Size(100, 26);
            this.profitTB.TabIndex = 21;
            this.profitTB.TextChanged += new System.EventHandler(this.profit_TextChanged);
            // 
            // machineNumTB
            // 
            this.machineNumTB.Location = new System.Drawing.Point(107, 82);
            this.machineNumTB.Name = "machineNumTB";
            this.machineNumTB.Size = new System.Drawing.Size(100, 26);
            this.machineNumTB.TabIndex = 22;
            this.machineNumTB.TextChanged += new System.EventHandler(this.machineNum_TextChanged);
            // 
            // chkCodeTB
            // 
            this.chkCodeTB.Location = new System.Drawing.Point(107, 149);
            this.chkCodeTB.Name = "chkCodeTB";
            this.chkCodeTB.Size = new System.Drawing.Size(100, 26);
            this.chkCodeTB.TabIndex = 23;
            this.chkCodeTB.TextChanged += new System.EventHandler(this.chkCode_TextChanged);
            // 
            // optionLnMn
            // 
            this.optionLnMn.Enabled = false;
            this.optionLnMn.Location = new System.Drawing.Point(214, 199);
            this.optionLnMn.Name = "optionLnMn";
            this.optionLnMn.Size = new System.Drawing.Size(100, 26);
            this.optionLnMn.TabIndex = 26;
            this.optionLnMn.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "打码选项";
            // 
            // Decode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optionLnMn);
            this.Controls.Add(this.chkCodeTB);
            this.Controls.Add(this.machineNumTB);
            this.Controls.Add(this.profitTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineNumberTB);
            this.Controls.Add(this.lockCountTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mn2);
            this.Controls.Add(this.mn3);
            this.Controls.Add(this.mn1);
            this.Controls.Add(this.ln3);
            this.Controls.Add(this.ln2);
            this.Controls.Add(this.ln1);
            this.Controls.Add(this.optionString);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machineNum);
            this.Controls.Add(this.lineNum);
            this.Controls.Add(this.time);
            this.Controls.Add(this.type);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Decode_Form";
            this.Text = "激情派对打码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TxForm_Closed);
            this.Load += new System.EventHandler(this.TxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label lineNum;
        private System.Windows.Forms.Label machineNum;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button ln1;
        private System.Windows.Forms.Button mn1;
        private System.Windows.Forms.Button ln2;
        private System.Windows.Forms.Button ln3;
        private System.Windows.Forms.Button mn2;
        private System.Windows.Forms.Button mn3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox lockCountTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox optionLnMn;
        public System.Windows.Forms.Button optionString;
        public System.Windows.Forms.TextBox lineNumberTB;
        public System.Windows.Forms.TextBox profitTB;
        public System.Windows.Forms.TextBox machineNumTB;
        public System.Windows.Forms.TextBox chkCodeTB;
    }
}


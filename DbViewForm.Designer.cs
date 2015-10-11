namespace JqpdDecode
{
    partial class DbViewForm
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
            if(disposing && (components != null))
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
            this.dataTable = new System.Windows.Forms.ListView();
            this.clearRecord = new System.Windows.Forms.Button();
            this.prevPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.firstPage = new System.Windows.Forms.Button();
            this.lastPage = new System.Windows.Forms.Button();
            this.totalTimeButton = new System.Windows.Forms.Button();
            this.pageTimeButton = new System.Windows.Forms.Button();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.pageTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataTable.Location = new System.Drawing.Point(5, 73);
            this.dataTable.Margin = new System.Windows.Forms.Padding(5);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(705, 518);
            this.dataTable.TabIndex = 0;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            // 
            // clearRecord
            // 
            this.clearRecord.ForeColor = System.Drawing.Color.Red;
            this.clearRecord.Location = new System.Drawing.Point(17, 2);
            this.clearRecord.Name = "clearRecord";
            this.clearRecord.Size = new System.Drawing.Size(100, 30);
            this.clearRecord.TabIndex = 1;
            this.clearRecord.Text = "清除记录";
            this.clearRecord.UseVisualStyleBackColor = true;
            this.clearRecord.Click += new System.EventHandler(this.clear_Click);
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(408, 2);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(84, 30);
            this.prevPage.TabIndex = 4;
            this.prevPage.Text = "上一页";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(505, 3);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(81, 29);
            this.nextPage.TabIndex = 5;
            this.nextPage.Text = "下一页";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // firstPage
            // 
            this.firstPage.Location = new System.Drawing.Point(151, 2);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(78, 30);
            this.firstPage.TabIndex = 2;
            this.firstPage.Text = "第一页";
            this.firstPage.UseVisualStyleBackColor = true;
            this.firstPage.Click += new System.EventHandler(this.firstPage_Click);
            // 
            // lastPage
            // 
            this.lastPage.Location = new System.Drawing.Point(249, 2);
            this.lastPage.Name = "lastPage";
            this.lastPage.Size = new System.Drawing.Size(97, 30);
            this.lastPage.TabIndex = 3;
            this.lastPage.Text = "最后一页";
            this.lastPage.UseVisualStyleBackColor = true;
            this.lastPage.Click += new System.EventHandler(this.lastPage_Click);
            // 
            // totalTimeButton
            // 
            this.totalTimeButton.Location = new System.Drawing.Point(17, 38);
            this.totalTimeButton.Name = "totalTimeButton";
            this.totalTimeButton.Size = new System.Drawing.Size(120, 27);
            this.totalTimeButton.TabIndex = 6;
            this.totalTimeButton.Text = "总打码时间";
            this.totalTimeButton.UseVisualStyleBackColor = true;
            // 
            // pageTimeButton
            // 
            this.pageTimeButton.Location = new System.Drawing.Point(299, 38);
            this.pageTimeButton.Name = "pageTimeButton";
            this.pageTimeButton.Size = new System.Drawing.Size(137, 27);
            this.pageTimeButton.TabIndex = 8;
            this.pageTimeButton.Text = "本页打码时间";
            this.pageTimeButton.UseVisualStyleBackColor = true;
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.ForeColor = System.Drawing.Color.Blue;
            this.totalTimeLabel.Location = new System.Drawing.Point(147, 41);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.totalTimeLabel.TabIndex = 7;
            // 
            // pageTimeLabel
            // 
            this.pageTimeLabel.AutoSize = true;
            this.pageTimeLabel.ForeColor = System.Drawing.Color.Green;
            this.pageTimeLabel.Location = new System.Drawing.Point(442, 41);
            this.pageTimeLabel.Name = "pageTimeLabel";
            this.pageTimeLabel.Size = new System.Drawing.Size(0, 20);
            this.pageTimeLabel.TabIndex = 9;
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 464);
            this.Controls.Add(this.pageTimeLabel);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.pageTimeButton);
            this.Controls.Add(this.totalTimeButton);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.lastPage);
            this.Controls.Add(this.firstPage);
            this.Controls.Add(this.prevPage);
            this.Controls.Add(this.clearRecord);
            this.Controls.Add(this.dataTable);
            this.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DbViewForm";
            this.Text = "打码记录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataTable;
        private System.Windows.Forms.Button clearRecord;
        private System.Windows.Forms.Button prevPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button firstPage;
        private System.Windows.Forms.Button lastPage;
        private System.Windows.Forms.Button totalTimeButton;
        private System.Windows.Forms.Button pageTimeButton;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.Label pageTimeLabel;
    }
}
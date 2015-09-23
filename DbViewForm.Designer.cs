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
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataTable.Location = new System.Drawing.Point(5, 64);
            this.dataTable.Margin = new System.Windows.Forms.Padding(5);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(609, 527);
            this.dataTable.TabIndex = 0;
            this.dataTable.UseCompatibleStateImageBehavior = false;
            // 
            // clearRecord
            // 
            this.clearRecord.Location = new System.Drawing.Point(17, 11);
            this.clearRecord.Name = "clearRecord";
            this.clearRecord.Size = new System.Drawing.Size(104, 43);
            this.clearRecord.TabIndex = 1;
            this.clearRecord.Text = "清除记录";
            this.clearRecord.UseVisualStyleBackColor = true;
            this.clearRecord.Click += new System.EventHandler(this.clear_Click);
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(408, 11);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(84, 44);
            this.prevPage.TabIndex = 2;
            this.prevPage.Text = "上一页";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(505, 12);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(81, 43);
            this.nextPage.TabIndex = 3;
            this.nextPage.Text = "下一页";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // firstPage
            // 
            this.firstPage.Location = new System.Drawing.Point(151, 11);
            this.firstPage.Name = "firstPage";
            this.firstPage.Size = new System.Drawing.Size(84, 44);
            this.firstPage.TabIndex = 2;
            this.firstPage.Text = "第一页";
            this.firstPage.UseVisualStyleBackColor = true;
            this.firstPage.Click += new System.EventHandler(this.firstPage_Click);
            // 
            // lastPage
            // 
            this.lastPage.Location = new System.Drawing.Point(249, 11);
            this.lastPage.Name = "lastPage";
            this.lastPage.Size = new System.Drawing.Size(97, 44);
            this.lastPage.TabIndex = 2;
            this.lastPage.Text = "最后一页";
            this.lastPage.UseVisualStyleBackColor = true;
            this.lastPage.Click += new System.EventHandler(this.lastPage_Click);
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 464);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.lastPage);
            this.Controls.Add(this.firstPage);
            this.Controls.Add(this.prevPage);
            this.Controls.Add(this.clearRecord);
            this.Controls.Add(this.dataTable);
            this.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DbViewForm";
            this.Text = "打码记录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataTable;
        private System.Windows.Forms.Button clearRecord;
        private System.Windows.Forms.Button prevPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button firstPage;
        private System.Windows.Forms.Button lastPage;
    }
}
namespace vocabulary
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openbutton = new System.Windows.Forms.Button();
            this.dictionOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.problemText = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(12, 12);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(75, 23);
            this.openbutton.TabIndex = 0;
            this.openbutton.Text = "Open File...";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // dictionOpenFileDialog
            // 
            this.dictionOpenFileDialog.FileName = "openFileDialog1";
            this.dictionOpenFileDialog.Title = "開啟字彙列表";
            this.dictionOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.dictionOpenFileDialog_FileOk);
            // 
            // problemText
            // 
            this.problemText.Enabled = false;
            this.problemText.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.problemText.Location = new System.Drawing.Point(12, 38);
            this.problemText.Name = "problemText";
            this.problemText.Size = new System.Drawing.Size(345, 38);
            this.problemText.TabIndex = 1;
            this.problemText.Text = "題目";
            this.problemText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbutton
            // 
            this.startbutton.Enabled = false;
            this.startbutton.Location = new System.Drawing.Point(93, 12);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Enabled = false;
            this.stopbutton.Location = new System.Drawing.Point(174, 12);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 3;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // option1
            // 
            this.option1.Enabled = false;
            this.option1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.option1.Location = new System.Drawing.Point(12, 79);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(345, 41);
            this.option1.TabIndex = 4;
            this.option1.Text = "選項1";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // option2
            // 
            this.option2.Enabled = false;
            this.option2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.option2.Location = new System.Drawing.Point(12, 126);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(345, 41);
            this.option2.TabIndex = 4;
            this.option2.Text = "選項2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Enabled = false;
            this.option3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.option3.Location = new System.Drawing.Point(12, 173);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(345, 41);
            this.option3.TabIndex = 4;
            this.option3.Text = "選項3";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // option4
            // 
            this.option4.Enabled = false;
            this.option4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.option4.Location = new System.Drawing.Point(12, 220);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(345, 41);
            this.option4.TabIndex = 4;
            this.option4.Text = "選項4";
            this.option4.UseVisualStyleBackColor = true;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusLabel.Location = new System.Drawing.Point(257, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 23);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 274);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.problemText);
            this.Controls.Add(this.openbutton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "單字測驗程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.OpenFileDialog dictionOpenFileDialog;
        private System.Windows.Forms.Label problemText;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Label statusLabel;
    }
}


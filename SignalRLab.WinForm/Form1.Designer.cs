namespace SignalRLab.WinForm
{
    partial class Form1
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
            this.lbText = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnStop = new System.Windows.Forms.Button();
            this.btnConnStart = new System.Windows.Forms.Button();
            this.tbTextArea = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(0, 70);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 15);
            this.lbText.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(248, 90);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 29);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnStop
            // 
            this.btnConnStop.Location = new System.Drawing.Point(13, 143);
            this.btnConnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnStop.Name = "btnConnStop";
            this.btnConnStop.Size = new System.Drawing.Size(180, 48);
            this.btnConnStop.TabIndex = 10;
            this.btnConnStop.Text = "connection stop";
            this.btnConnStop.UseVisualStyleBackColor = true;
            this.btnConnStop.Click += new System.EventHandler(this.btnConnStop_Click);
            // 
            // btnConnStart
            // 
            this.btnConnStart.Location = new System.Drawing.Point(13, 13);
            this.btnConnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnStart.Name = "btnConnStart";
            this.btnConnStart.Size = new System.Drawing.Size(180, 48);
            this.btnConnStart.TabIndex = 9;
            this.btnConnStart.Text = "connection start";
            this.btnConnStart.UseVisualStyleBackColor = true;
            this.btnConnStart.Click += new System.EventHandler(this.btnConnStart_Click);
            // 
            // tbTextArea
            // 
            this.tbTextArea.Location = new System.Drawing.Point(13, 90);
            this.tbTextArea.Margin = new System.Windows.Forms.Padding(4);
            this.tbTextArea.Name = "tbTextArea";
            this.tbTextArea.Size = new System.Drawing.Size(227, 25);
            this.tbTextArea.TabIndex = 8;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(13, 198);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(662, 242);
            this.txtReceive.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 452);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnStop);
            this.Controls.Add(this.btnConnStart);
            this.Controls.Add(this.tbTextArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnStop;
        private System.Windows.Forms.Button btnConnStart;
        private System.Windows.Forms.TextBox tbTextArea;
        private System.Windows.Forms.TextBox txtReceive;

    }
}


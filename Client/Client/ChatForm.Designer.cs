namespace Client
{
    partial class ChatForm
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
            this.ricTexReceive = new System.Windows.Forms.RichTextBox();
            this.ricTexSend = new System.Windows.Forms.RichTextBox();
            this.labChatNum = new System.Windows.Forms.Label();
            this.buttonChatSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ricTexReceive
            // 
            this.ricTexReceive.Location = new System.Drawing.Point(12, 12);
            this.ricTexReceive.Name = "ricTexReceive";
            this.ricTexReceive.ReadOnly = true;
            this.ricTexReceive.Size = new System.Drawing.Size(397, 263);
            this.ricTexReceive.TabIndex = 0;
            this.ricTexReceive.Text = "";
            // 
            // ricTexSend
            // 
            this.ricTexSend.Location = new System.Drawing.Point(12, 290);
            this.ricTexSend.Name = "ricTexSend";
            this.ricTexSend.Size = new System.Drawing.Size(397, 114);
            this.ricTexSend.TabIndex = 1;
            this.ricTexSend.Text = "";
            // 
            // labChatNum
            // 
            this.labChatNum.AutoSize = true;
            this.labChatNum.Location = new System.Drawing.Point(415, 31);
            this.labChatNum.Name = "labChatNum";
            this.labChatNum.Size = new System.Drawing.Size(29, 12);
            this.labChatNum.TabIndex = 2;
            this.labChatNum.Text = "chat";
            // 
            // buttonChatSend
            // 
            this.buttonChatSend.Location = new System.Drawing.Point(417, 357);
            this.buttonChatSend.Name = "buttonChatSend";
            this.buttonChatSend.Size = new System.Drawing.Size(75, 23);
            this.buttonChatSend.TabIndex = 3;
            this.buttonChatSend.Text = "发送";
            this.buttonChatSend.UseVisualStyleBackColor = true;
            this.buttonChatSend.Click += new System.EventHandler(this.buttonChatSend_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 429);
            this.Controls.Add(this.buttonChatSend);
            this.Controls.Add(this.labChatNum);
            this.Controls.Add(this.ricTexSend);
            this.Controls.Add(this.ricTexReceive);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox ricTexReceive;
        private System.Windows.Forms.RichTextBox ricTexSend;
        public System.Windows.Forms.Label labChatNum;
        private System.Windows.Forms.Button buttonChatSend;
    }
}
namespace Client
{
    partial class ListFrom
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labAdr = new System.Windows.Forms.Label();
            this.buttonChat = new System.Windows.Forms.Button();
            this.listOnl = new System.Windows.Forms.ListBox();
            this.richlist = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(96, 488);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "查找在线";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 9);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name ：";
            // 
            // labAdr
            // 
            this.labAdr.AutoSize = true;
            this.labAdr.Location = new System.Drawing.Point(12, 31);
            this.labAdr.Name = "labAdr";
            this.labAdr.Size = new System.Drawing.Size(47, 12);
            this.labAdr.TabIndex = 2;
            this.labAdr.Text = "IP   ：";
            // 
            // buttonChat
            // 
            this.buttonChat.Location = new System.Drawing.Point(12, 488);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(75, 23);
            this.buttonChat.TabIndex = 3;
            this.buttonChat.Text = "聊天";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // listOnl
            // 
            this.listOnl.FormattingEnabled = true;
            this.listOnl.ItemHeight = 12;
            this.listOnl.Location = new System.Drawing.Point(12, 59);
            this.listOnl.Name = "listOnl";
            this.listOnl.Size = new System.Drawing.Size(164, 412);
            this.listOnl.TabIndex = 4;
            // 
            // richlist
            // 
            this.richlist.Location = new System.Drawing.Point(228, 59);
            this.richlist.Name = "richlist";
            this.richlist.ReadOnly = true;
            this.richlist.Size = new System.Drawing.Size(235, 387);
            this.richlist.TabIndex = 5;
            this.richlist.Text = "";
            // 
            // ListFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 523);
            this.Controls.Add(this.richlist);
            this.Controls.Add(this.listOnl);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.labAdr);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.buttonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListFrom";
            this.Text = "ListFrom";
            this.Load += new System.EventHandler(this.ListFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAdr;
        private System.Windows.Forms.Button buttonChat;
        public System.Windows.Forms.ListBox listOnl;
        public System.Windows.Forms.RichTextBox richlist;
    }
}
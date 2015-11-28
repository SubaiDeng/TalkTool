using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        public Chat chat = new Chat();
        public int aimNum;
        public string SendBuff;
        public ListFrom fatherWind;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            chat.startIP.ChatConnect(chat.aim);
            chat.startIP.chatForm = this;
            labAimAdr.Text = chat.aim;
            labMyAdr.Text = chat.startIP.name;
        }

        private void buttonChatSend_Click(object sender, EventArgs e)
        {
            string front = chat.startIP.name + "\t"+ DateTime.Now.ToShortTimeString()+"\n";
            SendBuff = ricTexSend.Text;
            SendBuff = front + SendBuff + "\n";
            ricTexSend.Clear();
            ricTexReceive.Text += SendBuff;
            chat.startIP.SendChat(SendBuff,this);
        }
    }
}

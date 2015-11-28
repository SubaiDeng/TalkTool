using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Client
{
    public partial class ListFrom : Form
    {

        public List<ChatForm> chatList; 
        public SocketTcp client;
        public ListFrom()
        {
            InitializeComponent();            
        }

        private void ListFrom_Load(object sender, EventArgs e)
        {
            labName.Text += client.name;
            labAdr.Text += client.adr;
            client.SendName();
            Thread ListenThread = new Thread(new ThreadStart(client.Receive));
            ListenThread.Start();
            chatList = new List<ChatForm>();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OnlineList onlineList = new OnlineList();
            onlineList.fatherWind = this;
            onlineList.Show();
            client.SendSerch();
            client.fatherWind = onlineList;
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            string aim = listOnl.SelectedItem.ToString();
            ChatForm chatForm = new ChatForm();
            chatForm.fatherWind = this;
            client.listFrom = this;
            chatList.Add(chatForm);
            chatForm.chat.startIP = client;
            chatForm.chat.aim = aim;
            chatForm.Show();
        }
    }
}

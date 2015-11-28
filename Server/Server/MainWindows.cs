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

namespace Server
{
    public partial class MainWindows : Form
    {
        public SocketTcp server;
        public List<Client> ClientList;
        public MainWindows()
        {
            InitializeComponent();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            //跨线程调用Windows控件。
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread countClientThread = new Thread(new ThreadStart(this.Wait));
            ClientList = new List<Client>();
            countClientThread.Start();
            labAdr.Text = "IP: "+server.adr;
        }

        void Wait()
        {
            while(true)
            {
                int n = server.connections;
                ClientList.Add(new Client(server.server.AcceptTcpClient(),this));
                Thread newThread = new Thread(new ThreadStart(ClientList[n].Receive));
                newThread.Start();
                server.connections++;
            }
        }

        public void AddClientList(string str)
        {
            listBoxClient.Items.Add(str);
        }
    }
}

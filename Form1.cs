using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;

namespace SelectNCProgramSample
{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int OPC_DS_CACHE = 1;
        public const int OPC_DS_DEVICE = 2;

        public OPCServer c_opcServer;
        public OPCGroups c_opcGropus;
        public OPCGroup c_opcGroup;

        public long c_hServerGroup;
        public OPCItems c_opcItems;
        public OPCItem [] c_opcItem = new OPCItem[4];
        public long [] c_hServerItem = new long[4];
        
        public string c_sServerName;
        public string c_sClientName;
        public string c_sServerNode;

        public bool c_bIsConnected;

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if(c_opcServer == null) 
            {
                c_opcServer = new OPCAutomation.OPCServer(); 
            }

            if(c_bIsConnected == false) 
            {
                c_sServerNode = txtClientName.Text;
                c_sServerName = txtServerName.Text;
                c_opcServer.Connect(c_sServerName, c_sServerNode);

                c_sServerName = txtClientName.Text;
                c_opcServer.ClientName = c_sServerName;

                c_bIsConnected = true;
                ServerShape.BackColor = Color.Green;
                txtServerName.ReadOnly = true;
                txtClientName.ReadOnly = true;
                txtNodeName.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No connection to OPCServer:" + txtServerName.Text);
            }
            cmdCreateGropu_Click(sender, e);
            cmdCreateItem_Click(sender, e);

            cmdChangeMode_Click(sender, e);
            cmdChangeProgram_Click(sender, e);

        }

        private void cmdCreateGropu_Click(object sender, EventArgs e)
        {
            if(c_bIsConnected == false)
            {
                MessageBox.Show("无连接" );
                return;
            }
            try
            {
                c_opcGropus = c_opcServer.OPCGroups;
                c_opcGroup = c_opcGropus.Add("程序更改");
                c_hServerGroup = c_opcGroup.ServerHandle;
                return;
            }
            catch
            {
                MessageBox.Show("错误：creating Group");
            }
        }

        private void cmdCreateItem_Click(object sender, EventArgs e)
        {
            if(c_hServerGroup == 0)
            {
                MessageBox.Show("Keine Gruppe angelegt");
                return;
            }

            try
            {
                c_opcItems = c_opcGroup.OPCItems;

                c_opcItem[1] = c_opcItems.AddItem("IndraMotion_MTX_performance,NC.Chan.Cmd.ModeOfOperation,1", 1);
                c_hServerItem[1] = c_opcItem[1].ServerHandle;

                c_opcItem[2] = c_opcItems.AddItem("IndraMotion_MTX_performance,NC.Chan.Cmd.SelectProgram,1", 2);
                c_hServerItem[2] = c_opcItem[2].ServerHandle;

                c_opcItem[3] = c_opcItems.AddItem("IndraMotion_MTX_performance, NC.Chan.ActMainProgram, 1", 3);
                c_hServerItem[3] = c_opcItem[3].ServerHandle;

                c_opcItem[4] = c_opcItems.AddItem("IndraMotion_MTX_performance,NC.Chan.ModeOfOperation,1", 4);
                c_hServerItem[4] = c_opcItem[4].ServerHandle;
                return;
            }   

            catch
            {
                MessageBox.Show("错误：creating Item");
            }
        }
        

            private void cmdCurrentMode_Click(object sender, EventArgs e)
        {

        }

        private void cmdChangeMode_Click(object sender, EventArgs e)
        {

        }

        private void cmdCurrentProgram_Click(object sender, EventArgs e)
        {

        }

        private void cmdChangeProgram_Click(object sender, EventArgs e)
        {

        }
    }
}

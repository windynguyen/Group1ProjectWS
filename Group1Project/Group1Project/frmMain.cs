using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Group1Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        private ServiceHost host;
        public void StartService()
        {
            Uri baseAddress = new Uri("http://localhost:8001/MarkManagementService");
            Type contractType = typeof(IService);
            Type instanceType = typeof(OperationService);
            host = new ServiceHost(instanceType, baseAddress);
            
               
            // Create basicHttpBinding endpoint at http://localhost:8001/OperationService
                string relativeAddress = "OperationService";
                host.AddServiceEndpoint(contractType, new BasicHttpBinding(), relativeAddress);

                NetTcpBinding A = new NetTcpBinding(SecurityMode.Transport);
                host.AddServiceEndpoint(contractType, new NetTcpBinding(), "net.tcp://localhost:9000/MarkManagementService");
                host.AddServiceEndpoint(contractType, A, "net.tcp://localhost:9001/MarkManagementService");
                // Add behavior for our MEX endpoint
                //Add Mex endpoint can dung de khi client discovery thay duoc service

                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                behavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(behavior);

                // Add MEX endpoint at http://localhost:8000/MEX/
                host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX");
                host.Open();
                lbl_mess.Text = "Service is starting";
                lbl_mess.ForeColor = Color.Green;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            host.Close();
            lbl_mess.Text = "Service closed";
            lbl_mess.ForeColor = Color.Red;
        }
    }
}

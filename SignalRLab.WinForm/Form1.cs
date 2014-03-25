using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using SignalRLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRLab.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conn = new HubConnection("http://localhost:12119/");
            myHub = conn.CreateHubProxy("myHub");
            conn.Received += ConnReceived;
            conn.Closed += ConnClosed;

        }
        private HubConnection conn;
        private IHubProxy myHub;
        private void doUiCallBack(uiCallBack cb)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new uiCallBack(
                    () =>
                    {
                        cb.Invoke();
                    }
                ));
            }
        }

        private delegate void uiCallBack();
        private void ConnClosed()
        {
            MessageBox.Show("connection stop !!!");
            doUiCallBack(
                () =>
                {
                    lbText.Text = "";
                }
            );
        }

        private void ConnReceived(string obj)
        {
            dynamic json = JsonConvert.DeserializeObject(obj);//接收Server的訊息會是一個json包裝後的類別
            if (json.M == "sendMessage")//M為收到的方法名稱
            {
                object resultObj = json.A;//A為回傳的結果
                var p = JsonConvert.DeserializeObject<List<Product>>(resultObj.ToString());//WinApp回傳的資料就算是單筆也會回傳陣列
                doUiCallBack(
                    () =>
                    {
                        txtReceive.Text += p[0].Name + ":" + p[0].Category + Environment.NewLine;
                    }
                );
            }
        }

        private void btnConnStart_Click(object sender, EventArgs e)
        {
            conn.Start().ContinueWith(
task =>
{
    if (!task.IsFaulted)
    {
        myHub.Invoke("send", "Kim", "hello");
        MessageBox.Show("connection start !!!");
    }
}
);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            myHub.Invoke("send", "Kim", "from winFrom:" + DateTime.Now.ToString());
        }

        private void btnConnStop_Click(object sender, EventArgs e)
        {
            lbText.Text = "關閉中請稍後。";
            conn.Stop();
        }




    }

}

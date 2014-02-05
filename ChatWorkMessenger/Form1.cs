using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using ChatWorkMessenger.ChatWorkApi;
using ChatWorkMessenger.ChatWorkApi.Core;
using ChatWorkMessenger.ChatWorkApi.Models;

namespace ChatWorkMessenger
{
    public partial class Form1 : Form
    {
        private ChatWorkCredential _chatworkCredential;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _chatworkCredential = new ChatWorkCredential();

            var serializer2 = new XmlSerializer(typeof(ChatWorkCredential));
            var fs2 = new FileStream("chatwork_credential.xml", FileMode.Open);
            _chatworkCredential = (ChatWorkCredential)serializer2.Deserialize(fs2);
            fs2.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var chatwork = new ChatWork(_chatworkCredential);
            var responseMessage = chatwork.SendMessage(9999999, messageTextBox.Text);

            MessageBox.Show(responseMessage);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chatwork = new ChatWork(_chatworkCredential);
            var roomList = chatwork.GetRoomList();
            var rm = roomList[0];

            MessageBox.Show(rm.Name);

        }

    }
}

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
        private ChatWork _chatwork;

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
            // Load ChatWork Credential
            _chatworkCredential = new ChatWorkCredential();
            var serializer2 = new XmlSerializer(typeof(ChatWorkCredential));
            var fs2 = new FileStream("chatwork_credential.xml", FileMode.Open);
            _chatworkCredential = (ChatWorkCredential)serializer2.Deserialize(fs2);
            fs2.Close();

            // Get ChatWork API Wrapper Instance
            _chatwork = new ChatWork(_chatworkCredential);

            // Get Room List
            var roomList = _chatwork.GetRoomList();

            roomComboBox.DataSource = roomList;
            roomComboBox.DisplayMember = "Name";
            roomComboBox.ValueMember = "room_id";

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var roomId = (long)roomComboBox.SelectedValue;
            var responseMessage = _chatwork.SendMessage(roomId, messageTextBox.Text);

            MessageBox.Show(responseMessage);

        }

    }
}

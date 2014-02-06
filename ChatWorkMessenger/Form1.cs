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

            var roomId = (long)roomComboBox.SelectedValue;
            var memberList = _chatwork.GetMemberList(roomId);

            memberListBox.DataSource = memberList;
            memberListBox.DisplayMember = "name";
            memberListBox.ValueMember = "account_id";
            memberListBox.SelectedItems.Clear();

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var roomId = (long)roomComboBox.SelectedValue;

            var message = messageTextBox.Text;

            var toString = string.Empty;
            var selectedMemberList = memberListBox.SelectedItems;
            foreach (var item in selectedMemberList)
            {
                var member = (Member)item;
                toString += string.Format("[To:{0}] {1} さん\n", member.account_id, member.name);
            }

            message = toString + message;

            var responseMessage = _chatwork.SendMessage(roomId, message);

            MessageBox.Show(responseMessage);

        }

        private void clearMessageButton_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = string.Empty;
        }

        private void selectAllMemberButton_Click(object sender, EventArgs e)
        {
            var allMemberCount = memberListBox.Items.Count;
            for (var i = 0; i < allMemberCount; i++)
            {
                memberListBox.SetSelected(i, true);
            }
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            memberListBox.SelectedItems.Clear();
        }

        private void roomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = roomComboBox.SelectedValue;
            if (selectedValue == null || !(selectedValue is long))
            {
                return;
            }
            var roomId = (long)selectedValue;
            var memberList = _chatwork.GetMemberList(roomId);

            memberListBox.DataSource = memberList;
            memberListBox.DisplayMember = "name";
            memberListBox.ValueMember = "account_id";
            memberListBox.SelectedItems.Clear();

        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

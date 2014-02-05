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

            // 各種設定値
            var apiKey = _chatworkCredential.ApiKey;

            // 文字コードを指定する
            var enc = Encoding.GetEncoding("UTF-8");

            // パラメタのエンコード・構築
            var postData = "body=" + HttpUtility.UrlEncode(messageTextBox.Text, enc);
            var postDataBytes = Encoding.ASCII.GetBytes(postData);

            // WebRequest作成
            var requestUrl = string.Format("https://api.chatwork.com/v1/rooms");
            var req = WebRequest.Create(requestUrl);
            req.Method = "GET";
            req.ContentType = "application/x-www-form-urlencoded";
            // POSTデータ長を指定
//            req.ContentLength = postDataBytes.Length;
            req.Headers.Add(string.Format("X-ChatWorkToken: {0}", apiKey));

            // データをPOST送信するためのStreamを取得
            
//            var reqStream = req.GetRequestStream();
            // 送信するデータを書き込む
//            reqStream.Write(postDataBytes, 0, postDataBytes.Length);
//            reqStream.Close();

            // サーバーからの応答を受信する
            var res = req.GetResponse();
            // 応答データを受信するためのStreamを取得
            var resStream = res.GetResponseStream();
            // 受信して表示
            var sr = new StreamReader(resStream, enc);

            // 結果受信
            var responseMessage = sr.ReadToEnd();

            sr.Close();

            var serializer = new JavaScriptSerializer();
            var roomList = (List<Room>)serializer.Deserialize(responseMessage, typeof(List<Room>));
            var rm = roomList[0];

            MessageBox.Show(rm.Name);

        }

    }
}

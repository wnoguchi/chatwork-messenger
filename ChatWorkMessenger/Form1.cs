using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace ChatWorkMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            // 各種設定値
            const string apiKey = "9999999999999999999999999999";
            // グループチャットを指定
            const string roomId = "9999999";

            //文字コードを指定する
            var enc = Encoding.GetEncoding("UTF-8");

            // パラメタのエンコード・構築
            var postData = "body=" + HttpUtility.UrlEncode(messageTextBox.Text, enc);
            var postDataBytes = System.Text.Encoding.ASCII.GetBytes(postData);

            // WebRequest作成
            var requestUrl = string.Format("https://api.chatwork.com/v1/rooms/{0}/messages", roomId);
            var req = WebRequest.Create(requestUrl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            // POSTデータ長を指定
            req.ContentLength = postDataBytes.Length;
            req.Headers.Add(string.Format("X-ChatWorkToken: {0}", apiKey));

            // データをPOST送信するためのStreamを取得
            var reqStream = req.GetRequestStream();
            // 送信するデータを書き込む
            reqStream.Write(postDataBytes, 0, postDataBytes.Length);
            reqStream.Close();

            // サーバーからの応答を受信する
            var res = req.GetResponse();
            // 応答データを受信するためのStreamを取得
            var resStream = res.GetResponseStream();
            // 受信して表示
            var sr = new StreamReader(resStream, enc);

            // 結果受信
            var responseMessage = sr.ReadToEnd();
            
            sr.Close();

            MessageBox.Show(responseMessage);

        }
    }
}

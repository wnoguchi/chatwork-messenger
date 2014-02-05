using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ChatWorkMessenger.ChatWorkApi.Core
{
    class ChatWorkRequest
    {
        private WebRequest _request;
        private Encoding _encoding;
        private ChatWorkCredential _credential;

        private const string CHATWORK_ENDPOINT_BASE_URL = "https://api.chatwork.com";
        private const string API_V1 = "/v1";

        public ChatWorkRequest(ChatWorkCredential credential)
        {
            _credential = credential;
            _encoding = Encoding.GetEncoding("UTF-8");
        }

        public string Get(string apiCallPath)
        {
            // Create WebRequest
            var requestUrl = string.Format(GetEndpointUrlBase() + apiCallPath);
            var req = WebRequest.Create(requestUrl);

            // Specify Method: GET
            req.Method = "GET";
            req.ContentType = "application/x-www-form-urlencoded";

            // Set ChatWork API Key
            req.Headers.Add(string.Format("X-ChatWorkToken: {0}", _credential.ApiKey));

            // Get Reseponse object from server
            var res = req.GetResponse();
            // Get Response stream
            var resStream = res.GetResponseStream();
            // receive data
            var sr = new StreamReader(resStream, _encoding);

            var resultJson = sr.ReadToEnd();

            sr.Close();

            return resultJson;

        }

        public string Post(string apiCallPath, IDictionary<string, object> parameters)
        {
            var postData = "";

            foreach (var parameter in parameters)
            {
                var k = parameter.Key;
                var v = parameter.Value;
                postData += k + "=" + HttpUtility.UrlEncode(v.ToString(), _encoding);
            }
            var postDataBytes = Encoding.ASCII.GetBytes(postData);

            // Create WebRequest
            var requestUrl = string.Format(GetEndpointUrlBase() + apiCallPath);
            var req = WebRequest.Create(requestUrl);

            // Specify Method: POST
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Specify POST data length.
            req.ContentLength = postDataBytes.Length;
            // Set ChatWork API Key
            req.Headers.Add(string.Format("X-ChatWorkToken: {0}", _credential.ApiKey));

            // Get POST Request Stream
            var reqStream = req.GetRequestStream();
            // Write POST data
            reqStream.Write(postDataBytes, 0, postDataBytes.Length);
            reqStream.Close();

            // Get Reseponse object from server
            var res = req.GetResponse();
            // Get Response stream
            var resStream = res.GetResponseStream();
            // receive data
            var sr = new StreamReader(resStream, _encoding);

            var resultJson = sr.ReadToEnd();

            sr.Close();

            return resultJson;

        }

        private string GetEndpointUrlBase()
        {
            return CHATWORK_ENDPOINT_BASE_URL + API_V1;
        }

    }
}

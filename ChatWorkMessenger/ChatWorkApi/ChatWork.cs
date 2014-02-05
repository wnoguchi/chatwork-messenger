using System.Collections.Generic;
using ChatWorkMessenger.ChatWorkApi.Core;

namespace ChatWorkMessenger.ChatWorkApi
{
    public class ChatWork
    {
        private ChatWorkCredential _credential;
        private ChatWorkRequest _request;

        public ChatWork(ChatWorkCredential credential)
        {
            _credential = credential;
            _request = new ChatWorkRequest(_credential);
        }

        public string SendMessage(long roomId, string message)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("body", message);

            var requestEndpoint = string.Format("/rooms/{0}/messages", roomId);

            var result = _request.Post(requestEndpoint, parameters);

            return result;
        }
    }
}

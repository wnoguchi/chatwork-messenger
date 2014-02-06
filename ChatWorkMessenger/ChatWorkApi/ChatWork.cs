using System.Collections.Generic;
using System.Web.Script.Serialization;
using ChatWorkMessenger.ChatWorkApi.Core;
using ChatWorkMessenger.ChatWorkApi.Models;

namespace ChatWorkMessenger.ChatWorkApi
{
    public class ChatWork
    {
        private ChatWorkCredential _credential;
        private ChatWorkRequest _request;
        private JavaScriptSerializer _jsonSerializer;

        public ChatWork(ChatWorkCredential credential)
        {
            _credential = credential;
            _request = new ChatWorkRequest(_credential);

            // prepare another peripheral utility classes
            _jsonSerializer = new JavaScriptSerializer();

        }

        public string SendMessage(long roomId, string message)
        {
            var parameters = new Dictionary<string, object> {{"body", message}};

            var requestEndpoint = string.Format("/rooms/{0}/messages", roomId);

            var result = _request.Post(requestEndpoint, parameters);

            return result;
        }

        public List<Room> GetRoomList()
        {
            var requestEndpoint = "/rooms";

            var result = _request.Get(requestEndpoint);

            var roomList = (List<Room>)_jsonSerializer.Deserialize(result, typeof(List<Room>));

            return roomList;
        }

        public List<Member> GetMemberList(long roomId)
        {
            var requestEndpoint = string.Format("/rooms/{0}/members", roomId);

            var result = _request.Get(requestEndpoint);

            var memberList = (List<Member>)_jsonSerializer.Deserialize(result, typeof(List<Member>));

            return memberList;
            
        }

    }
}

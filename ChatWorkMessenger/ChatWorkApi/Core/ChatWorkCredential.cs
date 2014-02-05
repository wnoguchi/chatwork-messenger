namespace ChatWorkMessenger.ChatWorkApi.Core
{
    /// <summary>
    /// ChatWork Credential Setting Value DTO.
    /// </summary>
    public class ChatWorkCredential
    {
        private string _apiKey;

        /// <summary>
        /// ChatWork API Key.
        /// </summary>
        public string ApiKey
        {
            get { return _apiKey; }
            set { _apiKey = value; }
        }
    }
}

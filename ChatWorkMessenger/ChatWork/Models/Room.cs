using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatWorkMessenger.ChatWork.Models
{
    public class Room
    {
  
        private long _lastUpdateTime;
        private string _iconPath;
        private int _taskNum;
        private int _fileNum;
        private int _messageNum;
        private long _roomId;
        private string _name;
        private string _type;
        private string _role;
        private bool _sticky;
        private int _unreadNum;
        private int _mentionNum;
        private int _mytaskNum;

        public int MytaskNum
        {
            get { return _mytaskNum; }
            set { _mytaskNum = value; }
        }

        public int MentionNum
        {
            get { return _mentionNum; }
            set { _mentionNum = value; }
        }

        public int UnreadNum
        {
            get { return _unreadNum; }
            set { _unreadNum = value; }
        }

        public bool Sticky
        {
            get { return _sticky; }
            set { _sticky = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public long RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        public int MessageNum
        {
            get { return _messageNum; }
            set { _messageNum = value; }
        }

        public int FileNum
        {
            get { return _fileNum; }
            set { _fileNum = value; }
        }

        public int TaskNum
        {
            get { return _taskNum; }
            set { _taskNum = value; }
        }

        public string IconPath
        {
            get { return _iconPath; }
            set { _iconPath = value; }
        }

        public long LastUpdateTime
        {
            get { return _lastUpdateTime; }
            set { _lastUpdateTime = value; }
        }
    }
}

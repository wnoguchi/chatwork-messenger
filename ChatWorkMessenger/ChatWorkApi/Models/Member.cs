using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatWorkMessenger.ChatWorkApi.Models
{
    public class Member
    {

        private string _avater_image_url;
        private string _department;
        private string _organization_name;
        private string _organization_id;
        private string _chatwork_id;
        private string _name;
        private string _role;
        private long _account_id;

        public string avater_image_url
        {
            get { return _avater_image_url; }
            set { _avater_image_url = value; }
        }

        public string department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string organization_name
        {
            get { return _organization_name; }
            set { _organization_name = value; }
        }

        public string organization_id
        {
            get { return _organization_id; }
            set { _organization_id = value; }
        }

        public string chatwork_id
        {
            get { return _chatwork_id; }
            set { _chatwork_id = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

        public long account_id
        {
            get { return _account_id; }
            set { _account_id = value; }
        }

    }
}

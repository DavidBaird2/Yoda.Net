using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yoda.Net.Networking.Data.Phone
{
    public class PhoneGroupData
	{
        private int _numMember;
        public object attachment;
        public string message;
        public bool hasNewMessage;
        public int postTime;
        public bool existMessage;
        public string title;
        public int type;
        private int _groupId;
        public string userCode;
        public PhoneGroupData(int groupId, int numMember)
        {
            _groupId = groupId;
            _numMember = numMember;
            return;
        }

        public int numMember
        {
            get{return _numMember;
            }
            set
            {
                _numMember = value;
            }
        }


        public int groupId
        {
            get
            {
                return _groupId;
            }

        }
	}
}

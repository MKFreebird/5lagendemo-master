using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatMessage.Models;

namespace _5lagendemo.CC
{
    public class CCSendMessage
    {
        public BUChatMessage bu;

        public int userID { get; set; }
        public string message { get; set; }
        public string timeStamp { get; set; }
        public int messageID { get; set; }

        public CCSendMessage(int _userID, string _message, string _timesStamp, int _messageID)
        {
            userID = _userID;
            message = _message;
            timeStamp = _timesStamp;
            messageID = _messageID;
            bu = new BUChatMessage(userID, message, timeStamp, messageID);
        }

        public void filterMessage()
        {
            bu.filterMessage();
        }

        public void sendMessage()
        {
            bu.sendMessage();
        }

    }
}
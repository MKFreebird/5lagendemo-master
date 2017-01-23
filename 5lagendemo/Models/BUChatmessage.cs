using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ChatMessage.Models
{
    public partial class BUChatMessage
    {
        public int userID { get; set; }
        public string message { get; set; }
        public string timeStamp { get; set; }
        public int messageID { get; set; }

        public BUChatMessage(int _userID, string _message, string _timeStamp, int _messageID)
        {
            userID = _userID;
            message = _message;
            timeStamp = _timeStamp;
            messageID = _messageID;
        }

        public void filterMessage()
        {
            try
            {
                Debug.WriteLine("test");
                StringBuilder cleanMessage = new StringBuilder(
                    HttpUtility.HtmlEncode(message));
                message = cleanMessage.ToString();
                Debug.WriteLine(message);
            }

            catch (Exception e)
            {
                Debug.WriteLine(e);
                message = String.Empty;
            }
        }
  
    }
}
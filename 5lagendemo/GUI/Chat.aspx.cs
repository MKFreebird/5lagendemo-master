using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _5lagendemo.CC;
using System.Diagnostics;

namespace _5lagendemo.GUI
{
    public partial class Chat : System.Web.UI.Page
    {
        CCSendMessage cc;

        private int userID { get; set; }
        private string message { get; set; }
        private string timeStamp { get; set; }
        private int messageID { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Session["name"] = txtName.Text;
            lblUname.Text = "Welcome " + txtName.Text;
            txtName.Text = "";
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            userID = 1;
            message = txtSend.Text;
            timeStamp = DateTime.Now.ToString();
            Debug.WriteLine(timeStamp.ToString());
            messageID = 1;
            txtSend.Text = "";
            txtChatBox.Text += "Speler: " + message + Environment.NewLine;
            cc = new CCSendMessage(userID, message, timeStamp, messageID);
            cc.filterMessage();
            cc.sendMessage();
        }
    }
}
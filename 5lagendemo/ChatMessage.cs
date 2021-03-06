
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ChatMessage.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;

    public partial class BUChatMessage
    {
        public int UserID { get; set; }
        public string Message { get; set; }
        public string TimeStamp { get; set; }
        public int MessageID { get; set; }

        public void sendMessage()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L3R8B5I\SQLEXPRESS;Initial Catalog=Chat;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                string query = "INSERT INTO ChatMessageSet (Message, TimeStamp, MessageID) " +
                               "VALUES (@Message, @TimeStamp, @MessageID)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // command.Parameters.AddWithValue("@Userid", userID);
                    command.Parameters.AddWithValue("@Message", message);
                    command.Parameters.AddWithValue("@TimeStamp", timeStamp);
                    command.Parameters.AddWithValue("@MessageID", messageID);

                    try
                    {
                        //     connection.Open();
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine(e.ToString());
                        
                    }

                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }


    }
}
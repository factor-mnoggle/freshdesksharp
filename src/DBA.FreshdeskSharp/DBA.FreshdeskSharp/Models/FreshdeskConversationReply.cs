using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DBA.FreshdeskSharp.Models
{
    public class FreshdeskConversationReply
    {
        public FreshdeskConversationReply()
        {
            Attachments = new List<object>();
            CcEmails = new List<string>();
            BccEmails = new List<string>();
        }


        public string Body { get; set; }

        public List<object> Attachments { get; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }



        [JsonProperty("cc_emails")]
        public List<string> CcEmails { get; }

        [JsonProperty("bcc_emails")]
        public List<string> BccEmails { get; }



        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

    }

    public class FreshdeskConversationReplyResponse : FreshdeskConversationReply
    {
        public FreshdeskConversationReplyResponse() : base()
        {
        }

        [JsonProperty("body_text")] public string BodyText { get; set; }

        public ulong Id { get; set; }

        [JsonProperty("ticket_id")] public ulong TicketId { get; set; }


        [JsonProperty("created_at")] public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")] public DateTime UpdatedAt { get; set; }

    }
}
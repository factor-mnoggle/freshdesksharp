using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DBA.FreshdeskSharp.Models
{
    public class FreshdeskNote
    {
        public FreshdeskNote()
        {
            Attachments = new List<object>();
            NotifyEmails = new List<string>();

            IsPrivate = true;
        }
        public List<object> Attachments { get; }


        public string Body { get; set; }

        public bool Incoming { get; set; }

        [JsonProperty("private")]
        public bool IsPrivate { get; set; }


        [JsonProperty("notify_emails")]
        public List<string> NotifyEmails { get; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

    }

    public class FreshdeskNoteResponse : FreshdeskNote
    {

        public FreshdeskNoteResponse() : base()
        {
            NotifiedTo = new List<string>();

        }

        [JsonProperty("body_text")]
        public string BodyText { get; set; }

        public ulong Id { get; set; }
        [JsonProperty("ticket_id")]
        public ulong TicketId { get; set; }


        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("notified_to")]
        public List<string> NotifiedTo { get; }




    }

}
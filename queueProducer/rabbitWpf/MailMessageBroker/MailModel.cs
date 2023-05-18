﻿using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace rabbitWpf.MessageBroker
{
    public class MailModel
    {
        public string? Sender { get; set; }
        public List<string> Recipients { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public List<AttachmentData> Attachments { get; set; }
        public string PlatformType { get; set; }

        public MailModel(string platformType)
        {
            Recipients = new List<string>();
            Attachments = new List<AttachmentData>();
        }
    }

    public class AttachmentData
    {
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public AttachmentData(string fileName, byte[] content)
        {
            FileName = fileName;
            Content = content;
        }
    }

}

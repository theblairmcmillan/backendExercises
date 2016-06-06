﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imageUploadTest.Models
{
    public class ContentViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Contents { get; set; }
        public byte[] Image { get; set; }

    }
}
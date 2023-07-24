﻿using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using LanguageDetection;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Instagram.Model
{
    public class ExcelData
    {
        public string ownername { get; set; }
        public string username { get; set; }
        public string phone_number { get; set; }
        public string link_ig { get; set; }
    }

    public class FollowerLink
    {
        public string ownername { get; set; }
        public string followerLink { get; set; }
    }
}

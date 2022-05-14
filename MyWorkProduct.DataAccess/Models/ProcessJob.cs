using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class ProcessJob
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Class { get; set; }
        public int Minutes { get; set; }
        public int NotBefore { get; set; }
        public int NotAfter { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public string EmailOwner { get; set; }
        public int LastRun { get; set; }
    }
}

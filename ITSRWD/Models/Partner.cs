using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ITSRWD.Models
{
    public class Partner
    {
        public int PartnerID { get; set; }
        public string PName { get; set; }
        public byte[] PLogo { get; set; }
        [DataType(DataType.MultilineText)]
        public string PInfo { get; set; }
    }
}
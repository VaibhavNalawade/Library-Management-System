using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class VolumeInfo
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public String Authors { get; set; }//array
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public string Search { get; set; }
        public int PageCount { get; set; }
        public string Categories { get; set; }//array
        public string MaturityRating { get; set; }
        public string ImageLinks { get; set; }
        public string Language { get; set; }
        public Double RetailPrice { get; set; }
    }
}

//6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public DateTime AddedDate { get; set; }
        public bool Confirmation { get; set; }
        public bool HomePage { get; set; }
    }
}
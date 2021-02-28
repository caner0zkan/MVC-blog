//1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog   //veritabanında blog tablosu oluşturulmadan önce entity'mizin kapsayacağı özellikleri tanımlıyoruz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }
        public bool Confirmation { get; set; }
        public bool HomePage { get; set; }

        //foregin key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
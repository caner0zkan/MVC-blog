//2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Category   //veritabanında category tablosu oluşturulmadan önce entity'mizin kapsayacağı özellikleri tanımlıyoruz
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        //foreign key
        public List<Blog> Blogs { get; set; }
    }
}
//3
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogContext:DbContext
    {
        //Bu kurucu metotla Initialazier'ı tanıtıyoruz. Aksi taktirde Initialazier içindeki yazılanlar yürütülmez.
        public BlogContext():base("blogDB") //oluşturmak istediğimiz web.config'deki veritabanı yolunu burada belirtiyoruz (başka bir veritabanında örneğin uzaktaki bir veritabanında vs. oluşturmak istiyorsak bunu kullanırız)
        {
            Database.SetInitializer(new BlogInitializer());
        }

        //veritabanındaki tablolarımızın oluşturulma işlemleri burada gerçekleşiyor
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
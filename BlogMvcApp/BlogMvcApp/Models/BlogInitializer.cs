//4
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)   //veritabanında yapılan her değişiklikten sonra test verilerinin tekrardan getirilmesi işlemi
        {
            List<Category> categories = new List<Category>()    //test verilerini oluşturduk (kategoriler için)
            {
                new Category() {CategoryName="C#"},
                new Category() {CategoryName="ASP.NET MVC"},
                new Category() {CategoryName="JavaScript"},
                new Category() {CategoryName="SQL"}
            };

            foreach (var item in categories)    //test verilerini veritabanına yerleştiriyoruz
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();  //işlemlerimizi yaptıktan sonra veritabanına kaydediyoruz

            //------------------------------------------------------------------------------------------------------------

            List<Blog> blogs = new List<Blog>()     //test verilerini oluşturduk (bloglar için)
            {
                new Blog(){Title="C# Delegates" , Comment="About C# Delegates" , AddedDate=DateTime.Now.AddDays(-10) , HomePage=true , Confirmation=true , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="1.jpg" , CategoryId=1},
                new Blog(){Title="C# Value Types" , Comment="About C# Value Types" , AddedDate=DateTime.Now.AddDays(-30) , HomePage=false , Confirmation=true , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="2.jpg" , CategoryId=1},
                new Blog(){Title="C# OOP" , Comment="About C# OOP" , AddedDate=DateTime.Now.AddDays(-12) , HomePage=false , Confirmation=false , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="1.jpg" , CategoryId=2},
                new Blog(){Title="Javascript Loops" , Comment="About Javascript Loops" , AddedDate=DateTime.Now.AddDays(-20) , HomePage=true , Confirmation=false , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="2.jpg" , CategoryId=2},
                new Blog(){Title="HTML Tags" , Comment="HTML Tags" , AddedDate=DateTime.Now.AddDays(-6) , HomePage=true , Confirmation=true , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="1.jpg" , CategoryId=3},
                new Blog(){Title="CSS Position" , Comment="About CSS Position" , AddedDate=DateTime.Now.AddDays(-40) , HomePage=true , Confirmation=false , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="2.jpg" , CategoryId=3},
                new Blog(){Title="SQL Mapping" , Comment="About SQL Mapping" , AddedDate=DateTime.Now.AddDays(-1) , HomePage=false , Confirmation=true , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="1.jpg" , CategoryId=3},
                new Blog(){Title="SQL Joins" , Comment="About SQL Joins" , AddedDate=DateTime.Now.AddDays(-23) , HomePage=false , Confirmation=false , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="2.jpg" , CategoryId=4},
                new Blog(){Title="C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays C Arrays " , Comment="About C Arrays" , AddedDate=DateTime.Now.AddDays(-14) , HomePage=true , Confirmation=true , Content="asfhjg ahjsfg ashjfghajsfgjkas kjasgfhkashf ajsgfhkasf" , Image="1.jpg" , CategoryId=4},
            };

            foreach (var item in blogs)     //test verilerini veritabanına yerleştiriyoruz
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();      //işlemlerimizi yaptıktan sonra veritabanına kaydediyoruz



            base.Seed(context);
        }
    }
}
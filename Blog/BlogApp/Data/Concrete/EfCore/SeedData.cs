using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Entity.Tag{Text = "web Programlama", Url = "web-programlama", Color = TagColors.warning},
                        new Entity.Tag{Text = "backend", Url="backend" , Color = TagColors.info},
                        new Entity.Tag{Text = "frontend", Url="frontend" , Color = TagColors.success},
                        new Entity.Tag{Text = "fullstack", Url="fullstack" , Color = TagColors.secondary},
                        new Entity.Tag{Text = "php", Url="php" , Color = TagColors.primary}                    
                    );
                    context.SaveChangesAsync() ;
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new Entity.User{ UserName = "salihkaya", Name="Salih Kaya", Email="salihkaya200210@gmail.com", Password="123456789", Image="p1.jpg"},
                        new Entity.User{ UserName = "sudekaya", Name="Sude Kaya", Email="sudekaya2006@gmail.com", Password="123456789", Image="p1.jpg"}
                        
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Entity.Post{
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url= "aspnet-core",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            Image = "1.jpg",
                            UserId = 1,
                            Comments = new List<Comment>{
                                new Comment {Text = "İyi bir kurs",PublishedOn = DateTime.Now.AddDays(-20),UserId=1 },
                                new Comment {Text = "Çok faydalandığım bir kurs",PublishedOn = DateTime.Now.AddDays(-10),UserId=2 },      
                            }


                            },

                        new Entity.Post{
                            Title = "Php",
                            Description = "Php dersleri",
                            Content = "php dersleri",
                            Url= "php",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            Image = "2.jpg",
                            UserId = 1
                            },
                            
                        new Entity.Post{
                            Title = "Django",
                            Description = "Django dersleri",
                            Content = "Django dersleri",
                            Url= "django",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                            },

                        new Entity.Post{
                            Title = "React",
                            Description = "React dersleri",
                            Content = "React dersleri",
                            Url= "react-dersleri",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                            },

                        new Entity.Post{
                            Title = "Angular",
                            Description = "Angular dersleri",
                            Content = "Angular dersleri",
                            Url= "angular",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                            },

                        new Entity.Post{
                            Title = "Web Tasarım",
                            Description = "Web Tasarım dersleri",
                            Content = "Web Tasarım dersleri",
                            Url= "web-tasarim",
                            IsActive= true,
                            PublishedOn = DateTime.Now.AddDays(-60),
                            Tags = context.Tags.Take(4).ToList(),
                            Image = "3.jpg",
                            UserId = 2
                            }                          
                    );
                    context.SaveChanges();
                }

                

            }
        }
    }
}
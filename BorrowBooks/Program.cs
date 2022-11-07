using Microsoft.EntityFrameworkCore;
using BorrowBooks.Models;

//à»â∫Ç®ééÇµÅAêVãKÇÃDBÇçÏê¨Ç∑ÇÈÅié∏îsÅj
//éQçl
//https://learn.microsoft.com/ja-jp/ef/ef6/modeling/code-first/workflows/new-database#3-create-a-context
//https://pgmemo.tokyo/data/archives/1266.html
namespace BorrowBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var tmp=new MyContext())
            {
                tmp.Users.Add(new User
                {
                    User_Name = "è¨óFêêãM",
                    Mail_Address="m-otomo@outlook.jp",
                    Password="m-otomo",
                    Phone="080-6789-1234"
                });
                tmp.SaveChanges();

                foreach(var user in tmp.Users)
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n{3}\n[4}",user.User_ID,user.User_Name,user.Mail_Address,user.Password,user.Phone);
                }
            }
        }
    }



}

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();


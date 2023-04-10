
using EcommerceWebUILab.Models.DataContext;
using EcommerceWebUILab.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace EcommerceWebUILab.Controllers
{
    public class ContactController : Controller
    {
        readonly EcommerceDbContext db;
        public ContactController(EcommerceDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contacts contacts)
        {
            if(ModelState.IsValid)
            {

                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:Port"]);
                var username = configuration["Gmail:Username"];
                var password = configuration["Gmail:Password"];
                var displayName = configuration["Gmail:DisplayName"];

                var enable = bool.Parse(configuration["Gmail:SMTP:starttls:enable"]);

                MailMessage mail = new MailMessage($"{contacts.Email}", $"{username}");
                mail.Subject = displayName;


                mail.Body = $@"
               <html>
               <head> 
               <style>
              

              </style>
              </head>
              <body>
              <h6>Email: {contacts.Email} </h6>
              <h6>Name: {contacts.Name}</h6> 
               <p>{contacts.Description}</p>
            </body>
            </html>";
                mail.IsBodyHtml = true;




                SmtpClient smtpClient = new SmtpClient(host, port);
                smtpClient.Credentials = new NetworkCredential(username, password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

    
                ViewBag.msg = "Your message has been sent successfully";

                db.Contacts.Add(contacts);
                db.SaveChanges();
            }
            return View();
        }
    }
}

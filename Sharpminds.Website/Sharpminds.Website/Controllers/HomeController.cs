using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Services;
using System.Web.Services;
using Sharpminds.Website.Models;

namespace Sharpminds.Website.Controllers
{
    public class HomeController : Controller
    {
        private const string Sharpmindswebmail = "website@sharpminds.dk";
        private const string Sharpmindsemail = "cani@sharpminds.dk";

        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult _Promotion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult _MessageModal(MailModel mailModel)
        {
            if (ModelState.IsValid)
            {
                mailModel.MailSent = true;
                SendMail(mailModel);
            }
            return Redirect("~/");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Coming soon.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Coming soon.";
            return View();
        }

        #region Helpers

        private static void SendMail(MailModel mailModel)
        {
            if (mailModel.Name == null && mailModel.Email == null) return;

            var message = new MailMessage { From = new MailAddress(Sharpmindswebmail) };
            message.To.Add(new MailAddress(Sharpmindsemail));
            message.Subject = mailModel.Subject.Equals(String.Empty) ? "No subject added" : mailModel.Subject;
            message.Body = string.Format("A website visitor has contacted us: \n\n" +
                                     "Name:    \t{0} \n" +
                                     "Phone:   \t{1} \n" +
                                     "E-mail:  \t{2} \n" +
                                     "Subject: \t{3} \n" +
                                     "Message: \t{4} \n",
                                     mailModel.Name, mailModel.Phone, mailModel.Email, mailModel.Subject, mailModel.Message);

            /* UnoEuro local client */
            var client = new SmtpClient("smtp.unoeuro.com", 25);
#if DEBUG
            client = new SmtpClient("asmtp.unoeuro.com", 8080)
            {
                Credentials = new NetworkCredential("website@sharpminds.dk", "9h13kt")
            };
#endif
            client.Send(message);
            client.Dispose();
            mailModel.MailSent = true;

        }

        #endregion

    }
}

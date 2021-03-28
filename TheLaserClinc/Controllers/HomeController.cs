using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using TheLaserClinc.Models;

namespace TheLaserClinc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new Contact());
        }

        [HttpPost]
        public ActionResult Contact(Contact model)
        {
            //Send the email ....

            try
            {
                var msg = new MailMessage(model.Email, "susan@thelaserclinic.org.uk");

                msg.Subject = "The Laser Clinic - " + model.Name + "(" + model.Phone + ") : " + model.Subject;
                msg.Body = model.Message;

                //Configure an SmtpClient to send the mail.
                SmtpClient client = new SmtpClient("relay-hosting.secureserver.net");
                client.Port = 25;
                client.Credentials = new NetworkCredential("susan@thelaserclinic.org.uk", "Th3laserclinic");
         
   
                //Send the msg
                client.Send(msg);

                model.Submitted = true;

            }
            catch (Exception ex)
            {
                model.Failed = true;
            }

            return View(model);
        }


    }
}
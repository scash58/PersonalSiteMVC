using PersonalSiteMVC.Models; //Added for access to the ContactViewModel class
using System;
using System.Collections.Generic;
using System.Configuration; //Added for access to the ConfigurationManager class
using System.Linq;
using System.Net; //Added for access to the NetworkCredential class
using System.Net.Mail; //Added for access to the MailMessage Class
using System.Web;
using System.Web.Mvc;

namespace PersonalSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Links()
        {
            return View();
        }

        //get
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel cvm)
        {

            //When a class has validation attributes, it is a good idea
            //to check the validation BEFORE attempting to process any data

            if (!ModelState.IsValid)
            {
                //Send them back to the form by passing the object 
                //to the View, and the form will return with the info
                //they provided

                return View(cvm);
            }

            //Only executes if the form (object) passes model validation
            //build the Message - what we will see when we receive the email
            string message = $"You have received an email from {cvm.Name} with a " +
                $"subject of {cvm.Subject}. Please respond to {cvm.Email} with your " +
                $"response to the following message: <br/>{cvm.Message}";

            //MailMessage (What sends the email)
            MailMessage mm = new MailMessage(

                //FROM
                ConfigurationManager.AppSettings["EmailUser"].ToString(),

                //TO
                ConfigurationManager.AppSettings["EmailTo"].ToString(),

                //SUBJECT
                cvm.Subject,

                //BODY
                message

                );

            //MailMessage Properties

            mm.IsBodyHtml = true; //Renders HTML in the email

            mm.Priority = MailPriority.High; //Flag the email as "high priority"

            mm.ReplyToList.Add(cvm.Email); //Allows us to reply directly to the person who completed the form

            //SmtpClient -- This is the information from the HOST (SmarterAsp.net
            //that allows the email to actually be sent
            SmtpClient client = new SmtpClient(ConfigurationManager.AppSettings["EmailClient"].ToString());

            //Client credentials (SmarterAsp requires a user name password)
            client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailUser"].ToString(),
                ConfigurationManager.AppSettings["EmailPass"].ToString());

            //It is possible that the mailserver is down or we may have some configuration isssues,
            //so we want to encapsulate our code in a try/catch
            try
            {
                //Attempt to send the email
                client.Send(mm);
            }
            catch (Exception ex)
            {

                ViewBag.CustomerMessage = $"We're sorry, but your request could not be completed at this time. " +
                    $"Please try again later. Error Message: <br/> {ex.StackTrace}";

                return View(cvm);

            }

            //If all goes well, return a View that displays a confirmation to the end user that the email was sent.


            return View("EmailConfirmation", cvm);

        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}
    }
}
using FeedBack.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeedBack.Controllers
{
    public class FeedbackInstallController : Controller
    {
        private string ApiKey = AppSettings.ApiKey;
        private string SecretKey = AppSettings.SecretKey;
        private string ShopifyUrl = AppSettings.ShopifyUrl;
        // GET: FeedbackInstall
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Install(string shop, string signature, string timestamp)
        {
            string install = string.Format( "https://{0}/admin/oauth/authorize?client_id={1}&scope=read_content,write_content&redirect_url=https://{2}/FeedbackInstall/Auth", shop, ApiKey, ShopifyUrl);
            return View();
        }

        public ActionResult Auth()
        {
            return View();
        }
    }
}
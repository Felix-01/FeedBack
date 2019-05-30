using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FeedBack.Services
{
    public static class AppSettings
    {
        public static string ApiKey { get; } = ConfigurationManager.AppSettings.Get("Shopify_API_Key");
        public static string SecretKey { get; } = ConfigurationManager.AppSettings.Get("Shopify_Secret_Key");
        public static string ShopifyUrl { get; } = ConfigurationManager.AppSettings.Get("Shopify_App_Url");
    }
}
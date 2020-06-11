using OpenTokSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PresenceKit.Opentok
{
    public class OpenTokService
    {

        public Session Session { get; protected set; }
        public OpenTok OpenTok { get; protected set; }

        public OpenTokService()
        {


            int apiKey = 0;
            string apiSecret = null;
            try
            {
                string apiKeyString = "46666732";
                apiSecret = "72bea282984b144904e257193b1d5cffe200c7ce";
                apiKey = Convert.ToInt32(apiKeyString);
            }

            catch (Exception ex)
            {
                //if (!(ex is ConfigurationErrorsException || ex is FormatException || ex is OverflowException))
                //{
                //    throw ex;
                //}
            }

            finally
            {
                if (apiKey == 0 || apiSecret == null)
                {
                    Console.WriteLine(
                        "The OpenTok API Key and API Secret were not set in the application configuration. " +
                        "Set the values in App.config and try again. (apiKey = {0}, apiSecret = {1})", apiKey, apiSecret);
                    Console.ReadLine();
                    Environment.Exit(-1);
                }
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            this.OpenTok = new OpenTok(apiKey, apiSecret);

            this.Session = this.OpenTok.CreateSession();
        }
    }
}
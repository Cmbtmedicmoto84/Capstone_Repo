using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MorimotoCapstone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            const string accountSid = "AC8a3820e8edbcf17c606936a77b6fae05";
            const string authToken = "06f1c2f40650d71de692491002ce40ee";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "I am Iron Man!",
                from: new Twilio.Types.PhoneNumber("+12057514836"),
                to: new Twilio.Types.PhoneNumber("+14144846175")
            );

            Console.WriteLine(message.Sid);
        }


        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

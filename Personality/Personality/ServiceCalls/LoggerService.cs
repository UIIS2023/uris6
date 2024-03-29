﻿using Newtonsoft.Json;
using Personality.Models;

namespace Personality.ServiceCalls
{
    public class LoggerService: ILoggerService
    {
        private readonly IConfiguration configuration;

        public LoggerService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void CreateMessage(Message message)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //Services:LoggerService je definisano u appsettings.json i sadrži lokaciju servisa
                    Uri url = new Uri($"{configuration["Services:LoggerService"]}api/logger");

                    HttpContent content = new StringContent(JsonConvert.SerializeObject(message));
                    content.Headers.ContentType.MediaType = "application/json";

                    //response has to be user
                    HttpResponseMessage response = client.PostAsync(url, content).Result;
                }
                catch
                {
                    //Lets the program function properly without logger service being active
                }
            }
        }
    }
}

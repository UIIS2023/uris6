﻿using payment.Models;
using payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment.ServiceCalls
{
    public interface ILoggerService
    {

        /// <summary>
        /// Metoda za kreiranje poruke logeru
        /// </summary>
        /// <param name="message"></param>
        void CreateMessage(Message message);
    }
}


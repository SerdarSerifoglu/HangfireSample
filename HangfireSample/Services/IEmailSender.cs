﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireSample.Services
{
    public interface IEmailSender
    {
        Task Sender(string userId, string message);
    }
}

using HangfireSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangfireSample.BackgroundJobs
{
    public class FireAndForgetJobs
    {
        public static void EmailSendToUserJob(string userId, string message)
        {
            //Tek sefer çalışacan br işlem için Enqueue methodu kullanılıyor.Db deki Job a ekliyor.
            Hangfire.BackgroundJob.Enqueue<IEmailSender>(x => x.Sender(userId, message));
        }
    }
}

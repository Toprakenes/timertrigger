using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("1 * * * * *")] TimerInfo myTimer, ILogger log)
        {


        }
    }
}

/*
                    
                                                                         %%%%%%
                                                                       %%%%%%
                                                             @   %%%%%%    @
                                                      @@   %%%%%%      @@
                                            @@@    %%%%E%%%%%%    @@@
                                          @@      %%%%%T%%%%        @@
                                                @@       %%%%%%       @@
                                                       @@      %%%       @@
                                                         @@    %%      @@
                                                                  %%
                                                                 %

*/
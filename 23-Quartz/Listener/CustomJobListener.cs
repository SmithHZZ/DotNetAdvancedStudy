using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Quartz.Listener
{
    public class CustomJobListener : IJobListener
    {
        public string Name => "CustomJobListener";

        public async Task JobExecutionVetoed(IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobExecutionVetoed");
            });
        }

        public async Task JobToBeExecuted(IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobToBeExecuted");
            });
        }

        public async Task JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobWasExecuted");
            });
        }
    }
}

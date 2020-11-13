using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Quartz.Listener
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomSchedulerListener : ISchedulerListener
    {
        public async Task JobAdded(IJobDetail jobDetail, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobAdded");
            });
        }

        public async Task JobDeleted(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobDeleted");
            });
        }

        public async Task JobInterrupted(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobInterrupted");
            });
        }

        public async Task JobPaused(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobPaused");
            });
        }

        public async Task JobResumed(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobResumed");
            });
        }

        public async Task JobScheduled(ITrigger trigger, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobScheduled");
            });
        }

        public async Task JobsPaused(string jobGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobsPaused");
            });
        }

        public async Task JobsResumed(string jobGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobsResumed");
            });
        }

        public async Task JobUnscheduled(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("JobUnscheduled");
            });
        }

        public async Task SchedulerError(string msg, SchedulerException cause, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerError");
            });
        }

        public async Task SchedulerInStandbyMode(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerInStandbyMode");
            });
        }

        public async Task SchedulerShutdown(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerShutdown");
            });
        }

        public async Task SchedulerShuttingdown(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerShuttingdown");
            });
        }

        public async Task SchedulerStarted(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerStarted");
            });
        }

        public async Task SchedulerStarting(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulerStarting");
            });
        }

        public async Task SchedulingDataCleared(CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("SchedulingDataCleared");
            });
        }

        public async Task TriggerFinalized(ITrigger trigger, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerFinalized");
            });
        }

        public async Task TriggerPaused(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerPaused");
            });
        }

        public async Task TriggerResumed(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerResumed");
            });
        }

        public async Task TriggersPaused(string triggerGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggersPaused");
            });
        }

        public async Task TriggersResumed(string triggerGroup, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggersResumed");
            });
        }
    }
}

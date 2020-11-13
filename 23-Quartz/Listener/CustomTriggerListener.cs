using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Quartz.Listener
{
    public class CustomTriggerListener : ITriggerListener
    {
        public string Name => "CustomTriggerListener";

        public async Task TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerComplete");
            });
                
        }

        public async Task TriggerFired(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerComplete");
            });
        }

        public async Task TriggerMisfired(ITrigger trigger, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("TriggerComplete");
            });
        }

        public async Task<bool> VetoJobExecution(ITrigger trigger, IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await Task<bool>.Run(() =>
            {
                Console.WriteLine("TriggerComplete");
                return true;
            });
        }
    }
}

using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Quartz.Job
{
    [PersistJobDataAfterExecution]//执行后保留数据，更新JobDataMap
    [DisallowConcurrentExecution]//拒绝同一时间重复执行(任务积压造成的)
    public class TestStatefulJob : IJob
    {

        public TestStatefulJob()
        {
            Console.WriteLine("TestJob Constructor");
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"ManagedThreadId = {Thread.CurrentThread.ManagedThreadId} TestJob DateTime = {DateTime.Now.ToString()}");

                Console.WriteLine($"context.JobDetail.JobDataMap[Hello] =  {context.JobDetail.JobDataMap["Hello"]}");

                Console.WriteLine($"context.Trigger.JobDataMap[World] =  {context.Trigger.JobDataMap["World"] }");

                Console.WriteLine($"context.MergedJobDataMap[Hello] =  {context.MergedJobDataMap["Hello"]}");

                Console.WriteLine($"context.MergedJobDataMap[World] =  {context.MergedJobDataMap["World"] }");

                context.JobDetail.JobDataMap.Put("Hello","World");
            });
            
        }
    }
}

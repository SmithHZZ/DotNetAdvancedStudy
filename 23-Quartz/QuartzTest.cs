using _23_Quartz.Job;
using _23_Quartz.Listener;
using _23_Quartz.LogProvider;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Quartz
{
    /// <summary>
    /// 
    /// Quartz
    /// 
    /// 定时调度：
    ///     大半夜跑一些数据统计，排行榜
    ///     数据同步，Lucene索引更新
    ///  
    ///     和数据库作业很像，但是Quartz不局限于数据库
    ///     
    /// Quartz
    ///     比较主流的定时调度框架
    ///     
    ///     三大核心对象
    ///         IScheduler：单元/实例，在这里完成定时任务的配置
    ///             只有单元启动，里面的作业才能正常运行
    ///         IJob：任务，定时执行的动作
    ///         ITrigger：定时策略，触发器
    ///         scheduler.ScheduleJob(jobDetail, trigger)就可以完成基本的定时任务
    ///         
    ///     
    /// Quartz使用
    ///     1、引入nuget包
    ///     2、实现IJob接口
    ///     3、配置、启动
    ///     
    /// 
    /// 为啥拆分job+trigger
    ///     方便复用、个性化定制
    ///     
    /// 一个job绑定多个trigger
    ///     所以job和trigger都可以传数据，满足不同的需求
    /// 
    /// 常用Trigger
    ///     SimpleTrigger从什么时候开始，间隔多久执行一次，重复多少次操作，限制最大次数
    ///     Cron 表达式的方式 可以灵活定制时间
    ///     
    /// Listener
    ///     对框架中任务的各个环节提供监听
    /// 
    /// </summary>
    public class QuartzTest
    {

        /// <summary>
        /// 
        /// Quartz的初步使用
        /// 
        /// </summary>
        public async static void Test01()
        {
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ScheduleJob(jobDetail, trigger);
            }

        }

        /// <summary>
        /// 带状态的Job
        /// </summary>
        public async static void Test02()
        {
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestStatefulJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ScheduleJob(jobDetail, trigger);
            }

        }

        /// <summary>
        /// 
        /// Scheduler监听器的使用
        /// 
        /// </summary>
        public async static void Test03()
        {
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ListenerManager.AddSchedulerListener(new CustomSchedulerListener());

                scheduler.ScheduleJob(jobDetail, trigger);
            }
        }

        /// <summary>
        /// 
        /// Trigger监听器的使用
        /// 
        /// </summary>
        public async static void Test04()
        {
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ListenerManager.AddTriggerListener(new CustomTriggerListener());

                scheduler.ScheduleJob(jobDetail, trigger);
            }
        }

        /// <summary>
        /// 
        /// Job监听器的使用
        /// 
        /// </summary>
        public async static void Test05()
        {
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ListenerManager.AddJobListener(new CustomJobListener());

                scheduler.ScheduleJob(jobDetail, trigger);
            }
        }

        /// <summary>
        /// Log使用
        /// </summary>
        public async static void Test06()
        {

            Quartz.Logging.LogProvider.SetCurrentLogProvider(new CustomLogProvider());
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            {
                //创建作业
                IJobDetail jobDetail = JobBuilder.Create<TestJob>().WithIdentity("testJob").WithDescription("this is test job").Build();

                //传数据
                jobDetail.JobDataMap["Hello"] = DateTime.Now.AddYears(1).ToString();

                //创建调度策略
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("testTrigger")
                    .StartNow()
                    //.StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10)))
                    .WithCronSchedule("0/2 * * * * ?")//每隔10秒
                    .Build();

                trigger.JobDataMap["World"] = DateTime.Now.AddMonths(2).ToString();

                scheduler.ScheduleJob(jobDetail, trigger);
            }

        }

    }
}

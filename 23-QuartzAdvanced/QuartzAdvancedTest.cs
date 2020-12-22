using _23_Quartz.Job;
using _23_Quartz.LogProvider;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_QuartzAdvanced
{
    public class QuartzAdvancedTest
    {
        /// <summary>
        /// 可视化管理工具，
        /// 定时任务执行中需要监控、人工介入
        /// Web系统（只能运行在当前服务器）
        /// 
        /// 
        /// 1、使用SchedulerManager中的方法获取scheduler，其中配置了web系统的连接信息
        /// 2、新建web项目，安装quartz、CrystalQuartz.Remote
        /// 3、启动web项目，启动定时任务项目
        /// 4、访问web项目路径http://localhost:55430/CrystalQuartzPanel.axd，即可看到定时任务相关信息
        /////var properties = new NameValueCollection();
        ////properties["quartz.scheduler.instanceName"] = "Test";

        ////// 设置线程池
        ////properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
        ////properties["quartz.threadPool.threadCount"] = "5";
        ////properties["quartz.threadPool.threadPriority"] = "Normal";

        ////// 远程输出配置
        ////properties["quartz.scheduler.exporter.type"] = "Quartz.Simpl.RemotingSchedulerExporter, Quartz";
        ////properties["quartz.scheduler.exporter.port"] = "555";
        ////properties["quartz.scheduler.exporter.bindName"] = "QuartzScheduler";
        ////properties["quartz.scheduler.exporter.channelType"] = "tcp";

        ////var schedulerFactory = new StdSchedulerFactory(properties);
        ////IScheduler _scheduler = await schedulerFactory.GetScheduler();
        /// 
        /// </summary>
        public async static void Test01()
        {

            Quartz.Logging.LogProvider.SetCurrentLogProvider(new CustomLogProvider());
            //初始化调度
            StdSchedulerFactory factory = new StdSchedulerFactory();

            //IScheduler scheduler = await factory.GetScheduler();
            IScheduler scheduler = await SchedulerManager.GetScheduler();

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

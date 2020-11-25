using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace _24_asp.net_mvc5.Utility
{

    /// <summary>
    /// 进行双检锁单例模式改造
    /// </summary>
    public class ContainerFactory
    {

        private static IUnityContainer _Container = null;
        private readonly static object ContainerFactoryLock = new object();

        public static IUnityContainer GetUnityContainer()
        {
            if(_Container == null)
            {
                lock(ContainerFactoryLock)
                {
                    if(_Container == null)
                    {
                        ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();

                        fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\Unity\\Unity.Config");

                        Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                        UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

                        _Container = new UnityContainer();

                        section.Configure(_Container, "container");
                    }
                }
            }

            return _Container;

        }
    }
}
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
    public class ContainerFactory
    {

        public static IUnityContainer GetUnityContainer()
        {
            IUnityContainer container = null;

            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();

            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles\\Unity\\Unity.Config");

            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

            container = new UnityContainer();

            section.Configure(container, "container");

            return container;

        }
    }
}
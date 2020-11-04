using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;

namespace _19_soa_webservice.Utility
{
    public class ContainerFactory
    {
        public static IUnityContainer BuildContainer()
        {
            return container;
        }

        private static IUnityContainer container = null;

        static ContainerFactory()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"CfgFiles//Unity.Config");

            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap,ConfigurationUserLevel.None);

            UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);

            container = new UnityContainer();

            section.Configure(container,"WebApiContainer");
        }
    }
}
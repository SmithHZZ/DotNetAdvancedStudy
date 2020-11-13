﻿using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Quartz.LogProvider
{
    public class CustomLogProvider : ILogProvider
    {
        public Logger GetLogger(string name)
        {
            return (level, func, exception, param) =>
            {
                if(level >= LogLevel.Info && func != null)
                {
                    Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] [{level}] {func()} {string.Join(";",param.Select(p=> p == null ? " " : p.ToString()))} 自定义日志 {name}");
                }
                return true;
            };
        }

        public IDisposable OpenMappedContext(string key, object value, bool destructure = false)
        {
            throw new NotImplementedException();
        }

        public IDisposable OpenNestedContext(string message)
        {
            throw new NotImplementedException();
        }
    }
}

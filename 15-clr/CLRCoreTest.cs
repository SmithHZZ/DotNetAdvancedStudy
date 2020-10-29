using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_clr
{
    /// <summary>
    /// 
    /// cs源文件->编译器编译->dll\exe->CLR/JIT->机器码010101
    /// 
    /// dll/exe 分为 metadata（清单数据） IL（使用CLR将IL翻译成机器码）
    /// 
    /// 不直接搞成机器码是因为要兼容平台、机器、环境
    /// 
    /// 如果要直接搞成机器码，就要针对每个平台编译一下
    /// 
    /// clr负责很多 程序集加载、异常处理、GC等
    /// 
    /// 
    /// </summary>
    public class CLRCoreTest
    {

    }
}

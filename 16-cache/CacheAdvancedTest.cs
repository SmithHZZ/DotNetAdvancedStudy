﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_cache
{

    /// <summary>
    /// 缓存进阶
    /// 
    /// 缓存失效时该更新还是删除？
    ///     数据更新影响单条缓存，常规做法是remove，而不是更新，因为缓存只是为了提升效率不是做数据保存的，下次用到了再重新加载缓存
    ///     
    ///     如果缓存的数据是经过复杂计算得出来的，此时应该倾向于删除，因为更新缓存的复杂度已经大于一次缓存击穿了
    ///     
    ///     对于影响一大批用户的缓存失效了，宁可滥杀无辜 不能放过一个 就是保证所有的失效的都清理掉的前提下，最小限度的清除失效的缓存  不要求精确
    ///     
    ///     第三方（其他程序）修改数据，缓存并不知道失效
    ///         可以调用接口清理缓存
    ///         容忍脏数据，可以加上时间限制，减少影响范围
    ///         
    /// 过期策略：
    ///     永久有效
    ///     绝对过期：设置时间点，到时间就过期
    ///     滑动过期：设置时间段，如果更新、查询就再续期
    /// 
    /// 多线程操作非线程安全的容器会造成冲突
    ///     1、使用安全容器
    ///     2、使用lock，性能太差
    ///     
    ///     如何降低影 提升性能响？
    ///         多个容器多个锁，容器间可并发
    ///             需要使用规则将key和容器绑定
    /// 
    /// 
    /// </summary>
    public class CacheAdvancedTest
    {

    }

}

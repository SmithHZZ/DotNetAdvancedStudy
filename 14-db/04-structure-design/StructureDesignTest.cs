﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_db._04_structure_design
{

    /// <summary>
    /// 
    /// 架构设计
    /// 
    ///     1、加强硬件：加机器、提升机器性能，商业化软件
    ///     2、架构设计
    ///         让数据库做最少的事：适当放弃触发器、外键、存储过程、函数
    ///         
    ///     1、数据库负载均衡：Moebius for SQL Server
    ///         多台数据库完成一台的事，要保证一致性
    ///         利用多台数据的读写能力，但是数据同步交给第三方软件，
    ///         每台数据库都有全部的数据，查询压力分布到不同的机器
    ///         对外只有一个IP
    ///         
    ///     2、读写分离
    ///         28原则：20%的工作是写 80%的工作是读
    ///         实现原理：就是把读和写的压力分开
    ///         一主多从：主库写 从库读
    ///         数据同步：从主库到从库（肯定有延迟）
    ///             1、数据库里连上别的数据库，link到主库+定时job
    ///             2、日志传送：备份-复制-恢复，解决多服务器热备份问题
    ///                 简单，但是有局限性
    ///             3、镜像：snapshot 内存快照
    ///             4、数据复制（发布订阅）
    ///                 从库订阅主库的（写操作）消息
    ///                 主库进行写操作时，将操作的内容和数据作为消息发布出去，各个从库收到后进行对应操作
    ///                 延迟小、配置方便，但是需要程序配合
    /// 
    ///     3、分库分表 表分区
    ///         最考验设计和开发
    ///         
    ///         分库：
    ///             1、垂直分库、按业务拆分
    ///                 一个库->多个库(用户库，订单库，商品库...)
    ///             2、水平分库、结构相同数据不相同，（如按照地域分、时间、随机算法）
    ///             
    ///         分表：
    ///             1、垂直分表
    ///                 如文章表:十个常规字段+一个内容字段
    ///                 常规字段一个表，内容字段一个表
    ///                 
    ///             2、水平分表，单表数据量太大
    ///                 订单表、商品表
    ///                 结构相同数据不相同，（如按照地域分、时间、随机算法）
    ///                 
    ///         如何查询？
    ///             像地产天然支持地域划分，如果需要横向对比，使用报表库解决
    /// 
    /// </summary>
    public class StructureDesignTest
    {
    }
}

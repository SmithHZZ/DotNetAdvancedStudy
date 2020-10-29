using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_db._02_transaction_lock
{
    /// <summary>
    /// 事务和锁
    /// 
    /// ACID
    /// 
    /// 原子性
    /// 一致性
    /// 隔离性
    /// 永久性
    /// 
    /// 问题：
    ///     脏读
    ///         读到了未提交的无效的数据
    ///     幻读
    ///         读到了不存在的数据
    ///     不可重复读
    ///         两次读取的数据不同
    ///     
    /// 锁：
    ///     悲观锁：使用数据库提供的锁机制、
    ///     乐观锁：版本号，比较和互换算法
    ///     
    ///     行级锁：只对当前操作的行上锁、
    ///     页级锁：对数据所在的页上锁、
    ///     表级锁：对整个表上锁
    ///     
    ///     共享锁：可以一起读，但是读期间谁都不能修改、
    ///     排它锁：就是不允许其他事物进行任何读写操作、
    ///     更新锁：防止死锁设计，可以读取但是不能修改，确定要修改时，将锁变为独占锁
    ///     
    /// 
    /// 隔离级别：
    ///     读未提交 READ_UNCOMMITTED
    ///         可以读到未提交的内容
    ///     读已提交 READ_COMITTED
    ///         Oracle的默认隔离级别，只能读到已经提交的数据
    ///     可重复读 REPEATABLE_READ
    ///         Mysql的默认隔离级别，其他事物不能改动和删除已经在读取的数据
    ///     序列化读 SERIALZIABLE
    ///         将共享锁保存到事物完成，事物之间完全隔离
    ///     
    /// 
    /// 
    /// </summary>
    public class TransactionLockTest
    {
    }
}

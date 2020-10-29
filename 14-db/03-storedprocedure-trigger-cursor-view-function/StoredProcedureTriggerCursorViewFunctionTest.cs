using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_db._03_storedprocedure_trigger_cursor_view_function
{

    /// <summary>
    /// 
    /// 存储过程：
    ///     一组完成特定功能的SQL语句，编译后存在数据库中，通过指定名称和参数执行
    ///     
    ///     不好维护，逻辑分散了，不好管理
    ///     
    ///     少用
    ///     
    /// 触发器：插入，修改，删除时（前/后）可以执行特定操作，建议不用
    /// 
    ///     性能，并发问题，触发器泛滥问题，嵌套问题
    ///     
    /// 游标 ：多用在存储过程，几乎不用
    /// 
    /// 视图： 虚拟的数据表，经常使用的多表查询可以创建视图方便使用
    /// 
    /// 函数：使用函数之后，不能使用索引（不走索引）
    /// 
    /// 统计字段：创建时间 创建人  最后更新时间  最后更新人 状态 是否启用
    /// 
    /// 假删除：不是使用delete语句、而是设置删除标记的字段
    /// 
    ///     会增加空间，一些唯一性规则被破坏
    ///     
    /// 
    /// 基于角色的权限系统
    ///     角色和功能是多对多
    ///     用户和角色也是多对多
    ///     
    /// 查询麻烦  
    ///     0、建视图  但是修改麻烦
    ///     1、给用户表添加字段，保存功能
    ///     2、缓存在程序中
    ///     
    /// 数据权限：
    ///     数据库表，字段、做访问控制
    ///     0、数据库本身就是分开的
    ///     1、给每个表都增加一个Path字段
    /// 
    /// 
    /// 
    /// 菜单表设计
    /// 
    /// </summary>
    public class StoredProcedureTriggerCursorViewFunctionTest
    {
    }
}

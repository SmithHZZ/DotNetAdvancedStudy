﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_database_index
{

    /// <summary>
    /// 数据库索引
    /// 
    /// 数据是根据数据页（8kb）存储的，单个字段只会在一个页中不会跨页存储
    /// 
    /// 如果是text、图片、二进制这种数据类型会使用单独的大容量页来存储，
    /// 数据页中只存储他们的引用，性能较低
    /// 
    /// 索引页：
    ///     存储数据和位置关系
    ///     独立的、重复的存储、体积小、扫描快
    /// 
    /// 
    /// 聚集（聚簇）索引
    ///     把数据有序摆放
    ///     类似于字典根据拼音的索引
    ///     找字母a开头放入
    ///     找时间范围的
    ///     MSSQL 自增int列，默认聚集索引，所以查询不排序就是Id排序
    ///     换聚集索引的列很耗时，因为会导致物理顺序的变化，生产环境谨慎操作
    ///     一个表只有一个聚集索引，但是可以组合多个列
    ///     一般是自增主键，创建时间
    ///     因为物理排序当然查询快
    ///     适合大于 小于 排序
    ///     不能运算  不能like '% %' in not in
    ///     走索引的条件在前，才能命中
    ///     
    /// 非聚集索引
    ///     类似新华字典中偏旁部首找字-找页码
    ///     重复存储值和路径，体积小，查找快，直达目标
    ///     不影响数据的物理排序
    ///     会重复存储一部分数据
    ///     找数据-先找索引，快速定位一下-拿到数据
    ///     查找快，有维护索引的成本，还有存储空间的牺牲
    ///     每个索引也可以多个字段
    ///     经常查询的字段 账号，名称
    ///     不能运算  不能like '% %' in not in
    ///     走索引的条件在前，才能命中
    /// 
    /// 建立索引的原则或者建议
    ///     1、主键是必须建立索引的
    ///     2、外键也要建立索引
    ///     3、经常查询的建立索引
    ///     4、经常在where里面
    ///     5、order by group by distinct
    ///     6、聚合运算 where时优先索引
    /// 
    /// 不推荐的建索引的
    ///     1、重复值比较多的
    ///     2、查询较少的
    ///     3、数据较大的text、二进制的
    ///     4、索引不要太多
    ///     
    /// 执行计划
    ///     数据库制定执行计划是按照使用资源最少，不是按照时间最短
    ///     提交sql语句，数据库查询优化器经过分析制定多个查询方式，从中选择资源使用最少的
    ///     
    /// 使用 显示估计的执行计划 可以查看SQL语句的执行花费资源
    /// 
    ///     1、Table Scan 全表扫描
    ///     2、Cluster Index Scan 性能最差，同上 虽然有聚集索引，其实也是全表扫描
    ///     3、Index Seek（NonClustered）性能非常高，非聚集索引的索引查找
    ///     4、Index Scan 先index 再扫描
    ///     5、Cluster Index Seek 性能最高
    /// 
    /// 
    /// select * from tb_name with(index = index_name) where 使用指定的索引
    /// 
    /// 
    /// 常规的sql优化建议
    ///     1、对列的计算要避免，会让索引失效
    ///     2、in / not in(完全不走索引) / or 索引失效，可以进行拆分 使用 union / union all（不去重） 进行组合 索引不失效
    ///     3、in 换成 exists
    ///     4、<  > 不走索引
    ///     5、join 时，连接越少性能越高，连接前筛选，减少主链接数据量
    ///     6、
    /// 
    /// </summary>
    public class DataBaseIndexTest
    {

    }
}

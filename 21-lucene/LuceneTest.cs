using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_lucene
{

    /// <summary>
    /// 
    /// 全文检索
    /// 
    /// 关系型数据库严格吻合
    /// 
    /// 无法解决模糊文本搜索的功能
    ///     1、性能没保障
    ///     2、垃圾数据多
    ///     
    /// 搜索时希望展示更多的结果，虽然有垃圾数据
    /// 相对于没有结果来说
    /// 
    /// 就是将搜索的key拆分成原子性的字和词（有意义的），再进行搜索
    /// 
    /// 使用lucene进行分词
    /// 
    /// Lucene.net
    ///     全文检索的工具包，不是应用，只是个类库，完成了全文检索的功能
    ///     
    /// Analysis
    ///     分词器，负责吧字符串拆解成院子，包含标准分词，直接空格拆分
    ///     项目中用的是盘古中文分词器
    ///     
    /// Document
    ///     数据结构，定义存储数据的格式
    ///     
    /// Index
    ///     索引的读写类
    /// QueryParser
    ///     查询解析器，负责解析查询语句
    /// Search
    ///     负责处理各种查询类（命令解析后的结果）
    /// Store
    ///     索引的存储类
    /// Util
    ///     常用的工具类库
    ///     
    /// lucene是全文检索必备的，是大型系统必备的
    /// 
    /// Search
    ///     TermQuery 单元查询
    ///         new Term("title","张三")
    ///     BooleanQuery
    ///         new Term("title","张三") and new Term("title","李四")
    ///     WildcardQuery 通配符查询
    ///         new Term("title","张*") //张开头，后面任意字
    ///         new Term("title","张?") //张后一个字
    ///     PhraseQuery 指定距离
    ///         包含没有 包含提莫 而且二者距离不能超过5
    ///     PrefixQuery 前缀查询
    ///         以XXX开头的
    ///     FuzzyQuery 近似查询
    ///         ibhone iphone
    ///     RangeQuery 范围查询
    ///         
    ///         
    /// </summary>
    public class LuceneTest
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Test01()
        {

        }
    }
}

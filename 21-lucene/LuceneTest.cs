using Lucene.Net.Analysis.PanGu;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
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
    ///     分词器，负责吧字符串拆解成原子，包含标准分词，直接空格拆分
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
            //初始化
            string IndexPath = AppDomain.CurrentDomain.BaseDirectory + "\\Index";


            List<Colp_Term_Detail> terms = new UserCenterDbContext().Colp_Term_Detail.ToList();

            //创建目录
            FSDirectory directory = FSDirectory.Open(IndexPath);
            //建立索引
            using (IndexWriter writer = new IndexWriter(directory,new PanGuAnalyzer(),true,IndexWriter.MaxFieldLength.LIMITED))
            {
                foreach (var item in terms)
                {
                    for(int i = 0; i<10; i++)
                    {
                        Document doc = new Document();

                        doc.Add(new Field("Id", item.Id, Field.Store.YES, Field.Index.NOT_ANALYZED));

                        doc.Add(new Field("Parent_Id", item.Parent_Id, Field.Store.YES, Field.Index.NOT_ANALYZED));

                        doc.Add(new Field("Parent_Name", item.Parent_Name, Field.Store.YES, Field.Index.ANALYZED));

                        doc.Add(new Field("Parent_Code", item.Parent_Code, Field.Store.NO, Field.Index.NOT_ANALYZED));

                        doc.Add(new Field("Name", item.Name, Field.Store.YES, Field.Index.ANALYZED));

                        doc.Add(new Field("Create_By", item.Create_By, Field.Store.YES, Field.Index.ANALYZED));

                        doc.Add(new Field("Create_On", item.Create_On.ToString(), Field.Store.YES, Field.Index.ANALYZED));

                        doc.Add(new Field("Modified_By", item.Modified_By, Field.Store.YES, Field.Index.ANALYZED));

                        doc.Add(new Field("Modified_On", item.Modified_On.ToString(), Field.Store.YES, Field.Index.ANALYZED));

                        writer.AddDocument(doc);
                    }
                }
                writer.Optimize();
            }


            FSDirectory dir = FSDirectory.Open(IndexPath);

            IndexSearcher searcher = new IndexSearcher(dir);
            //{
            //    TermQuery query = new TermQuery(new Term("Parent_Name", "宫颈"));

            //    //最后一个参数是最多查询多少条
            //    TopDocs docs = searcher.Search(query, null, 10000);

            //    foreach ( ScoreDoc sd in docs.ScoreDocs )
            //    {
            //        Document doc = searcher.Doc(sd.Doc);
            //        Console.WriteLine("*************************");
            //        Console.WriteLine($"Id={doc.Get("Id")}");
            //        Console.WriteLine($"Name={doc.Get("Name")}");
            //        Console.WriteLine($"Create_By={doc.Get("Create_By")}");
            //        Console.WriteLine($"Create_On={doc.Get("Create_On")}");
            //        Console.WriteLine($"Parent_Name={doc.Get("Parent_Name")}");

            //    }

            //    Console.WriteLine($"共命中{docs.TotalHits}个");
            //}

            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "Name", new PanGuAnalyzer());
            {
                //多关键词查询
                //不能准确解析句子，查找相近的内容，不够完美
                //string keywords = "宫颈鳞状HPV上皮";
                string keywords = "宫颈 鳞状 HPV 上皮";
                //{
                //    Query query = parser.Parse(keywords);
                //    TopDocs docs = searcher.Search(query, null, 10000);
                //    //获取的结果包含相关性得分，得分越高越接近
                //    foreach (ScoreDoc sd in docs.ScoreDocs)
                //    {
                //        Document doc = searcher.Doc(sd.Doc);
                //        Console.WriteLine("*************************");
                //        Console.WriteLine($"Id={doc.Get("Id")}");
                //        Console.WriteLine($"Name={doc.Get("Name")}");
                //        Console.WriteLine($"Create_By={doc.Get("Create_By")}");
                //        Console.WriteLine($"Create_On={doc.Get("Create_On")}");
                //        Console.WriteLine($"Parent_Name={doc.Get("Parent_Name")}");

                //    }

                //    Console.WriteLine($"共命中{docs.TotalHits}个");
                //}
                {
                    //对查询进行过滤、筛选、排序

                    Query query = parser.Parse(keywords);

                    SortField sortName = new SortField("Name", SortField.STRING, false);//升序
                    SortField sortParent_Name = new SortField("Parent_Name", SortField.STRING, true);//升序
                    TopDocs docs = searcher.Search(query, null, 10000);
                    //获取的结果包含相关性得分，得分越高越接近
                    foreach (ScoreDoc sd in docs.ScoreDocs)
                    {
                        Document doc = searcher.Doc(sd.Doc);
                        Console.WriteLine("*************************");
                        Console.WriteLine($"Id={doc.Get("Id")}");
                        Console.WriteLine($"Name={doc.Get("Name")}");
                        Console.WriteLine($"Create_By={doc.Get("Create_By")}");
                        Console.WriteLine($"Create_On={doc.Get("Create_On")}");
                        Console.WriteLine($"Parent_Name={doc.Get("Parent_Name")}");

                    }

                    Console.WriteLine($"共命中{docs.TotalHits}个");
                }
            }

            




        }
        

    }
}

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _12_crawler
{
    public class HttpWebRequestTest
    {
        /// <summary>
        /// 模拟浏览器获取网站信息
        /// </summary>
        public static void Test01()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp("http://www.baidu.com");

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36";

            request.ContentType = " text/html; charset=utf-8";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());

            Console.WriteLine(reader.ReadToEnd());
        }

        /// <summary>
        /// 如何处理获取来的一堆html
        /// 
        /// 
        /// 数据筛选：
        ///     1、正则：麻烦
        ///     2、自己实现
        ///     3、第三方工具 htmlagilitypack支持XPath(本质是正则)
        ///     
        /// 不同的网站需要定制
        /// 
        /// 同一个网站改版时爬虫基本不需要升级
        /// </summary>
        public static void Test02()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp("https://www.cnblogs.com/maodexie/p/6703296.html");

            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36";

            request.ContentType = " text/html; charset=utf-8";

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string content = reader.ReadToEnd();

            HtmlDocument document = new HtmlDocument();

            document.LoadHtml(content);

            //输出所有p标签中的内容

            string xpath = "//p";

            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(xpath);

            foreach (var node in nodes.Nodes())
            {
                Console.WriteLine(node.InnerText);
            }
            
        }
    }
}

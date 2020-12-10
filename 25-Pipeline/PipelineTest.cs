using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Pipeline
{
    /// <summary>
    /// 管道模型
    /// 
    /// 任何一个请求都是由具体的Handler来处理的
    /// 
    /// 以前写aspx，感觉请求的是物理地址
    /// 其实不然，请求的处理是框架设置的
    /// 
    /// 
    /// 管道处理模型，就是后台如何处理Http请求
    /// 定义多个事件完成处理步骤，每个事件可以扩展动作
    /// 最后有个httphandler完成请求的处理
    /// 
    /// 还有一个全局的上下文环境httpcontext，无论参数中间结果，最终结果，都保存在其中
    /// 
    /// 自定义Handler处理，就是可以处理各种后缀请求，可以加入自己的逻辑
    /// 
    /// 防盗链 加水印 伪静态 RSS
    /// 
    /// 还能进行浏览器版本的访问显示，满足规定的浏览器才允许查看
    /// 
    /// </summary>
    public class PipelineTest
    {



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_thread._01_sync_async
{
    public partial class FormTest : Form
    {

        Action<string> action = s =>
        {
            Console.WriteLine($"ManagedThreadId : {Thread.CurrentThread.ManagedThreadId} , {s}");
            Thread.Sleep(500);
        };

        public FormTest()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 同步方法
        /// 
        /// UI卡顿
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                action.Invoke(i.ToString());
            }
        }

        /// <summary>
        /// 异步方法
        /// 
        /// UI不会卡顿
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                action.BeginInvoke(i.ToString(),null,null);
            }
        }

        /// <summary>
        /// 异步进阶
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsyncAdvanced_Click(object sender, EventArgs e)
        {

            AsyncCallback asyncCallback = result =>
            {
                Console.WriteLine($"已经结束了  {result.AsyncState}");
            };

            IAsyncResult asyncResult = null;

            for (int i = 0; i < 5; i++)
            {
                //目标方法的参数
                //回调方法
                //回调方法的参数
                asyncResult = action.BeginInvoke(i.ToString(), asyncCallback, i);
            }

            //等待某次异步调用结束
            action.EndInvoke(asyncResult);

            
        }
    }
}

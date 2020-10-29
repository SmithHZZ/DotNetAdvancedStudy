using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace _09_io_serialize
{
    public class IOSerializeTest
    {
        public static void Test01()
        {
            /*====================================================================*/

            Directory.Exists("HelloWorld");

            Directory.Move("","");

            Directory.Delete("");

            /*====================================================================*/

            DirectoryInfo directoryInfo = new DirectoryInfo("");

            directoryInfo.Create();

            directoryInfo.Delete();

            directoryInfo.GetFiles();
        }

        public static void Test02()
        {
            /*====================================================================*/
            File.Create("");

            File.Copy("","");

            File.Move("", "");

            File.Delete("");

            File.Exists("");

            File.AppendText("");
            /*====================================================================*/

            FileInfo fileInfo = new FileInfo("");

            fileInfo.Create();

            //................

            /*====================================================================*/

            //在指定路径创建或覆盖文件
            FileStream fileStream = File.Create("");

            fileStream.Write(new byte[] { 0},0,10);

            fileStream.Flush();

            byte[] b = new byte[10];
            fileStream.Read(b,0,1);

            /*====================================================================*/

            StreamWriter sw = File.AppendText("");

            sw.Write(true);

            /*====================================================================*/


        }

        public static void Test03()
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();

            foreach(DriveInfo info in drivers)
            {
                try
                {
                    Console.WriteLine(info.DriveType);
                    Console.WriteLine(info.VolumeLabel);
                    Console.WriteLine(info.Name);
                    Console.WriteLine(info.TotalSize);
                    Console.WriteLine(info.TotalFreeSpace);
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        public static void Test04()
        {
            Path.GetDirectoryName("1.txt");

            Path.GetExtension("1.txt");

            Path.GetFileName("1.txt");

            Path.GetFileNameWithoutExtension("1.txt");

            Path.GetFullPath("1.txt");

            Path.GetPathRoot("1.txt");

            Path.Combine("hello", "world");
        }

        /// <summary>
        /// Json
        /// </summary>
        public static void Test05()
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();

            string str = jss.Serialize(new Student() { Id = 1,UserName = "Json",Password = "123456" });
            Console.WriteLine(str);

            List<Student> students = new List<Student>
            {
                new Student() { Id = 1,UserName = "Json",Password = "123456" },
                new Student() { Id = 2,UserName = "HelloWorld",Password = "654321"}
            };
            string str2 = jss.Serialize(students);
            Console.WriteLine(str2);

        }

        public static void Test06()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = File.Create("obj.txt");
            bf.Serialize(stream, new Student() { Id = 1, UserName = "Json", Password = "123456" });
            stream.Flush();
            stream.Close();
        }

        public static void Test07()
        {
            FileStream stream = File.Create("soap.txt");
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(stream, new Student() { Id = 1, UserName = "Json", Password = "123456" });
            stream.Flush();
            stream.Close();
        }

        public static void Test08()
        {
            FileStream stream = File.Create("xml.txt");
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            xs.Serialize(stream,new Student() { Id = 1, UserName = "Json", Password = "123456" });
            stream.Flush();
            stream.Close();
        }

        public static void Test09()
        {
            Bitmap bitmap = new Bitmap(100, 100);

            Graphics graphics = Graphics.FromImage(bitmap);

            Pen redPen = new Pen(Color.Red, 8);

            graphics.Clear(Color.White);

            graphics.DrawLine(redPen, 50, 20, 500, 20);

            graphics.DrawEllipse(Pens.Black, new Rectangle(0, 0, 200, 100));

            graphics.DrawArc(Pens.Black, new Rectangle(0, 0, 200, 100),60,180);

            graphics.DrawLine(Pens.Black, 10, 10, 100, 100);

            graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, 100, 200));

            graphics.DrawString("还有一天", new Font("微软雅黑", 12), new SolidBrush(Color.Red), new PointF(10, 10));

            bitmap.Save("pic.jpg", ImageFormat.Jpeg);

            bitmap.Dispose();

            graphics.Dispose();

        }
    }
}

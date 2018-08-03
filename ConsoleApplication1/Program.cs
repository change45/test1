using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rzq.ChouJiang;
using Rzq.ChouJiang.Logic;
using Rzq.ChouJiang.Model;
using System.Threading;
using System.Configuration;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- " + DateTime.Now.ToString("HH:mm:ss") + " 启动程序 -----------");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 5");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 4");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 3");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 2");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 1");
            Thread.Sleep(1000);
            Console.WriteLine("----------- 0");

            //var mainid = Convert.ToInt32(ConfigurationManager.AppSettings["AwardMainId"]);

            //Thread[] threads = new Thread[130];
            ////定义并初始化10个线程 
            //for (int i = 0; i < 130; i++)
            //{
            //    Thread t = new Thread(new ParameterizedThreadStart(runs));
            //    threads[i] = t;
            //}

            ////启动10个线程  
            //for (int i = 0; i < 130; i++)
            //{
            //    Console.WriteLine("----------- threads[{0}].Start()", i);
            //    if (i < 50)
            //        mainid = 2;
            //    else if (i < 90)
            //        mainid = 3;
            //    else if (i < 120)
            //        mainid = 4;
            //    else if (i < 130)
            //        mainid = 5;

            //    threads[i].Start(mainid);
            //}

            runs(1);
            runs(2);
            runs(3);
            runs(4);
            runs(5);
            runs(6);
            runs(7);
            runs(8);
            runs(9);
            runs(10);
            




            Console.WriteLine("----------- " + DateTime.Now.ToString("HH:mm:ss") + " 执行结束 -----------");
            Console.Read();
        }

        static void runs(int id)
        {
            Task t = new Task(() =>
            {
                Console.WriteLine("" + DateTime.Now.ToString("HH:mm:ss") + " 任务" + id + "开始工作……");
                //模拟工作过程
                Thread.Sleep(5000);
                Console.WriteLine("" + DateTime.Now.ToString("HH:mm:ss") + " id=" + id);
            });
            t.Start();

            t.ContinueWith((task) =>
            {
                Console.WriteLine("" + DateTime.Now.ToString("HH:mm:ss") + " 任务" + id + "完成(" + t.Id + ")，状态：IsCanceled={0},IsCompleted={1},IsFaulted={2}", task.IsCanceled, task.IsCompleted, task.IsFaulted);
            });
        }







    }
}

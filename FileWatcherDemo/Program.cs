using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherDemo
{
    public delegate void FileMonitorHandler();

    class Program
    {
        public event FileMonitorHandler FileMonitorEvent;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ReadFile("config.txt");
        }

        /// <summary>
        /// 读取文件，练习读取配置文件操作
        /// </summary>
        /// <param name="path"></param>
        private void ReadFile(string configPath)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + configPath;
            Console.WriteLine("读取配置文件路径：" + path);
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while (null != (line = reader.ReadLine()))
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            Console.ReadKey();
        }
    }


}

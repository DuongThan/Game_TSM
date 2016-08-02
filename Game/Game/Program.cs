using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            Khung khung_ = new Khung();
            khung_.Show();
            Random rd = new Random();
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    app.DiChuyen(info);
                }
                Thread.Sleep(10);
                //app.ShowMoi();
                int t = rd.Next(1, 5);
                app.MoiDiChuyen(t);
                app.ShowBird();
            }
        }
    }
}

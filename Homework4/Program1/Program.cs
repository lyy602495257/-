using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void RingEventHandler(object sender, RingEventArgs e);
public class RingEventArgs:EventArgs
{
    public string str = "Time is up!!!";
}

namespace program1
{
    class Program
   {
        static void Main(string[] args)
        {
            System.DateTime settime = new System.DateTime();
            Console.Write("输入要倒数的时间秒数：");
            int s = int.Parse(Console.ReadLine());
            System.DateTime startTime = System.DateTime.Now;
            settime = (startTime).AddSeconds(s);
            Ring ring = new Ring();
            ring.setTime = settime;
            ring.Ringing += show;
            ring.RingSet(); 
        }
public class Ring
{
            public event RingEventHandler Ringing;
            public System.DateTime setTime;
        public void RingSet()
        {
                while (setTime > System.DateTime.Now)
                {
            System.Threading.Thread.Sleep(1000);
                 }
        if (Ringing != null)
        {
            RingEventArgs args = new RingEventArgs();
            Ringing(this, args);
        }
    }
}
    static void show(object sender, RingEventArgs e)
        {
            Console.WriteLine(e.str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconEventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sender sender = new Sender();
            Receiver receiver1 = new Receiver("Hen", NewsType.Math);
            Receiver receiver2 = new Receiver("Jen", NewsType.Science);
            Receiver receiver3 = new Receiver("Marry", NewsType.Sport);
            Receiver receiver4 = new Receiver("Joseph", NewsType.Science);
            Receiver receiver5 = new Receiver("Mike", NewsType.Sport);

            sender.Send += receiver1.ReceiveMsg;
            sender.Send += receiver2.ReceiveMsg;
            sender.Send += receiver3.ReceiveMsg;
            sender.Send += receiver4.ReceiveMsg;
            sender.Send += receiver5.ReceiveMsg;

            sender.SendNews();
            Console.ReadKey();
        }
    }
}

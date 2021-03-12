using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconEventSample
{
    public class Receiver
    {
        private NewsType _NewsType { get; set; }
        private string _Name { get; set; }

        public Receiver(string Name, NewsType NewsType)
        {
            this._Name = Name;
            this._NewsType = NewsType;
        }

        public void ReceiveMsg(Object sender, Sender.SenderEventArgs e)
        {
            Sender send = (Sender)sender;  
            if (this._NewsType == e.NewsType)
            {
                Console.WriteLine(string.Format("receiver name {0} receive News. The News type is {1}", this._Name, this._NewsType));
            }
        }
    }
}

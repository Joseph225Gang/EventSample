using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeconEventSample
{
    public class Sender
    {
        //宣告委託
        public delegate void SenderEventHandler(Object sender, SenderEventArgs e);
        public event SenderEventHandler Send; //宣告事件
        // 定義BoiledEventArgs類，傳遞給Observer所感興趣的資訊

        public class SenderEventArgs : EventArgs
        {
            public readonly NewsType NewsType;

            public SenderEventArgs(NewsType newsType)
            {
                this.NewsType = newsType;
            }
        }

        protected virtual void OnSend(SenderEventArgs e)
        {
             Send(this, e); 
        }

        public void SendNews()
        {
            int MAX_SEND_NUM = 3;
            for (int i = 0; i < MAX_SEND_NUM; i++)
            {
                SenderEventArgs e = new SenderEventArgs((NewsType)i + 1);
                OnSend(e);
            }
        }
    }
}

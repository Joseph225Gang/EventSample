using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class Heater
    {
        private int temperature;
        public string type = "RealFire 001";    
        public string area = "China Xian";     
        //宣告委託
        public delegate void BoiledEventHandler(Object sender, BoiledEventArgs e);
        public event BoiledEventHandler Boiled;
        public class BoiledEventArgs : EventArgs
        {
            public readonly int temperature;
            public BoiledEventArgs(int temperature)
            {
                this.temperature = temperature;
            }
        }
        protected virtual void OnBoiled(BoiledEventArgs e)
        {
            if (Boiled != null)
            { // 如果有物件註冊
                Boiled(this, e); 
            }
        }
        // 燒水。
        public void BoilWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    //建立BoiledEventArgs 物件。
                    BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e); // 呼叫 OnBolied方法
                }
            }
        }
    }
}

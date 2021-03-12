using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class Display
    {
        public static void ShowMsg(Object sender, Heater.BoiledEventArgs e)
        {  //靜態方法
            Heater heater = (Heater)sender;
            Console.WriteLine("Display：{0} - {1}: ", heater.area, heater.type);
            Console.WriteLine("Display：水快燒開了，當前溫度：{0}度。", e.temperature);
            Console.WriteLine();
        }
    }
}

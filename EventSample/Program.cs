using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.Boiled += alarm.MakeAlert;  //註冊方法
            heater.Boiled += (new Alarm()).MakeAlert;   //給匿名物件註冊方法
            heater.Boiled += new Heater.BoiledEventHandler(alarm.MakeAlert);  //也可以這麼註冊
            heater.Boiled += Display.ShowMsg;    //註冊靜態方法
            heater.BoilWater();  //燒水，會自動呼叫註冊過物件的方法
            Console.ReadKey();
        }
    }
}

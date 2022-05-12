using System;
using System.Timers;

public class ClockSimulator
{ 

    public class Clock
    {
        // 定时器
        public System.Timers.Timer timer = new System.Timers.Timer(1000);
        public ClockTime AlarmTime = new ClockTime();
        
        

        
        public void SetAlarm(int hour, int minute, int second)
        {
            AlarmTime = new ClockTime() { Hour = hour, Minute = minute, Second = second };
        }

        
       

        public void simulate()
        {
            timer = new System.Timers.Timer(1000);

            timer.Elapsed += new ElapsedEventHandler(onTick);
            timer.Elapsed += new ElapsedEventHandler(onAlarm);
            timer.AutoReset = true;
            timer.Enabled = true;

            


        }

       

        public void onTick(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("di~:" + e.SignalTime.ToString("hh:mm:ss"));
    
            
        }

        public void onAlarm(object sender, ElapsedEventArgs e)

        {
           
            if (e.SignalTime.Hour == AlarmTime.Hour && e.SignalTime.Minute == AlarmTime.Minute && e.SignalTime.Second == AlarmTime.Second)
            {
                Console.WriteLine("alarm~:" + e.SignalTime.ToString("hh:mm:ss"));
            }
        }

        



    }

    
    static void Main(string[] args)
    {

        //创建一个时钟
       Clock clock = new Clock();
        clock.SetAlarm(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second + 3);

      

        clock.simulate();

        Console.WriteLine("press key to stop");
        Console.ReadLine();
        clock.timer.Stop();




    }

    

}
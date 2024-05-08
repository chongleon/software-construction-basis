using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clock {
    /// Main class
    class MainClass {

        static void Main(string[] args) {
            try {
                AlarmClock clock = new AlarmClock(); //时钟
                clock.AlarmTime = new ClockTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second + 5);
                clock.AlarmEvent += PlayMusic;
                int sum = 0;
                clock.TickEvent += (c => Count(c, ref sum));
                new Thread(clock.Run).Start(); //在新线程里面启动时钟

                Console.WriteLine("press any key to stop.");
                Console.ReadKey();
                clock.Stop();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        private static void Count(AlarmClock clock, ref int sum) {
            ClockTime time = clock.CurrentTime;
            sum = sum + 1;
            Console.WriteLine($"Sum= {sum}");
        }

        public static void PlayMusic(AlarmClock clock) {
            ClockTime time = clock.CurrentTime;
            Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("Playing music....");
        }
    }
}

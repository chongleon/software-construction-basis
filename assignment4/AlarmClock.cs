using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock {

    /// <summary>
    /// Event publisher:Clock class
    /// </summary> 
    class AlarmClock {

        public event Action<AlarmClock> AlarmEvent;

        public event Action<AlarmClock> TickEvent;

        private bool stop = false;

        public AlarmClock() {
            CurrentTime = new ClockTime();
            //为两个事件设置一个内部的处理函数
            TickEvent += c => Console.WriteLine("Tick!" + CurrentTime);
            AlarmEvent += c => Console.WriteLine("Ding! Ding! Ding!");
        }

        public ClockTime CurrentTime { get; set; }

        public ClockTime AlarmTime { get; set; }

        /// <summary>
        /// 启动时钟，持续运行，直到stop变为false
        /// </summary>
        public void Run() {
            Console.WriteLine("Clock is started!");
            stop = false;
            while (!stop) {
                DateTime now = DateTime.Now;
                CurrentTime = new ClockTime(now.Hour, now.Minute, now.Second);
                TickEvent(this);
                if (AlarmTime.Equals(CurrentTime)) AlarmEvent(this);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Clock is stopped!");
        }

        public void Stop() {
            this.stop = true;
        }
    }
}

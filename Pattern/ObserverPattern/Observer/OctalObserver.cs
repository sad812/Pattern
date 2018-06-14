using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 八进制
    /// </summary>
    public class OctalObserver : IObserver
    {
        public override void update(Subject subject)
        {
            Console.WriteLine($"Octal String {Convert.ToString(subject.getState(), 8)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 十六进制
    /// </summary>
    public class HexaObserver : IObserver
    {
        public override void update(Subject subject)
        {
            Console.WriteLine($"Hexa String {Convert.ToString(subject.getState(), 16)}");
        }
    }
}

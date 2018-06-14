using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 二进制定制者
    /// </summary>
    public class BinaryObserver : IObserver
    {
        /// <summary>
        /// 重写通知方法
        /// </summary>
        public override void update(Subject subject)
        {
            Console.WriteLine($"Binary String:{ Convert.ToString(subject.getState(), 2)}");
        }
    }
}

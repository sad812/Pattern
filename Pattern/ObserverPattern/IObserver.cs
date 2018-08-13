using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{

    /// <summary>
    /// 观察者接口
    /// </summary>
    public abstract class IObserver
    {
        /// <summary>
        /// /protected Subject subject;
        /// </summary>
        /// <param name="subject"></param>
        public abstract void update(Subject subject);
    }
}

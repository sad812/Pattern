using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    
    /// <summary>
    /// 观察者接口
    /// </summary>
    /// <param name="state"></param>
    public abstract class IObserver
    {
        //protected Subject subject;
        public abstract void update(Subject subject);
    }
}

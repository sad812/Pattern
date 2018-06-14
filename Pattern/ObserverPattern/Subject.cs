using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        private int msg;
        public Subject(int msg)
        {
            this.msg = msg;
        }
        public int getState()
        {
            return msg;
        }

        /// <summary>
        /// 设置主题
        /// </summary>
        /// <param name="state"></param>
        public void setState(int msg)
        {
            this.msg = msg;
            notifyAllObservers();
        }

        /// <summary>
        /// 添加订阅
        /// </summary>
        /// <param name="observer"></param>
        public void attach(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 通知订阅者
        /// </summary>
        public  void notifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(this);
            }
        }
    }
}

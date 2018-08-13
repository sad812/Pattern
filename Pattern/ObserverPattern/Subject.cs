using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    /// <summary>
    /// 订阅
    /// </summary>
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        private int msg;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg"></param>
        public Subject(int msg)
        {
            this.msg = msg;
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <returns></returns>
        public int getState()
        {
            return msg;
        }

        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="msg"></param>
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
        public void notifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(this);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{

    /// <summary>
    /// 中文订阅
    /// </summary>
    public class ChineseCharactorSubject : Subject
    {
        public ChineseCharactorSubject(int state) : base(state)
        {

        }
    }
}

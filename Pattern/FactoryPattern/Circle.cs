using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 圆
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// 画
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("画一个圆");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 长方形
    /// </summary>
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("this's Rectangle Draw !");
        }
    }
}

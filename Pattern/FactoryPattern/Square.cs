using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 长方形
    /// </summary>
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("this's Square Draw !");
        }
    }
}

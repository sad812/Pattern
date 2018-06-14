using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IShape GetShape<T>() where T : class, new()
        {
            AssemblyName name = new AssemblyName();

            #region 原始工厂
            //if (string.IsNullOrEmpty(shapeType?.Trim()))
            //{
            //    return null;
            //}
            //switch (shapeType)
            //{
            //    case "Rectangle":
            //        return new Rectangle();
            //    case "Circle":
            //        return new Circle();
            //    case "Square":
            //        return new Square();
            //    default:
            //        break;
            //} 
            #endregion

            #region 改造反射之后少增加一个实体时,都要增加对象工厂
            Type t = typeof(T);
            object entity = t.Assembly.CreateInstance(t.FullName); 
            #endregion

            return (IShape)entity;

        }
    }
}

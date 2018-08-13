using System;
using System.Collections.Generic;
using FactoryPattern;
using ObserverPattern;

namespace Show {
    class Program {
        static void Main (string[] args) {
            //ShapeFactory factory = new ShapeFactory();

            //IShape shape = factory.GetShape("Circle");
            //shape.Draw();

            //shape = factory.GetShape("Rectangle");
            //shape.Draw();

            //shape = factory.GetShape("Square");
            //shape.Draw();

            //factory.GetShape<Circle>().Draw();

            //Subject s = new Subject();
            var list = new List<string> () { "1", "2", "5" };
            var s = string.Format ("{0},{1},{2}", list.ToArray ());
            //"1,2,{2}"
            //ChineseCharactorSubject s = new ChineseCharactorSubject(2222);
            //BinaryObserver bo = new BinaryObserver();
            //HexaObserver ho = new HexaObserver();
            //OctalObserver oo = new OctalObserver();
            //s.attach(bo);
            //s.attach(ho);
            //s.attach(oo);

            //s.setState(555);
            Console.WriteLine(123);
            Console.WriteLine (s);
            string ss = Console.ReadLine();
            Console.WriteLine($"ss=>{ss}");

            Console.ReadLine();
        }
    }
}
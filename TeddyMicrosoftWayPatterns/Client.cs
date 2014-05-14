using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeddyMicrosoftWayPatterns.SimpleFactory;
using TeddyMicrosoftWayPatterns.Factory;
using TeddyMicrosoftWayPatterns.Prototype;
using TeddyMicrosoftWayPatterns.Facade;
using TeddyMicrosoftWayPatterns.Observer;
using TeddyMicrosoftWayPatterns.State;
using TeddyMicrosoftWayPatterns.Memento;
using TeddyMicrosoftWayPatterns.Singleton;
using TeddyMicrosoftWayPatterns.Command;


namespace TeddyMicrosoftWayPatterns
{
    public class Client
    {
        public static void Main(string[] args)
        {
            #region SimpleFactory Client
            //Operation oper, oper2;
            //oper = OperationFactory.createOperate("+");
            //oper.NumberA = 1;
            //oper.NumberB = 2;

            //oper2 = OperationFactory.createOperate("/");
            //oper2.NumberA = 1;
            //oper2.NumberB = 2;

            //Console.WriteLine(oper.GetResult().ToString());
            //Console.WriteLine(oper2.GetResult().ToString());
            #endregion

            #region Factory Client
            //IFactory operFactory = new AddFactory();
            //Operation oper = operFactory.CreateOperation();
            //oper.NumberA = 1;
            //oper.NumberB = 2;
            //Console.WriteLine(oper.GetResult().ToString());
            #endregion

            #region Prototype Client
            //Resume a = new Resume("teddyLong");
            //a.SetPersonalInfo("male", "28");
            //a.SetWorkExperience("2000", "Company A");

            //Resume b = (Resume)a.Clone();
            //b.SetWorkExperience("2010", "Company B");

            //Resume c = (Resume)a.Clone();
            //c.SetPersonalInfo("male", "18");
            //c.SetWorkExperience("2020", "Company C");
            
            //a.Display();
            //b.Display();
            //c.Display();
            #endregion

            #region Facade Client
            //Facade.Facade facade = new Facade.Facade();
            //facade.MethodA();
            //facade.MethodB();
            
            #endregion

            #region Observer Client
            //ConcreteSubject s = new ConcreteSubject();
            //s.Attach(new ConcreteObserver(s, "X"));
            //s.Attach(new ConcreteObserver(s, "Y"));
            //s.Attach(new ConcreteObserver(s, "Z"));

            //s.SubjectState = "TeddyLong";
            //s.Notify();
            #endregion

            #region State Client
            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();
            #endregion

            #region Memento Client
            //Originator o = new Originator();
            //o.State = "On";
            //o.Show();

            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();
            //o.State = "Off";
            //o.Show();

            //o.SetMemento(c.Memento);
            //o.Show();
            #endregion

            #region Singleton Client
            //Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
            //Singleton.Singleton s2 = Singleton.Singleton.GetInstance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("The s1,s2 instance are the same!");
            //}
            #endregion

            #region Command Client
            Receiver r = new Receiver();
            Command.Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(c);
            i.ExecuteCommand();
            #endregion

            #region Common Method
            Console.ReadLine();
            #endregion
        }
    }
}

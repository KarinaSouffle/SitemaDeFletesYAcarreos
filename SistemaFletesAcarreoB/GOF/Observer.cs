﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SistemaFletesAcarreoB.GOF
{
    abstract class Subject

    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }

    class ConcreteSubject : Subject

    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }


    abstract class Observer

    {
        public abstract void Update();
    }



    class ConcreteObserver : Observer

    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        // Constructor

        public ConcreteObserver(
          ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;

            MessageBox.Show("Observer " + _name + "'s new state is " + _observerState);
        }

        // Gets or sets subject

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
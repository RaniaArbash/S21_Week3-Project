using System;
using System.Collections.ObjectModel;

namespace Week3Project
{

    //public class Person
    //{
    //    string name { get; set; }
    //    Person(string n)
    //    {
    //        name = n;
    //    }
    //    Person()
    //    {
           
    //    }

    //}

    public class Student 
    {

        int _id;
        string _name;
        int _age;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Student(string n, int i, int a)
        {
            name = n;
            id = i;
            age = a;
        }
    }



}

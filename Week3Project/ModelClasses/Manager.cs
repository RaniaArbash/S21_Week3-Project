using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Week3Project
{
    public class Manager
    {
        // List don't implement INotifyPropertyChanged Inteface
        public ObservableCollection<Student> students =
              new ObservableCollection<Student>();

      public  Manager()
        {

            students.Add(new Student("Mary", 33, 20));
            students.Add(new Student("Tom", 9000,25));
            students.Add(new Student("Jon", 211, 30));

        }

        public void deleteStd (Student std)
        {
            students.Remove(std);
        }

        public void addStd(Student std)
        {
            students.Add(std);
        }
    }
}

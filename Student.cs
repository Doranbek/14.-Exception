using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork14
{
    class Student
    {
        public string  Name { get; private set; }
        public string SecondName { get; private set; }
        public int Cours  { get; private set; }

        private string title;

        public string Title
        {
            get { return title; }
            private set 
            {
                if (value == string.Empty) throw new ArgumentNullException("Пустое значение Title");
                else title = value; 
            }
        }


        public string author;

        public string Author
        {
            get { return author; }
            private set 
            { 
                if (value == string.Empty) throw new ArgumentNullException("Пустое значение Author");
                else   author = value; 
            }
        }
        public Student()
        {

        }
        public Student(string name, string secondName, int cours, string author, string title)
        {
            Name = name;
            SecondName = secondName;
            Cours = cours;
            Author = author;
            Title = title;
        }
        public Student(string author, string title, int cours)
        {
            
            Author = author;
            Title = title;
            Cours = cours;

        }

    }
}

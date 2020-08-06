using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork14
{
    class Student
    {
        public string name;
        public string surName;
        public int Cours  { get; private set; }

        
        public string Name
        {
            get { return name; }
            private set
            {
                if (value == string.Empty) throw new ArgumentNullException("Пустое значение Name");
                else name = value;
            }
        }

        public string SurName
        {
            get { return surName; }
            private set 
            { 
                if (value == string.Empty) throw new ArgumentNullException("Пустое значение SurName");
                else   surName = value; 
            }
        }
        public Student() 
        { 
        }
       
        public Student(string surName, string name, int cours)
        {
            
            SurName = surName;
            Name = name;
            Cours = cours;

        }

    }
}

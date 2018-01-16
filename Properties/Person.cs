using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {

        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
}

﻿

using T05BirthdayCelebrations;

namespace T04BorderControl
{
    public class Citizen : IIdentifiable, IBirthable
    {

        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age, string id, string birthdate)
        {

            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Birthdate { get; set; }
    }
}


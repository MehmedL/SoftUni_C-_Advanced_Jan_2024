﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age)
            : this()
        {
            this.age=age;
        }
        public Person(string name, int age)
            :this()
        {
            this.name = name;
            this.age = age;
        }
        
    }
}

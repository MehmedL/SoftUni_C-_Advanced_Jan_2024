using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
	

	public class Car
    {
		private string make;

        private int year;

		private string model;

		public string Model
		{
			get { return this.model; }
			set { model = value; }
		}

		public int Year
        {
            get { return this.year; }
            set { year = value; }
        }
        public string Make
		{
			get { return this.make; }
			set { make = value; }
		}

	}
}

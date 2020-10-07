using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Person
    {
        private int alder;

        public int Alder
        {
            get { return alder; }
            set
            {
                if (value > 67)
                {
                    TooOld?.Invoke(this, new CustomEvents() { Alder = value });
                }
                else
                {
                    alder = value;
                }
            }
        }

        public String Navn { get; set; }

        public event EventHandler<CustomEvents> TooOld;

    }
}

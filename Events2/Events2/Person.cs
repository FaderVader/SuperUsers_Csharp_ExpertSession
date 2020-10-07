using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public class Person
    {
        public string Navn { get; set; }        

        private int alder;

        public int Alder
        {
            get { return alder; }
            set {
                if (value > 67)
                {
                    TooOld?.Invoke(this, new TooOldEventArgs() { Alder = value});
                }
                alder = value;
            }
        }


        public override string ToString()
        {
            return $"{Navn} {Alder}";
        }

        public event EventHandler<TooOldEventArgs> TooOld;
    }
}

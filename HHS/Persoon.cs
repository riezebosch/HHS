using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHS
{
    public class Persoon
    {
        public Persoon()
        {

        }
        private DateTime _geboorteDatum;

        public DateTime getGeboorteDatum()
        {
            throw new NotAuthorizedException();
        }

        public void setGeboorteDatum(DateTime geboorteDatum)
        {
            _geboorteDatum = geboorteDatum;
        }


        public DateTime GeboorteDatum
        {
            set
            {
                _geboorteDatum = value;
            }
            get
            {
                return _geboorteDatum;
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyAutoImplementedProperty { get; set; }
        
    }
}

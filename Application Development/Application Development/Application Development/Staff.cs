using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development
{
    class Staff
    {
        private string firstName;
        private string surName;
        private DateTime updated;

        public void setFirstName(string newName)
        {
            firstName = newName;
        }
        public void setSurname(string newName)
        {
            surName = newName;
        }

        public void updateDate(DateTime date)
        {
            updated = date;
        }

        public DateTime getDate()
        {
            return updated;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public string getSurname()
        {
            return surName;
        }
    }
    class Manager : Staff
    { 
        
    }
}

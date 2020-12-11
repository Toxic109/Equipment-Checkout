using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Development
{
    class Equipment
    {
        private string name;
        private bool available;
        private DateTime updated;

        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }

        public bool getAvailable()
        {
            return available;
        }

        public void setAvailable(bool equipmentAvailable)
        {
            available = equipmentAvailable;
        }

        public void updateDate(DateTime date)
        {
            updated = date;
        }

        public DateTime getDate()
        {
            return updated;
        }
    }

    class Redditch : Equipment
    {

    }

    class Bromsgrove : Equipment
    {

    }

    class Worcester : Equipment
    {

    }

    class Malvern : Equipment
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi
{
    public class Person
    {

        #region data members
        private string Id, name, address;
        #endregion

        #region Properties
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            Id = "";
            name = "";
            address = "";
        }

        public Person(string pID, string pName, string pAddress)
        {
            Id = pID;
            name = pName;
            address = pAddress;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Address;
        }

        #endregion
    }
}

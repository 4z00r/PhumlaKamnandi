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
        private int id; 
        private String name, telephone, address;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
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
        public string Telephone
        {
            get { return telephone; }
            set {  telephone = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            id = 0;
            name = "";
            address = "";
        }

        public Person(int pID, string pName, string pAddress)
        {
            id = pID;
            name = pName;
            address = pAddress;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + address;
        }

        #endregion
    }
}

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
        private String name, telephone, address;
        #endregion

        #region Properties

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
            name = "";
            address = "";
        }

        public Person(string pName, string ptelephone, string pAddress)
        {
            name = pName;
            address = pAddress;
            telephone = ptelephone;
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

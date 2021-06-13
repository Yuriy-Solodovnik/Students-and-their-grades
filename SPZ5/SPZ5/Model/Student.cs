using System;
using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SPZ5
{
    [DataContract]
    public class Student
    {
        int _id;
        string _name;
        [DataMember]
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        [DataMember]
        public string name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                    _name = value;
            }
        }
    }
}

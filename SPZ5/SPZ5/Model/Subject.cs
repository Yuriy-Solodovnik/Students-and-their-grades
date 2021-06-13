using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SPZ5
{
    public class Subject
    {
        int _id;
        string _name;
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

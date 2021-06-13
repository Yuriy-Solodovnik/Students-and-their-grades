using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ5
{
    [DataContract]
    public class Mark
    {
        public Mark(string su, string st, int m)
        {
            _mark = m;
            _studentName = st;
            _subjectName = su;
        }
        int _id;
        string _studentName;
        string _subjectName;
        int _mark;
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
        public int mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if(value >= 60)
                    _mark = value;
            }
        }
        [DataMember]
        public string studentName
        { 
            get
            {
                return _studentName;
            }
            set
            {
                if (value != null)
                    _studentName = value;
            }
        }
        [DataMember]
        public string subjectName
        {
            get
            {
                return _subjectName;
            }
            set
            {
                if (value != null)
                    _subjectName = value;
            }
        }
        public override string ToString()
        {
            return "id - " + _id.ToString() + " mark - " + _mark.ToString() + " studentName - " + _studentName.ToString() + " subjectName - " + _subjectName.ToString()+"\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Forms;

namespace SPZ5
{
    public static class Storage
    {
        public static List<Student> students = new List<Student>();
        public static List<Subject> subjects = new List<Subject>();
        public static List<Mark> marks = new List<Mark>();
        static DataContractJsonSerializer jsonSerialazerSt = new DataContractJsonSerializer(typeof(List<Student>));
        static DataContractJsonSerializer jsonSerialazerSu = new DataContractJsonSerializer(typeof(List<Subject>));
        static DataContractJsonSerializer jsonSerialazerM = new DataContractJsonSerializer(typeof(List<Mark>));
        static Storage()
        {
            serializeStudent();
            serializeSubject();
            serializeMark();
        }
        public static void sortSubjects()
        {
            var newList = subjects.OrderBy(x => x.name);
            subjects = newList.ToList();
        }
        public static void serializeStudent()
        {
            using (var file = new FileStream("students.json", FileMode.Create))
            {
                jsonSerialazerSt.WriteObject(file, students);
            }
        }
        public static void getFromFileToStudent()
        {
            if (isEmpty("students.json"))
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                    students = jsonSerialazerSt.ReadObject(file) as List<Student>;
            }
            else
                return;
        }
        public static void serializeSubject()
        {
            using (var file = new FileStream("subjects.json", FileMode.Create))
            {
                jsonSerialazerSu.WriteObject(file, subjects);
            }
        }
        public static void getFromFileToSubject()
        {
            if (isEmpty("subjects.json"))
            using (var file = new FileStream("subjects.json", FileMode.OpenOrCreate))
            {
                    subjects = jsonSerialazerSu.ReadObject(file) as List<Subject>;
            }
            else
                return;
        }
        public static void serializeMark()
        {
            using (var file = new FileStream("marks.json", FileMode.Create))
            {
                jsonSerialazerM.WriteObject(file, marks);
            }
        }
        public static void getFromFileToMark()
        {
            if (isEmpty("marks.json"))
            using (var file = new FileStream("marks.json", FileMode.OpenOrCreate))
            {
                    marks = jsonSerialazerM.ReadObject(file) as List<Mark>;
            }
            else
                return;
        }
        static bool isEmpty(string path)
        {
            using (StreamReader re = new StreamReader(path))
            {
                if (re.ReadToEnd() == "")
                    return false;
                else
                    return true;
            }
        }
    }
}

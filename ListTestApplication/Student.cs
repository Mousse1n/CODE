using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListTestApplication
{
    public class Student : IEnumerable
    {
        public string Name { get; set; }
        internal static  object[] students =
        {
            new Student{Name ="aaa" },
            new Student{Name = "bbb" }
        };
        public IEnumerator GetEnumerator()
        {


            
            return new Enumerator(this);
            //throw new NotImplementedException();
        }
        struct Enumerator : IEnumerator
        {
            private object _currect;
            
            private object[] _localStudents;
            private int _index; 
            public Enumerator(Student student)
            {
                _localStudents = Student.students;
                _index = 0;
                _currect = _localStudents[_index];
            }
            public object Current => _currect;

            public bool MoveNext()
            {
                _index++;
                if (_index >= _localStudents.Length)
                {
                    return false;
                }
                _currect = _localStudents[_index];
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

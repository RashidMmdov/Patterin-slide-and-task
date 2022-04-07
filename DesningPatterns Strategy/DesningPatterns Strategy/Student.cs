using System;
using System.Collections.Generic;
using System.Text;

namespace DesningPatterns_Strategy
{
    internal class Student
    {
       private EnumStudentChouseType _type;
       private ExemStrategy _exem;
        public Student(EnumStudentChouseType Type)
        {
            _type = Type;
            switch (_type)
            {
                case EnumStudentChouseType.Dilci:
                    _exem = new Dilci();
                    break;
                case EnumStudentChouseType.Riyaziyyatci:
                    _exem = new Riyaziyyatci();
                    break;
                case EnumStudentChouseType.Avara:
                    _exem = new Avara();
                    break;
                default:
                    break;
            }
        }
        public string getStudents()
        {
            Console.WriteLine($"{_type} ucun Strategiya:\n");
            string Str = $"Birinci: {_exem.getFirst()}\nIkinci: {_exem.getSecond()}\nUcuncu: {_exem.getThird()}\nDorduncu: {_exem.getFourth()}\nBesinci: {_exem.getFifth()}";
            return Str;
        }
    }
}

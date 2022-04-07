using System;
using System.Collections.Generic;
using System.Text;

namespace DesningPatterns_Strategy
{
    internal class Riyaziyyatci : ExemStrategy
    {
        public EnumSubjects getFirst()
        {
            return EnumSubjects.Riyaziyyat;
        }

        public EnumSubjects getSecond()
        {
            return EnumSubjects.Fizika;
        }

        public EnumSubjects getThird()
        {
            return EnumSubjects.Kimya;
        }

        public EnumSubjects getFourth()
        {
            return EnumSubjects.AzDili;
        }

        public EnumSubjects getFifth()
        {
            return EnumSubjects.IngilisDili;
        }
    }
}

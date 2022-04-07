using System;
using System.Collections.Generic;
using System.Text;

namespace DesningPatterns_Strategy
{
    internal class Avara : ExemStrategy
    {
        public EnumSubjects getFirst()
        {
            return EnumSubjects.AzDili;
        }

        public EnumSubjects getSecond()
        {
            return EnumSubjects.Fizika;
        }

        public EnumSubjects getThird()
        {
            return EnumSubjects.IngilisDili;
        }

        public EnumSubjects getFourth()
        {
            return EnumSubjects.Riyaziyyat;
        }

        public EnumSubjects getFifth()
        {
            return EnumSubjects.Kimya;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesningPatterns_Strategy
{
    internal class Dilci : ExemStrategy
    {
        
        public EnumSubjects getFirst()
        {
            return EnumSubjects.AzDili;
        }

        public EnumSubjects getSecond()
        {
            return EnumSubjects.IngilisDili;
        }

        public EnumSubjects getThird()
        {
            return EnumSubjects.Kimya;
        }

        public EnumSubjects getFourth()
        {
            return EnumSubjects.Fizika;
        }

        public EnumSubjects getFifth()
        {
            return EnumSubjects.Riyaziyyat;
        }



    }
}

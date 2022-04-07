using System;
using System.Collections.Generic;
using System.Text;

namespace DesningPatterns_Strategy
{
    internal interface ExemStrategy
    {
        EnumSubjects getFirst();
        EnumSubjects getSecond();
        EnumSubjects getThird();
        EnumSubjects getFourth();
        EnumSubjects getFifth();
    }
}

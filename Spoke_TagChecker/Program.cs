using System;
using System.Collections.Generic;

namespace Spoke_TagChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TagChecker_Class.TagChecker(@"<B><C>This should be centred and in boldface, but there is a missing closing tag</C>");
        }
    }
}


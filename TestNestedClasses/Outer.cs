using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNestedClasses
{
    public static class Outer
    {
        public static string O1 => "1";
        public static class InnerA
        {
            public static string I1 => "A1";
        }
        public enum Types
        {
            None,
            One,
            Two
        }
    }
}

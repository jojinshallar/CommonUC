using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCommonUC.FormInputBox
{
    public class ClassAttribute:Attribute
    {
        public string Name { get; set; }
        public int MaxLength { get; set; }
    }
}

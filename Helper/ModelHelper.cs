using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Helper
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

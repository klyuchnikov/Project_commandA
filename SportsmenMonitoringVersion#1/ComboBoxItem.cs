using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sportsmen_Monitoring
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Id { get; set;}

        public override string ToString()
        {
            return Text;
        }
    }
}

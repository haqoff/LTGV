using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTGV.Format;

namespace LTGV
{
    public class Header
    {
        public string Name { get; }
        public ComboBox DimList { get; }
        public List<AbstractFormatter> Formatters { get; set; }

        public Header(ComboBox dimList, string name)
        {
            DimList = dimList;
            Name = name;
            Formatters = new List<AbstractFormatter>();
        }


    }
}

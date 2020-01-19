using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iceland2.Models
{
    public class InputItem
    {
        public String ItemName { get; set; }
        public int ItemValue { get; set; }
        public int ItemQuality { get; set; }
    }

    public class ItemList
    {
        public InputItem MyList { get; set; }

    }
}
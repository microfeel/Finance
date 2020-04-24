using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
   public class DtoProductClass
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int Level { get; set; }

        public bool IsLeaf { get; set; }
    }
}

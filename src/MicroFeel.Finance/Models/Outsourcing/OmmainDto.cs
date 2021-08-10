using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 委外订单DTO
    /// </summary>
    public class OmmainDto
    {
        public string CCode { get; set; }
        public DateTime DDate { get; set; }
        public string CMaker { get; set; }
        public string Brand { get; set; }
        public string CVenCode { get; set; }
    }
}

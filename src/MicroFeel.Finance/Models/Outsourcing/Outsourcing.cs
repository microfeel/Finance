using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 委外单据
    /// </summary>
    public class Outsourcing
    {
        ///<summary>
        ///单据创建日期
        ///</summary>
        public string DateTime { get; set; }
        ///<summary>
        ///委外车间名称	
        ///</summary>
        public string Supplier { get; set; }
        ///<summary>
        ///产品名称	
        ///</summary>
        public string ProductName { get; set; }
        ///<summary>
        ///产品码	
        ///</summary>
        public string ProductNumber { get; set; }
        ///<summary>
        ///产品型号	
        ///</summary>
        public string ProductModel { get; set; }
        ///<summary>
        ///产品批号	
        ///</summary>
        public string ProductBatch { get; set; }
        ///<summary>
        ///单据状态（0:新订单，1：已审核新订单，2：领料完成订单，3：生产完成订单，4：完结订单	)
        ///</summary>
        public int Status { get; set; }
        ///<summary>
        ///单号，单据的唯一标识	
        ///</summary>
        public string OrderNo { get; set; }
        ///<summary>
        ///完工日期	yyyy-MM-dd HH:mm:ss
        ///</summary>
        public string CommitDate { get; set; }
        ///<summary>
        ///产品数量	 
        ///</summary>
        public decimal Numbers { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }

    }
}

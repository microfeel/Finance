using System;
using System.Collections.Generic;
using System.Text;

namespace MicroFeel.Finance.Models.DbDto
{
    /// <summary>
    /// 存货
    /// </summary>
    public class DtoInventory
    {
        /// <summary>
        /// 存货名称 
        /// </summary>
        public string ProductName { get; set; }
        public string ProductNumbers { get; set; }
        public string ProductModel { get; set; }
        /// <summary>
        /// 大类名称
        /// </summary>
        public string InventoryClassName { get; set; }
        /// <summary>
        /// 大类编码
        /// </summary>
        public string InventoryClassCode { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitName { get; set; }
        public double Rate { get; set; }
        /// <summary>
        /// 最小存量
        /// </summary>
        public double? MinStoreNumbers { get; set; }
        /// <summary>
        /// 最大存量
        /// </summary>
        public double? MaxStoreNumbers { get; set; }
        /// <summary>
        /// 当前库存
        /// </summary>
        public List<DtoInventoryStock> InventoryStocks { get; set; }

    }
    /// <summary>
    /// 库存
    /// </summary>
    public class DtoInventoryStock
    {
        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }
        /// <summary>
        /// /批号
        /// </summary>
        public string ProductBatchNo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Numbers { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string StoreName { get; set; }
    }
}

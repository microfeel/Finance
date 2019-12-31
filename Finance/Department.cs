namespace MicroFeel.Finance
{
    public class Department
    {
        /// <summary>
        /// 核算项
        /// </summary>
        public int FItemId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 短编码
        /// </summary>
        public string ShortNumber { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string FaxNumber { get; set; }
        /// <summary>
        /// 上级部门编码
        /// </summary>
        public string ParentNumber { get; set; }
        /// <summary>
        /// 是门店
        /// </summary>
        public bool IsWorkShop { get; set; } = false;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }
    }
}

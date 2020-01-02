 

namespace MicroFeel.Finance.Models
{
    public class OrderStatus : IPlatformEntity
    {
        /// <summary>
        /// 应用版本
        /// </summary>
        
        public string Version { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
      
        public string Status { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
        
        public string ExpirationTime { get; set; }
    }
}
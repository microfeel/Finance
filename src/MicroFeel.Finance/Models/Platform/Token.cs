 
namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// API令牌
    /// </summary>
    public class Token
    {
        /// <summary>
        /// 应用程序appkey
        /// </summary>
    
        public string AppKey { get; set; }
        /// <summary>
        /// 过期时间(秒)
        /// </summary>
     
        public int ExpiresIn { get; set; }
        /// <summary>
        /// 令牌Id
        /// </summary>
       
        public string Id { get; set; }
    }
}

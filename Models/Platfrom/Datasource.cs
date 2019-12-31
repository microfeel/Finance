 
namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 数据源
    /// </summary>
    public class Datasource : IPlatformEntity
    {
        /// <summary>
        /// 数据源序号
        /// </summary>
      
        public string Sequence { get; set; }

        /// <summary>
        /// 系统对象
        /// </summary> 
        public SystemInfo SystemInfo { get; set; }
        /// <summary>
        /// 数据库对象
        /// </summary>
        
        public Db Db { get; set; }
    }

}

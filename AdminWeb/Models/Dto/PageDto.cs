using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminWeb.Models
{
    /// <summary>
    /// 分页请求数据传输对象
    /// </summary>
    public class ViewPageDto
    {
        /// <summary>
        /// 分页大小
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 偏移
        /// </summary>
        public int offset { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string order { get; set; }

        /// <summary>
        /// 分页请求数据传输对象
        /// </summary>
        public ViewPageDto()
        {
            this.limit = 10;
            this.offset = 0;
            this.order = String.Empty;
        }
    }

    /// <summary>
    /// 分页数据传输对象
    /// </summary>
    public class PageDataDto<T> where T : class, new()
    {
        /// <summary>
        /// 数据总条数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        public List<T> rows { get; set; }

        /// <summary>
        /// 分页数据传输对象
        /// </summary>
        public PageDataDto()
        {
            this.total = 0;
            this.rows = new List<T>();
        }
    }
}

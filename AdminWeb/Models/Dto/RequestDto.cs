using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AdminWeb.Models
{
    public class RequestBaseDto
    {
        /// <summary>
        /// 页偏移
        /// </summary>
        public int offset { get; set; }
        
        /// <summary>
        /// 页大小
        /// </summary>
        public int limit { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public string order { get; set; }




        /// <summary>
        /// 开始时间
        /// </summary>
        public string sTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string eTime { get; set; }
        
    }
}

using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESDemo
{
    public class CRMLog
    {
        /// <summary>
        /// 
        /// </summary>
        public string HttpMethod { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string RequestUrl { get; set; }
        /// <summary>
        /// 请求Json
        /// </summary>
        public string RequestJson { get; set; }
        /// <summary>
        /// 相应Json
        /// </summary>
        public string ResponseJson { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 控制器
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 内容体
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// 方法执行时间
        /// </summary>
        public long ActionTime { get; set; }

        /// <summary>
        /// 异常等级
        /// </summary>
        public int LogLevel { get; set; }

        /// <summary>
        /// 用户工号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 日志类型
        /// </summary>
        public string LogType { set; get; }
        /// <summary>
        /// 唯一值
        /// </summary>
        public string OnlyKey { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorInfo { get; set; }
        /// <summary>
        /// 浏览器版本
        /// </summary>
        public string UserAgent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 就医记录
    /// </summary>
    [SugarTable("jiuyijilu")]
	public class JiuyijiluDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 参保人账号
		/// </summary>
		[SugarColumn(ColumnName = "canbaorenzhanghao")]
		public string Canbaorenzhanghao { get; set; }

		/// <summary>
		/// Desc: 参保人姓名
		/// </summary>
		[SugarColumn(ColumnName = "canbaorenxingming")]
		public string Canbaorenxingming { get; set; }

		/// <summary>
		/// Desc: 性别
		/// </summary>
		[SugarColumn(ColumnName = "xingbie")]
		public string Xingbie { get; set; }

		/// <summary>
		/// Desc: 年龄
		/// </summary>
        [SugarColumn(ColumnName = "nianling")]
		public int? Nianling { get; set; } = 0;

		/// <summary>
		/// Desc: 头像
		/// </summary>
		[SugarColumn(ColumnName = "touxiang")]
		public string Touxiang { get; set; }

		/// <summary>
		/// Desc: 就诊医院
		/// </summary>
		[SugarColumn(ColumnName = "jiuzhenyiyuan")]
		public string Jiuzhenyiyuan { get; set; }

		/// <summary>
		/// Desc: 疾病名称
		/// </summary>
		[SugarColumn(ColumnName = "jibingmingcheng")]
		public string Jibingmingcheng { get; set; }

		/// <summary>
		/// Desc: 病情描述
		/// </summary>
		[SugarColumn(ColumnName = "bingqingmiaoshu")]
		public string Bingqingmiaoshu { get; set; }

		/// <summary>
		/// Desc: 诊断结果
		/// </summary>
		[SugarColumn(ColumnName = "zhenduanjieguo")]
		public string Zhenduanjieguo { get; set; }

		/// <summary>
		/// Desc: 治疗方案
		/// </summary>
		[SugarColumn(ColumnName = "zhiliaofangan")]
		public string Zhiliaofangan { get; set; }

		/// <summary>
		/// Desc: 诊断日期
		/// </summary>
        [SugarColumn(ColumnName = "zhenduanriqi")]
		[JsonConverter(typeof(Common.Helpers.DateFormatConverter), "yyyy-MM-dd")]
		public DateTime Zhenduanriqi { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}

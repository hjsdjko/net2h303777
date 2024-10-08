using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 医疗费用结算
    /// </summary>
    [SugarTable("yiliaofeiyongjiesuan")]
	public class YiliaofeiyongjiesuanDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 费用编号
		/// </summary>
		[SugarColumn(ColumnName = "feiyongbianhao")]
		public string Feiyongbianhao { get; set; }

		/// <summary>
		/// Desc: 费用类型
		/// </summary>
		[SugarColumn(ColumnName = "feiyongleixing")]
		public string Feiyongleixing { get; set; }

		/// <summary>
		/// Desc: 费用金额
		/// </summary>
        [SugarColumn(ColumnName = "feiyongjine")]
		public int? Feiyongjine { get; set; } = 0;

		/// <summary>
		/// Desc: 费用折扣
		/// </summary>
        [SugarColumn(ColumnName = "feiyongzhekou")]
		public int? Feiyongzhekou { get; set; } = 0;

		/// <summary>
		/// Desc: 应付金额
		/// </summary>
        [SugarColumn(ColumnName = "yingfujine")]
		public double? Yingfujine { get; set; } = 0;

		/// <summary>
		/// Desc: 结算日期
		/// </summary>
        [SugarColumn(ColumnName = "jiesuanriqi")]
		[JsonConverter(typeof(Common.Helpers.DateFormatConverter), "yyyy-MM-dd")]
		public DateTime Jiesuanriqi { get; set; }

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
		/// Desc: 头像
		/// </summary>
		[SugarColumn(ColumnName = "touxiang")]
		public string Touxiang { get; set; }

		/// <summary>
		/// Desc: 是否支付
		/// </summary>
		[SugarColumn(ColumnName = "ispay")]
		public string Ispay { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}

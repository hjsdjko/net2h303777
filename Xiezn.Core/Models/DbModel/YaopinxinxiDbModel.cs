using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 药品信息
    /// </summary>
    [SugarTable("yaopinxinxi")]
	public class YaopinxinxiDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 药品名称
		/// </summary>
		[SugarColumn(ColumnName = "yaopinmingcheng")]
		public string Yaopinmingcheng { get; set; }

		/// <summary>
		/// Desc: 药品类型
		/// </summary>
		[SugarColumn(ColumnName = "yaopinleixing")]
		public string Yaopinleixing { get; set; }

		/// <summary>
		/// Desc: 品牌
		/// </summary>
		[SugarColumn(ColumnName = "pinpai")]
		public string Pinpai { get; set; }

		/// <summary>
		/// Desc: 规格
		/// </summary>
		[SugarColumn(ColumnName = "guige")]
		public string Guige { get; set; }

		/// <summary>
		/// Desc: 有效期
		/// </summary>
		[SugarColumn(ColumnName = "youxiaoqi")]
		public string Youxiaoqi { get; set; }

		/// <summary>
		/// Desc: 适应症
		/// </summary>
		[SugarColumn(ColumnName = "shiyingzheng")]
		public string Shiyingzheng { get; set; }

		/// <summary>
		/// Desc: 数量
		/// </summary>
        [SugarColumn(ColumnName = "shuliang")]
		public int? Shuliang { get; set; } = 0;

		/// <summary>
		/// Desc: 价格
		/// </summary>
        [SugarColumn(ColumnName = "jiage")]
		public int? Jiage { get; set; } = 0;

		/// <summary>
		/// Desc: 用法用量
		/// </summary>
		[SugarColumn(ColumnName = "yongfayongliang")]
		public string Yongfayongliang { get; set; }

		/// <summary>
		/// Desc: 不良反应
		/// </summary>
		[SugarColumn(ColumnName = "buliangfanying")]
		public string Buliangfanying { get; set; }

		/// <summary>
		/// Desc: 药品图片
		/// </summary>
		[SugarColumn(ColumnName = "yaopintupian")]
		public string Yaopintupian { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}

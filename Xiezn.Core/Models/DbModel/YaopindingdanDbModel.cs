using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 药品订单
    /// </summary>
    [SugarTable("yaopindingdan")]
	public class YaopindingdanDbModel
	{           
		/// <summary>
		/// Desc: 主键Id
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, ColumnName = "id")]
		public long Id { get; set; }

		/// <summary>
		/// Desc: 订单编号
		/// </summary>
		[SugarColumn(ColumnName = "dingdanbianhao")]
		public string Dingdanbianhao { get; set; }

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
		/// Desc: 总价
		/// </summary>
        [SugarColumn(ColumnName = "zongjia")]
		public double? Zongjia { get; set; } = 0;

		/// <summary>
		/// Desc: 购买时间
		/// </summary>
        [SugarColumn(ColumnName = "goumaishijian")]
		public DateTime? Goumaishijian { get; set; }

		/// <summary>
		/// Desc: 订单备注
		/// </summary>
		[SugarColumn(ColumnName = "dingdanbeizhu")]
		public string Dingdanbeizhu { get; set; }

		/// <summary>
		/// Desc: 药品图片
		/// </summary>
		[SugarColumn(ColumnName = "yaopintupian")]
		public string Yaopintupian { get; set; }

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

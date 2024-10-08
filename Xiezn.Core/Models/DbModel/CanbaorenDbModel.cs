using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;

namespace Xiezn.Core.Models.DbModel
{
    /// <summary>
    ///	Desc: 参保人
    /// </summary>
    [SugarTable("canbaoren")]
	public class CanbaorenDbModel
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
		/// Desc: 密码
		/// </summary>
		[SugarColumn(ColumnName = "mima")]
		public string Mima { get; set; }

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
		/// Desc: 身份证
		/// </summary>
		[SugarColumn(ColumnName = "shenfenzheng")]
		public string Shenfenzheng { get; set; }

		/// <summary>
		/// Desc: 联系电话
		/// </summary>
		[SugarColumn(ColumnName = "lianxidianhua")]
		public string Lianxidianhua { get; set; }

		/// <summary>
		/// Desc: 联系地址
		/// </summary>
		[SugarColumn(ColumnName = "lianxidizhi")]
		public string Lianxidizhi { get; set; }

		/// <summary>
		/// Desc: 头像
		/// </summary>
		[SugarColumn(ColumnName = "touxiang")]
		public string Touxiang { get; set; }

		/// <summary>
		/// Desc: 添加时间
		/// </summary>
		[SugarColumn(ColumnName = "addtime")]
		public DateTime? Addtime { get; set; } = DateTime.Now;

	}
}

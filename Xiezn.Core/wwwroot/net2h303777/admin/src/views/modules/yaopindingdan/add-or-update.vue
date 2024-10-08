<template>
	<div class="addEdit-block" :style='{"padding":"30px"}'>
		<el-form
			:style='{"borderRadius":"6px","padding":"30px"}'
			class="add-update-preview"
			ref="ruleForm"
			:model="ruleForm"
			:rules="rules"
			label-width="200px"
		>
			<template >
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'" label="订单编号" prop="dingdanbianhao">
					<el-input v-model="ruleForm.dingdanbianhao" placeholder="订单编号" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-else-if="ruleForm.dingdanbianhao" label="订单编号" prop="dingdanbianhao">
					<el-input v-model="ruleForm.dingdanbianhao" placeholder="订单编号" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="药品名称" prop="yaopinmingcheng">
					<el-input v-model="ruleForm.yaopinmingcheng" placeholder="药品名称" clearable  :readonly="ro.yaopinmingcheng"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="药品名称" prop="yaopinmingcheng">
					<el-input v-model="ruleForm.yaopinmingcheng" placeholder="药品名称" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="药品类型" prop="yaopinleixing">
					<el-input v-model="ruleForm.yaopinleixing" placeholder="药品类型" clearable  :readonly="ro.yaopinleixing"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="药品类型" prop="yaopinleixing">
					<el-input v-model="ruleForm.yaopinleixing" placeholder="药品类型" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="品牌" prop="pinpai">
					<el-input v-model="ruleForm.pinpai" placeholder="品牌" clearable  :readonly="ro.pinpai"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="品牌" prop="pinpai">
					<el-input v-model="ruleForm.pinpai" placeholder="品牌" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="规格" prop="guige">
					<el-input v-model="ruleForm.guige" placeholder="规格" clearable  :readonly="ro.guige"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="规格" prop="guige">
					<el-input v-model="ruleForm.guige" placeholder="规格" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="数量" prop="shuliang">
					<el-input v-model.number="ruleForm.shuliang" placeholder="数量" clearable  :readonly="ro.shuliang"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="数量" prop="shuliang">
					<el-input v-model="ruleForm.shuliang" placeholder="数量" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="价格" prop="jiage">
					<el-input v-model.number="ruleForm.jiage" placeholder="价格" clearable  :readonly="ro.jiage"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="价格" prop="jiage">
					<el-input v-model="ruleForm.jiage" placeholder="价格" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="总价" prop="zongjia">
					<el-input v-model="zongjia" placeholder="总价" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-else-if="ruleForm.zongjia" label="总价" prop="zongjia">
					<el-input v-model="ruleForm.zongjia" placeholder="总价" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="date" v-if="type!='info'" label="购买时间" prop="goumaishijian">
					<el-date-picker
						value-format="yyyy-MM-dd HH:mm:ss"
						v-model="ruleForm.goumaishijian" 
						type="datetime"
						:readonly="ro.goumaishijian"
						placeholder="购买时间"
					></el-date-picker>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-else-if="ruleForm.goumaishijian" label="购买时间" prop="goumaishijian">
					<el-input v-model="ruleForm.goumaishijian" placeholder="购买时间" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="订单备注" prop="dingdanbeizhu">
					<el-input v-model="ruleForm.dingdanbeizhu" placeholder="订单备注" clearable  :readonly="ro.dingdanbeizhu"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="订单备注" prop="dingdanbeizhu">
					<el-input v-model="ruleForm.dingdanbeizhu" placeholder="订单备注" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="upload" v-if="type!='info' && !ro.yaopintupian" label="药品图片" prop="yaopintupian">
					<file-upload
						tip="点击上传药品图片"
						action="file/upload"
						:limit="3"
						:multiple="true"
						:fileUrls="ruleForm.yaopintupian?ruleForm.yaopintupian:''"
						@change="yaopintupianUploadChange"
					></file-upload>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="upload" v-else-if="ruleForm.yaopintupian" label="药品图片" prop="yaopintupian">
					<img v-if="ruleForm.yaopintupian.substring(0,4)=='http'" class="upload-img" style="margin-right:20px;" v-bind:key="index" :src="ruleForm.yaopintupian.split(',')[0]" width="100" height="100">
					<img v-else class="upload-img" style="margin-right:20px;" v-bind:key="index" v-for="(item,index) in ruleForm.yaopintupian.split(',')" :src="$base.url+item" width="100" height="100">
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="参保人账号" prop="canbaorenzhanghao">
					<el-input v-model="ruleForm.canbaorenzhanghao" placeholder="参保人账号" clearable  :readonly="ro.canbaorenzhanghao"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="参保人账号" prop="canbaorenzhanghao">
					<el-input v-model="ruleForm.canbaorenzhanghao" placeholder="参保人账号" readonly></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' class="input" v-if="type!='info'"  label="参保人姓名" prop="canbaorenxingming">
					<el-input v-model="ruleForm.canbaorenxingming" placeholder="参保人姓名" clearable  :readonly="ro.canbaorenxingming"></el-input>
				</el-form-item>
				<el-form-item :style='{"margin":"0 0 20px 0"}' v-else class="input" label="参保人姓名" prop="canbaorenxingming">
					<el-input v-model="ruleForm.canbaorenxingming" placeholder="参保人姓名" readonly></el-input>
				</el-form-item>
			</template>
			<el-form-item :style='{"padding":"0","margin":"0"}' class="btn">
				<el-button class="btn3"  v-if="type!='info'" type="success" @click="onSubmit">
					<span class="icon iconfont " :style='{"margin":"0 2px","fontSize":"14px","color":"#fff","height":"40px"}'></span>
					提交
				</el-button>
				<el-button class="btn4" v-if="type!='info'" type="success" @click="back()">
					<span class="icon iconfont " :style='{"margin":"0 2px","fontSize":"14px","color":"#fff","height":"40px"}'></span>
					取消
				</el-button>
				<el-button class="btn5" v-if="type=='info'" type="success" @click="back()">
					<span class="icon iconfont " :style='{"margin":"0 2px","fontSize":"14px","color":"#fff","height":"40px"}'></span>
					返回
				</el-button>
			</el-form-item>
		</el-form>
    

  </div>
</template>
<script>
// 数字，邮件，手机，url，身份证校验
import { isNumber,isIntNumer,isEmail,isPhone, isMobile,isURL,checkIdCard } from "@/utils/validate";
export default {
	data() {
		let self = this
		var validateIdCard = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!checkIdCard(value)) {
				callback(new Error("请输入正确的身份证号码"));
			} else {
				callback();
			}
		};
		var validateUrl = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isURL(value)) {
				callback(new Error("请输入正确的URL地址"));
			} else {
				callback();
			}
		};
		var validateMobile = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isMobile(value)) {
				callback(new Error("请输入正确的手机号码"));
			} else {
				callback();
			}
		};
		var validatePhone = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isPhone(value)) {
				callback(new Error("请输入正确的电话号码"));
			} else {
				callback();
			}
		};
		var validateEmail = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isEmail(value)) {
				callback(new Error("请输入正确的邮箱地址"));
			} else {
				callback();
			}
		};
		var validateNumber = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isNumber(value)) {
				callback(new Error("请输入数字"));
			} else {
				callback();
			}
		};
		var validateIntNumber = (rule, value, callback) => {
			if(!value){
				callback();
			} else if (!isIntNumer(value)) {
				callback(new Error("请输入整数"));
			} else {
				callback();
			}
		};
		return {
			id: '',
			type: '',
			
			
			ro:{
				dingdanbianhao : false,
				yaopinmingcheng : false,
				yaopinleixing : false,
				pinpai : false,
				guige : false,
				shuliang : false,
				jiage : false,
				zongjia : false,
				goumaishijian : false,
				dingdanbeizhu : false,
				yaopintupian : false,
				canbaorenzhanghao : false,
				canbaorenxingming : false,
				ispay : false,
			},
			
			
			ruleForm: {
				dingdanbianhao: this.getUUID(),
				yaopinmingcheng: '',
				yaopinleixing: '',
				pinpai: '',
				guige: '',
				shuliang: '',
				jiage: '',
				zongjia: '',
				goumaishijian: '',
				dingdanbeizhu: '',
				yaopintupian: '',
				canbaorenzhanghao: '',
				canbaorenxingming: '',
			},
		

			
			rules: {
				dingdanbianhao: [
				],
				yaopinmingcheng: [
				],
				yaopinleixing: [
				],
				pinpai: [
				],
				guige: [
				],
				shuliang: [
					{ validator: validateIntNumber, trigger: 'blur' },
				],
				jiage: [
					{ validator: validateIntNumber, trigger: 'blur' },
				],
				zongjia: [
					{ validator: validateNumber, trigger: 'blur' },
				],
				goumaishijian: [
				],
				dingdanbeizhu: [
				],
				yaopintupian: [
				],
				canbaorenzhanghao: [
				],
				canbaorenxingming: [
				],
				ispay: [
				],
			}
		};
	},
	props: ["parent"],
	computed: {


		zongjia:{
			get: function () {
				return 1*this.ruleForm.shuliang*this.ruleForm.jiage
			}
		},

	},
    components: {
    },
	created() {
		this.ruleForm.goumaishijian = this.getCurDateTime()
	},
	methods: {
		
		// 下载
		download(file){
			window.open(`${file}`)
		},
		// 初始化
		init(id,type) {
			if (id) {
				this.id = id;
				this.type = type;
			}
			if(this.type=='info'||this.type=='else'){
				this.info(id);
			}else if(this.type=='logistics'){
				this.logistics=false;
				this.info(id);
			}else if(this.type=='cross'){
				var obj = this.$storage.getObj('crossObj');
				for (var o in obj){
						if(o=='dingdanbianhao'){
							this.ruleForm.dingdanbianhao = obj[o];
							this.ro.dingdanbianhao = true;
							continue;
						}
						if(o=='yaopinmingcheng'){
							this.ruleForm.yaopinmingcheng = obj[o];
							this.ro.yaopinmingcheng = true;
							continue;
						}
						if(o=='yaopinleixing'){
							this.ruleForm.yaopinleixing = obj[o];
							this.ro.yaopinleixing = true;
							continue;
						}
						if(o=='pinpai'){
							this.ruleForm.pinpai = obj[o];
							this.ro.pinpai = true;
							continue;
						}
						if(o=='guige'){
							this.ruleForm.guige = obj[o];
							this.ro.guige = true;
							continue;
						}
						if(o=='shuliang'){
							this.ruleForm.shuliang = obj[o];
							this.ro.shuliang = true;
							continue;
						}
						if(o=='jiage'){
							this.ruleForm.jiage = obj[o];
							this.ro.jiage = true;
							continue;
						}
						if(o=='zongjia'){
							this.ruleForm.zongjia = obj[o];
							this.ro.zongjia = true;
							continue;
						}
						if(o=='goumaishijian'){
							this.ruleForm.goumaishijian = obj[o];
							this.ro.goumaishijian = true;
							continue;
						}
						if(o=='dingdanbeizhu'){
							this.ruleForm.dingdanbeizhu = obj[o];
							this.ro.dingdanbeizhu = true;
							continue;
						}
						if(o=='yaopintupian'){
							this.ruleForm.yaopintupian = obj[o];
							this.ro.yaopintupian = true;
							continue;
						}
						if(o=='canbaorenzhanghao'){
							this.ruleForm.canbaorenzhanghao = obj[o];
							this.ro.canbaorenzhanghao = true;
							continue;
						}
						if(o=='canbaorenxingming'){
							this.ruleForm.canbaorenxingming = obj[o];
							this.ro.canbaorenxingming = true;
							continue;
						}
				}
				





				this.ruleForm.shuliang = 0
				this.ro.shuliang = false;









			}
			
			// 获取用户信息
			this.$http({
				url: `${this.$storage.get('sessionTable')}/session`,
				method: "get"
			}).then(({ data }) => {
				if (data && data.code === 0) {
					
					var json = data.data;
					if(this.$storage.get("role")!="管理员") {
						this.ro.goumaishijian = true;
					}
					if(((json.canbaorenzhanghao!=''&&json.canbaorenzhanghao) || json.canbaorenzhanghao==0) && this.$storage.get("role")!="管理员"){
						this.ruleForm.canbaorenzhanghao = json.canbaorenzhanghao
						this.ro.canbaorenzhanghao = true;
					}
					if(((json.canbaorenxingming!=''&&json.canbaorenxingming) || json.canbaorenxingming==0) && this.$storage.get("role")!="管理员"){
						this.ruleForm.canbaorenxingming = json.canbaorenxingming
						this.ro.canbaorenxingming = true;
					}
				} else {
					this.$message.error(data.msg);
				}
			});
			
			
		},
    // 多级联动参数

    info(id) {
      this.$http({
        url: `yaopindingdan/info/${id}`,
        method: "get"
      }).then(({ data }) => {
        if (data && data.code === 0) {
        this.ruleForm = data.data;
        //解决前台上传图片后台不显示的问题
        let reg=new RegExp('../../../upload','g')//g代表全部
        } else {
          this.$message.error(data.msg);
        }
      });
    },


    // 提交
    onSubmit() {
		if(this.ruleForm.dingdanbianhao) {
			this.ruleForm.dingdanbianhao = String(this.ruleForm.dingdanbianhao)
		}
        this.ruleForm.zongjia = this.zongjia











	if(this.ruleForm.yaopintupian!=null) {
		this.ruleForm.yaopintupian = this.ruleForm.yaopintupian.replace(new RegExp(this.$base.url,"g"),"");
	}




var objcross = this.$storage.getObj('crossObj');
      var table = this.$storage.getObj('crossTable');
      if(objcross!=null) {
		  if(!this.ruleForm.shuliang){
			  this.$message.error("数量不能为空");
			  return
		  }
	      objcross.shuliang = objcross.shuliang - this.ruleForm.shuliang
	      if(objcross.shuliang<0){
				this.$message.error("数量不足");
				return
	      }
                }
      //更新跨表属性
       var crossuserid;
       var crossrefid;
       var crossoptnum;
       if(this.type=='cross'){
                var statusColumnName = this.$storage.get('statusColumnName');
                var statusColumnValue = this.$storage.get('statusColumnValue');
                if(statusColumnName!='') {
                        var obj = this.$storage.getObj('crossObj');
                       if(statusColumnName && !statusColumnName.startsWith("[")) {
                               for (var o in obj){
                                 if(o==statusColumnName){
                                   obj[o] = statusColumnValue;
                                 }
                               }
                               var table = this.$storage.get('crossTable');
                             this.$http({
                                 url: `${table}/update`,
                                 method: "post",
                                 data: obj
                               }).then(({ data }) => {});
                              this.$http({
                                  url: `${table}/update`,
                                  method: "post",
                                  data: objcross
                                }).then(({ data }) => {});
                       } else {
                               crossuserid=this.$storage.get('userid');
                               crossrefid=obj['id'];
                               crossoptnum=this.$storage.get('statusColumnName');
                               crossoptnum=crossoptnum.replace(/\[/,"").replace(/\]/,"");
                        }
                }
        }
		this.$refs["ruleForm"].validate(valid => {
			if (valid) {
				if(crossrefid && crossuserid) {
					this.ruleForm.crossuserid = crossuserid;
					this.ruleForm.crossrefid = crossrefid;
					let params = { 
						page: 1, 
						limit: 10, 
						crossuserid:this.ruleForm.crossuserid,
						crossrefid:this.ruleForm.crossrefid,
					} 
				this.$http({ 
					url: "yaopindingdan/page", 
					method: "get", 
					params: params 
				}).then(({ 
					data 
				}) => { 
					if (data && data.code === 0) { 
						if(data.data.total>=crossoptnum) {
							this.$message.error(this.$storage.get('tips'));
							return false;
						} else {
							this.$http({
								url: `yaopindingdan/${!this.ruleForm.id ? "save" : "update"}`,
								method: "post",
								data: this.ruleForm
							}).then(({ data }) => {
								if (data && data.code === 0) {
									this.$message({
										message: "操作成功",
										type: "success",
										duration: 1500,
										onClose: () => {
											this.parent.showFlag = true;
											this.parent.addOrUpdateFlag = false;
											this.parent.yaopindingdanCrossAddOrUpdateFlag = false;
											this.parent.search();
											this.parent.contentStyleChange();
										}
									});
									this.$http({
										url: `${table}/update`,
										method: "post",
										data: objcross
									}).then(({ data }) => {});
								} else {
									this.$message.error(data.msg);
								}
							});

						}
					} else { 
				} 
			});
		} else {
			this.$http({
				url: `yaopindingdan/${!this.ruleForm.id ? "save" : "update"}`,
				method: "post",
			   data: this.ruleForm
			}).then(({ data }) => {
				if (data && data.code === 0) {
					this.$http({
						url: `${table}/update`,
						method: "post",
						data: objcross
					}).then(({ data }) => {});
					this.$message({
						message: "操作成功",
						type: "success",
						duration: 1500,
						onClose: () => {
							this.parent.showFlag = true;
							this.parent.addOrUpdateFlag = false;
							this.parent.yaopindingdanCrossAddOrUpdateFlag = false;
							this.parent.search();
							this.parent.contentStyleChange();
						}
					});
				} else {
					this.$message.error(data.msg);
			   }
			});
		 }
         }
       });
    },
    // 获取uuid
    getUUID () {
      return new Date().getTime();
    },
    // 返回
    back() {
      this.parent.showFlag = true;
      this.parent.addOrUpdateFlag = false;
      this.parent.yaopindingdanCrossAddOrUpdateFlag = false;
      this.parent.contentStyleChange();
    },
    yaopintupianUploadChange(fileUrls) {
	    this.ruleForm.yaopintupian = fileUrls;
    },
  }
};
</script>
<style lang="scss" scoped>
	.amap-wrapper {
		width: 100%;
		height: 500px;
	}
	
	.search-box {
		position: absolute;
	}
	
	.el-date-editor.el-input {
		width: auto;
	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__label {
	  	  padding: 0 10px 0 0;
	  	  color: #666;
	  	  font-weight: 500;
	  	  width: 200px;
	  	  font-size: 14px;
	  	  line-height: 40px;
	  	  text-align: right;
	  	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__content {
	  margin-left: 200px;
	}
	
	.add-update-preview .el-input /deep/ .el-input__inner {
	  	  border: 1px solid #eee;
	  	  border-radius: 4px;
	  	  padding: 0 12px;
	  	  color: #333;
	  	  width: 400px;
	  	  font-size: 14px;
	  	  height: 40px;
	  	}
	.add-update-preview .el-input-number /deep/ .el-input__inner {
		text-align: left;
	  	  border: 1px solid #eee;
	  	  border-radius: 4px;
	  	  padding: 0 12px;
	  	  color: #333;
	  	  width: 400px;
	  	  font-size: 14px;
	  	  height: 40px;
	  	}
	.add-update-preview .el-input-number /deep/ .el-input-number__decrease {
		display: none;
	}
	.add-update-preview .el-input-number /deep/ .el-input-number__increase {
		display: none;
	}
	
	.add-update-preview .el-select /deep/ .el-input__inner {
	  	  border: 1px solid #eee;
	  	  border-radius: 4px;
	  	  padding: 0 10px;
	  	  outline: none;
	  	  color: #333;
	  	  width: 200px;
	  	  font-size: 14px;
	  	  height: 40px;
	  	}
	
	.add-update-preview .el-date-editor /deep/ .el-input__inner {
	  	  border: 1px solid #eee;
	  	  border-radius: 4px;
	  	  padding: 0 10px 0 30px;
	  	  outline: none;
	  	  color: #333;
	  	  width: 200px;
	  	  font-size: 14px;
	  	  height: 40px;
	  	}
	
	.add-update-preview /deep/ .el-upload--picture-card {
		background: transparent;
		border: 0;
		border-radius: 0;
		width: auto;
		height: auto;
		line-height: initial;
		vertical-align: middle;
	}
	
	.add-update-preview /deep/ .upload .upload-img {
	  	  border: 1px solid #eee;
	  	  cursor: pointer;
	  	  border-radius: 6px;
	  	  color: #333;
	  	  object-fit: cover;
	  	  width: 140px;
	  	  font-size: 32px;
	  	  line-height: 120px;
	  	  text-align: center;
	  	  height: 120px;
	  	}
	
	.add-update-preview /deep/ .el-upload-list .el-upload-list__item {
	  	  border: 1px solid #eee;
	  	  cursor: pointer;
	  	  border-radius: 6px;
	  	  color: #333;
	  	  object-fit: cover;
	  	  width: 140px;
	  	  font-size: 32px;
	  	  line-height: 120px;
	  	  text-align: center;
	  	  height: 120px;
	  	}
	
	.add-update-preview /deep/ .el-upload .el-icon-plus {
	  	  border: 1px solid #eee;
	  	  cursor: pointer;
	  	  border-radius: 6px;
	  	  color: #333;
	  	  object-fit: cover;
	  	  width: 140px;
	  	  font-size: 32px;
	  	  line-height: 120px;
	  	  text-align: center;
	  	  height: 120px;
	  	}
	
	.add-update-preview .el-textarea /deep/ .el-textarea__inner {
	  	  border: 1px solid #eee;
	  	  border-radius: 4px;
	  	  padding: 12px;
	  	  outline: none;
	  	  color: #333;
	  	  width: 400px;
	  	  font-size: 14px;
	  	  height: 120px;
	  	}
	
	.add-update-preview .btn .btn1 {
				border: 0;
				cursor: pointer;
				border-radius: 4px;
				padding: 0 24px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: rgba(44, 55, 66, 0.8);
				width: auto;
				font-size: 14px;
				height: 40px;
			}
	
	.add-update-preview .btn .btn1:hover {
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn2 {
				border: 0;
				cursor: pointer;
				border-radius: 4px;
				padding: 0 24px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: rgba(44, 55, 66, 0.8);
				width: auto;
				font-size: 14px;
				height: 40px;
			}
	
	.add-update-preview .btn .btn2:hover {
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn3 {
				border: 0;
				cursor: pointer;
				border-radius: 4px;
				padding: 0 24px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: rgba(44, 55, 66, 0.8);
				width: auto;
				font-size: 14px;
				height: 40px;
			}
	
	.add-update-preview .btn .btn3:hover {
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn4 {
				border: 0;
				cursor: pointer;
				border-radius: 4px;
				padding: 0 24px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: rgba(44, 55, 66, 0.8);
				width: auto;
				font-size: 14px;
				height: 40px;
			}
	
	.add-update-preview .btn .btn4:hover {
				opacity: 0.8;
			}
	
	.add-update-preview .btn .btn5 {
				border: 0;
				cursor: pointer;
				border-radius: 4px;
				padding: 0 24px;
				margin: 4px;
				outline: none;
				color: #fff;
				background: rgba(44, 55, 66, 0.8);
				width: auto;
				font-size: 14px;
				height: 40px;
			}
	
	.add-update-preview .btn .btn5:hover {
				opacity: 0.8;
			}
</style>

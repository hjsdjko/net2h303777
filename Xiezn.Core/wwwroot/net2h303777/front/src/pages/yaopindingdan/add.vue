<template>
<div :style='{"width":"100%","padding":"30px 7% 40px","margin":"0px auto","position":"relative","background":"#fff"}'>
    <el-form
	  :style='{"border":"1px solid #f0f0f0","width":"100%","padding":"30px 20%","position":"relative","background":"#fcfcfc"}'
      class="add-update-preview"
      ref="ruleForm"
      :model="ruleForm"
      :rules="rules"
      label-width="80px"
    >
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="订单编号" prop="dingdanbianhao">
              <el-input v-model="ruleForm.dingdanbianhao" placeholder="订单编号" disabled></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="药品名称" prop="yaopinmingcheng">
            <el-input v-model="ruleForm.yaopinmingcheng" 
                placeholder="药品名称" clearable :disabled=" false  ||ro.yaopinmingcheng"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="药品类型" prop="yaopinleixing">
            <el-input v-model="ruleForm.yaopinleixing" 
                placeholder="药品类型" clearable :disabled=" false  ||ro.yaopinleixing"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="品牌" prop="pinpai">
            <el-input v-model="ruleForm.pinpai" 
                placeholder="品牌" clearable :disabled=" false  ||ro.pinpai"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="规格" prop="guige">
            <el-input v-model="ruleForm.guige" 
                placeholder="规格" clearable :disabled=" false  ||ro.guige"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="数量" prop="shuliang">
            <el-input v-model.number="ruleForm.shuliang" 
                placeholder="数量" clearable :disabled=" false  ||ro.shuliang"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="价格" prop="jiage">
            <el-input v-model.number="ruleForm.jiage" 
                placeholder="价格" clearable :disabled=" false  ||ro.jiage"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="总价" prop="zongjia">
              <el-input v-model="zongjia" placeholder="总价" disabled></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="购买时间" prop="goumaishijian">
              <el-date-picker
				  :disabled="true  ||ro.goumaishijian"
                  value-format="yyyy-MM-dd HH:mm:ss"
                  v-model="ruleForm.goumaishijian" 
                  type="datetime"
                  placeholder="购买时间">
              </el-date-picker>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="订单备注" prop="dingdanbeizhu">
            <el-input v-model="ruleForm.dingdanbeizhu" 
                placeholder="订单备注" clearable :disabled=" false  ||ro.dingdanbeizhu"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="药品图片" v-if="type!='cross' || (type=='cross' && !ro.yaopintupian)" prop="yaopintupian">
            <file-upload
            tip="点击上传药品图片"
            action="file/upload"
            :limit="3"
            :multiple="true"
            :fileUrls="ruleForm.yaopintupian?ruleForm.yaopintupian:''"
            @change="yaopintupianUploadChange"
            ></file-upload>
          </el-form-item>
            <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' class="upload" v-else label="药品图片" prop="yaopintupian">
                <img v-if="ruleForm.yaopintupian.substring(0,4)=='http'" class="upload-img" style="margin-right:20px;" v-bind:key="index" :src="ruleForm.yaopintupian.split(',')[0]" width="100" height="100">
                <img v-else class="upload-img" style="margin-right:20px;" v-bind:key="index" v-for="(item,index) in ruleForm.yaopintupian.split(',')" :src="baseUrl+item" width="100" height="100">
            </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="参保人账号" prop="canbaorenzhanghao">
            <el-input v-model="ruleForm.canbaorenzhanghao" 
                placeholder="参保人账号" clearable :disabled=" false  ||ro.canbaorenzhanghao"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="参保人姓名" prop="canbaorenxingming">
            <el-input v-model="ruleForm.canbaorenxingming" 
                placeholder="参保人姓名" clearable :disabled=" false  ||ro.canbaorenxingming"></el-input>
          </el-form-item>

      <el-form-item :style='{"padding":"0","textAlign":"center","margin":"0"}'>
        <el-button :style='{"border":"0","cursor":"pointer","padding":"0","margin":"0 20px 0 0","outline":"none","color":"rgba(255, 255, 255, 1)","borderRadius":"0px","background":"#1abc9e","width":"128px","lineHeight":"40px","fontSize":"14px","height":"40px"}'  type="primary" @click="onSubmit">提交</el-button>
        <el-button :style='{"border":"1px solid #eee","cursor":"pointer","padding":"0","margin":"0","outline":"none","color":"#333","borderRadius":"0px","background":"#fcfcfc","width":"128px","lineHeight":"40px","fontSize":"14px","height":"40px"}' @click="back()">返回</el-button>
      </el-form-item>
    </el-form>
</div>
</template>

<script>
  export default {
    data() {
	  let self = this
      return {
        id: '',
        baseUrl: '',
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
        type: '',
        userTableName: localStorage.getItem('UserTableName'),
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
          ispay: '',
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
            { validator: this.$validate.isIntNumer, trigger: 'blur' },
          ],
          jiage: [
            { validator: this.$validate.isIntNumer, trigger: 'blur' },
          ],
          zongjia: [
            { validator: this.$validate.isNumber, trigger: 'blur' },
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
        },
		centerType: false,
      };
    },
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
		if(this.$route.query.centerType){
			this.centerType = true
		}
	  //this.bg();
      let type = this.$route.query.type ? this.$route.query.type : '';
      this.init(type);
      this.baseUrl = this.$config.baseUrl;
      this.ruleForm.goumaishijian = this.getCurDateTime()
    },
    methods: {
      getMakeZero(s) {
          return s < 10 ? '0' + s : s;
      },
      // 下载
      download(file){
        window.open(`${file}`)
      },
      // 初始化
      init(type) {
        this.type = type;
        if(type=='cross'){
          var obj = JSON.parse(localStorage.getItem('crossObj'));
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
              this.ruleForm.yaopintupian = obj[o].split(",")[0];
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
        }else if(type=='edit'){
			this.info()
		}
        // 获取用户信息
        this.$http.get(this.userTableName + '/session', {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            var json = res.data.data;
            if((json.canbaorenzhanghao!=''&&json.canbaorenzhanghao) || json.canbaorenzhanghao==0){
                this.ruleForm.canbaorenzhanghao = json.canbaorenzhanghao            }
            if((json.canbaorenxingming!=''&&json.canbaorenxingming) || json.canbaorenxingming==0){
                this.ruleForm.canbaorenxingming = json.canbaorenxingming            }
          }
        });

		if (localStorage.getItem('raffleType') && localStorage.getItem('raffleType') != null) {
			localStorage.removeItem('raffleType')
			setTimeout(() => {
				this.onSubmit()
			}, 300)
		}
      },

    // 多级联动参数
      // 多级联动参数
      info() {
        this.$http.get(`yaopindingdan/detail/${this.$route.query.id}`, {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            this.ruleForm = res.data.data;
          }
        });
      },
      // 提交
      onSubmit() {

			if(this.ruleForm.dingdanbianhao){
				this.ruleForm.dingdanbianhao = String(this.ruleForm.dingdanbianhao)
			}
			this.ruleForm.zongjia = this.zongjia
			if(!this.ruleForm.shuliang){
				this.$message.error("数量不能为空");
				return
			}
			var obj = JSON.parse(localStorage.getItem('crossObj'));
			var table = localStorage.getItem('crossTable');
			obj.shuliang = obj.shuliang - this.ruleForm.shuliang
			if(obj.shuliang<0){
				this.$message.error("数量不足");
				return
			}
      
			//this.$http.post(table+`/update`, obj).then(res => {});
			//更新跨表属性
			var crossuserid;
			var crossrefid;
			var crossoptnum;
			this.$refs["ruleForm"].validate(valid => {
				if(valid) {
					if(this.type=='cross'){
						var statusColumnName = localStorage.getItem('statusColumnName');
						var statusColumnValue = localStorage.getItem('statusColumnValue');
						if(statusColumnName && statusColumnName!='') {
							var obj = JSON.parse(localStorage.getItem('crossObj'));
							if(!statusColumnName.startsWith("[")) {
								for (var o in obj){
									if(o==statusColumnName){
										obj[o] = statusColumnValue;
									}
								}
								var table = localStorage.getItem('crossTable');
								this.$http.post(table+'/update', obj).then(res => {});
							} else {
								crossuserid=Number(localStorage.getItem('frontUserid'));
								crossrefid=obj['id'];
								crossoptnum=localStorage.getItem('statusColumnName');
								crossoptnum=crossoptnum.replace(/\[/,"").replace(/\]/,"");
							}
						}
					}
					if(crossrefid && crossuserid) {
						this.ruleForm.crossuserid=crossuserid;
						this.ruleForm.crossrefid=crossrefid;
						var params = {
							page: 1,
							limit: 10,
							crossuserid:crossuserid,
							crossrefid:crossrefid,
						}
						this.$http.get('yaopindingdan/list', {
							params: params
						}).then(res => {
							if(res.data.data.total>=crossoptnum) {
								this.$message({
									message: localStorage.getItem('tips'),
									type: 'error',
									duration: 1500,
								});
								return false;
							} else {
								// 跨表计算
								var obj = JSON.parse(localStorage.getItem('crossObj'));
								var table = localStorage.getItem('crossTable');

								obj.shuliang = parseFloat(obj.shuliang) - parseFloat(this.ruleForm.shuliang)

								this.$http.post(table+`/update`,obj).then(res => {});
								this.$http.post(`yaopindingdan/${this.ruleForm.id?'update':this.centerType?'save':'add'}`, this.ruleForm).then(res => {
									if (res.data.code == 0) {
										this.$message({
											message: '操作成功',
											type: 'success',
											duration: 1500,
											onClose: () => {
												this.$router.go(-1);
											}
										});
									} else {
										this.$message({
											message: res.data.msg,
											type: 'error',
											duration: 1500
										});
									}
								});
							}
						});
					} else {
						var obj = JSON.parse(localStorage.getItem('crossObj'));
						var table = localStorage.getItem('crossTable');

						obj.shuliang = parseFloat(obj.shuliang) - parseFloat(this.ruleForm.shuliang)

						this.$http.post(table+`/update`,obj).then(res => {});
						this.$http.post(`yaopindingdan/${this.ruleForm.id?'update':this.centerType?'save':'add'}`, this.ruleForm).then(res => {
							if (res.data.code == 0) {
								this.$message({
									message: '操作成功',
									type: 'success',
									duration: 1500,
									onClose: () => {
										this.$router.go(-1);
									}
								});
							} else {
								this.$message({
									message: res.data.msg,
									type: 'error',
									duration: 1500
								});
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
			this.$router.go(-1);
		},
      yaopintupianUploadChange(fileUrls) {
          this.ruleForm.yaopintupian = fileUrls.replace(new RegExp(this.$config.baseUrl,"g"),"");
      },
    }
  };
</script>

<style rel="stylesheet/scss" lang="scss" scoped>
	.el-date-editor.el-input {
		width: auto;
	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__label {
	  padding: 0 10px 0 0;
	  color: #666;
	  font-weight: 500;
	  width: 80px;
	  font-size: 14px;
	  line-height: 40px;
	  text-align: right;
	}
	
	.add-update-preview .el-form-item /deep/ .el-form-item__content {
	  margin-left: 80px;
	}
	
	.add-update-preview .el-input /deep/ .el-input__inner {
	  border: 1px solid #ddd;
	  padding: 0 12px;
	  color: #666;
	  font-size: 14px;
	  border-color: #1abc9e30;
	  border-radius: 0px;
	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  outline: none;
	  background: none;
	  width: 400px;
	  border-width: 0 0 1px;
	  border-style: solid;
	  height: 40px;
	}
	.add-update-preview .el-input-number /deep/ .el-input__inner {
		text-align: left;
	  border: 1px solid #ddd;
	  padding: 0 12px;
	  color: #666;
	  font-size: 14px;
	  border-color: #1abc9e30;
	  border-radius: 0px;
	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  outline: none;
	  background: none;
	  width: 400px;
	  border-width: 0 0 1px;
	  border-style: solid;
	  height: 40px;
	}
	.add-update-preview .el-input-number /deep/ .el-input-number__decrease {
		display: none;
	}
	.add-update-preview .el-input-number /deep/ .el-input-number__increase {
		display: none;
	}
	
	.add-update-preview .el-select /deep/ .el-input__inner {
	  border-radius: 0px;
	  padding: 0 10px;
	  color: #666;
	  background: none;
	  width: 200px;
	  font-size: 14px;
	  border-color: #1abc9e30;
	  border-width: 0 0 1px;
	  border-style: solid;
	  height: 40px;
	}
	
	.add-update-preview .el-date-editor /deep/ .el-input__inner {
	  border-radius: 0px;
	  padding: 0 10px 0 30px;
	  color: #666;
	  background: none;
	  width: 200px;
	  font-size: 14px;
	  border-color: #1abc9e30;
	  border-width: 0 0 1px;
	  border-style: solid;
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
	  cursor: pointer;
	  border-radius: 0px;
	  color: #1abc9e60;
	  background: none;
	  width: 200px;
	  font-size: 32px;
	  border-color: #1abc9e30;
	  border-width: 0 0 1px;
	  line-height: 100px;
	  border-style: solid;
	  text-align: center;
	  height: 100px;
	}
	
	.add-update-preview /deep/ .el-upload-list .el-upload-list__item {
	  cursor: pointer;
	  border-radius: 0px;
	  color: #1abc9e60;
	  background: none;
	  width: 200px;
	  font-size: 32px;
	  border-color: #1abc9e30;
	  border-width: 0 0 1px;
	  line-height: 100px;
	  border-style: solid;
	  text-align: center;
	  height: 100px;
	}
	
	.add-update-preview /deep/ .el-upload .el-icon-plus {
	  cursor: pointer;
	  border-radius: 0px;
	  color: #1abc9e60;
	  background: none;
	  width: 200px;
	  font-size: 32px;
	  border-color: #1abc9e30;
	  border-width: 0 0 1px;
	  line-height: 100px;
	  border-style: solid;
	  text-align: center;
	  height: 100px;
	}
	
	.add-update-preview .el-textarea /deep/ .el-textarea__inner {
	  border: 1px solid #1abc9e30;
	  border-radius: 0px;
	  padding: 12px;
	  box-shadow: 0 0 0px rgba(64, 158, 255, .5);
	  outline: none;
	  color: #666;
	  background: none;
	  width: 400px;
	  font-size: 14px;
	  height: 120px;
	}
</style>

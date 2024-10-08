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
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="费用编号" prop="feiyongbianhao">
            <el-input v-model="ruleForm.feiyongbianhao" 
                placeholder="费用编号" clearable :disabled=" false  ||ro.feiyongbianhao"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="费用类型" prop="feiyongleixing">
            <el-input v-model="ruleForm.feiyongleixing" 
                placeholder="费用类型" clearable :disabled=" false  ||ro.feiyongleixing"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="费用金额" prop="feiyongjine">
            <el-input v-model.number="ruleForm.feiyongjine" 
                placeholder="费用金额" clearable :disabled=" false  ||ro.feiyongjine"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="费用折扣" prop="feiyongzhekou">
            <el-input v-model.number="ruleForm.feiyongzhekou" 
                placeholder="费用折扣" clearable :disabled=" false  ||ro.feiyongzhekou"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="应付金额" prop="yingfujine">
              <el-input v-model="yingfujine" placeholder="应付金额" disabled></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="结算日期" prop="jiesuanriqi">
              <el-date-picker
				  :disabled=" false  ||ro.jiesuanriqi"
                  format="yyyy 年 MM 月 dd 日"
                  value-format="yyyy-MM-dd"
                  v-model="ruleForm.jiesuanriqi" 
                  type="date"
                  placeholder="结算日期">
              </el-date-picker> 
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="参保人账号" prop="canbaorenzhanghao">
            <el-select  @change="canbaorenzhanghaoChange" v-model="ruleForm.canbaorenzhanghao" placeholder="请选择参保人账号">
              <el-option
                  v-for="(item,index) in canbaorenzhanghaoOptions"
                  :key="index"
                  :label="item"
                  :value="item">
              </el-option>
            </el-select>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="参保人姓名" prop="canbaorenxingming">
            <el-input v-model="ruleForm.canbaorenxingming" 
                placeholder="参保人姓名" clearable :disabled=" false  ||ro.canbaorenxingming"></el-input>
          </el-form-item>
          <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' label="头像" v-if="type!='cross' || (type=='cross' && !ro.touxiang)" prop="touxiang">
            <file-upload
            tip="点击上传头像"
            action="file/upload"
            :limit="3"
            :multiple="true"
            :fileUrls="ruleForm.touxiang?ruleForm.touxiang:''"
            @change="touxiangUploadChange"
            ></file-upload>
          </el-form-item>
            <el-form-item :style='{"padding":"10px","margin":"0 0 10px","background":"none"}' class="upload" v-else label="头像" prop="touxiang">
                <img v-if="ruleForm.touxiang.substring(0,4)=='http'" class="upload-img" style="margin-right:20px;" v-bind:key="index" :src="ruleForm.touxiang.split(',')[0]" width="100" height="100">
                <img v-else class="upload-img" style="margin-right:20px;" v-bind:key="index" v-for="(item,index) in ruleForm.touxiang.split(',')" :src="baseUrl+item" width="100" height="100">
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
				feiyongbianhao : false,
				feiyongleixing : false,
				feiyongjine : false,
				feiyongzhekou : false,
				yingfujine : false,
				jiesuanriqi : false,
				canbaorenzhanghao : false,
				canbaorenxingming : false,
				touxiang : false,
				ispay : false,
        },
        type: '',
        userTableName: localStorage.getItem('UserTableName'),
        ruleForm: {
          feiyongbianhao: '',
          feiyongleixing: '',
          feiyongjine: '',
          feiyongzhekou: '',
          yingfujine: '',
          jiesuanriqi: '',
          canbaorenzhanghao: '',
          canbaorenxingming: '',
          touxiang: '',
          ispay: '',
        },
        canbaorenzhanghaoOptions: [],


        rules: {
          feiyongbianhao: [
          ],
          feiyongleixing: [
          ],
          feiyongjine: [
            { validator: this.$validate.isIntNumer, trigger: 'blur' },
          ],
          feiyongzhekou: [
            { validator: this.$validate.isIntNumer, trigger: 'blur' },
          ],
          yingfujine: [
            { validator: this.$validate.isNumber, trigger: 'blur' },
          ],
          jiesuanriqi: [
          ],
          canbaorenzhanghao: [
          ],
          canbaorenxingming: [
          ],
          touxiang: [
          ],
          ispay: [
          ],
        },
		centerType: false,
      };
    },
    computed: {
        yingfujine: {
            get: function () {
                return 0+parseFloat(this.ruleForm.feiyongjine==""?0:this.ruleForm.feiyongjine)-parseFloat(this.ruleForm.feiyongzhekou==""?0:this.ruleForm.feiyongzhekou) || 0
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
      this.ruleForm.jiesuanriqi = this.getCurDate()
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
            if(o=='feiyongbianhao'){
              this.ruleForm.feiyongbianhao = obj[o];
              this.ro.feiyongbianhao = true;
              continue;
            }
            if(o=='feiyongleixing'){
              this.ruleForm.feiyongleixing = obj[o];
              this.ro.feiyongleixing = true;
              continue;
            }
            if(o=='feiyongjine'){
              this.ruleForm.feiyongjine = obj[o];
              this.ro.feiyongjine = true;
              continue;
            }
            if(o=='feiyongzhekou'){
              this.ruleForm.feiyongzhekou = obj[o];
              this.ro.feiyongzhekou = true;
              continue;
            }
            if(o=='yingfujine'){
              this.ruleForm.yingfujine = obj[o];
              this.ro.yingfujine = true;
              continue;
            }
            if(o=='jiesuanriqi'){
              this.ruleForm.jiesuanriqi = obj[o];
              this.ro.jiesuanriqi = true;
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
            if(o=='touxiang'){
              this.ruleForm.touxiang = obj[o].split(",")[0];
              this.ro.touxiang = true;
              continue;
            }
          }
        }else if(type=='edit'){
			this.info()
		}
        // 获取用户信息
        this.$http.get(this.userTableName + '/session', {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            var json = res.data.data;
          }
        });
        this.$http.get('option/canbaoren/canbaorenzhanghao', {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            this.canbaorenzhanghaoOptions = res.data.data;
          }
        });

		if (localStorage.getItem('raffleType') && localStorage.getItem('raffleType') != null) {
			localStorage.removeItem('raffleType')
			setTimeout(() => {
				this.onSubmit()
			}, 300)
		}
      },
      // 下二随
      canbaorenzhanghaoChange () {
        this.$http.get('follow/canbaoren/canbaorenzhanghao?columnValue=' + this.ruleForm.canbaorenzhanghao, {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            if(res.data.data.canbaorenxingming){
              this.ruleForm.canbaorenxingming = res.data.data.canbaorenxingming
            }
          }
        });
      },

    // 多级联动参数
      // 多级联动参数
      info() {
        this.$http.get(`yiliaofeiyongjiesuan/detail/${this.$route.query.id}`, {emulateJSON: true}).then(res => {
          if (res.data.code == 0) {
            this.ruleForm = res.data.data;
          }
        });
      },
      // 提交
      onSubmit() {

			this.ruleForm.yingfujine = this.yingfujine
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
						this.$http.get('yiliaofeiyongjiesuan/list', {
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


								this.$http.post(`yiliaofeiyongjiesuan/${this.ruleForm.id?'update':this.centerType?'save':'add'}`, this.ruleForm).then(res => {
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


						this.$http.post(`yiliaofeiyongjiesuan/${this.ruleForm.id?'update':this.centerType?'save':'add'}`, this.ruleForm).then(res => {
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
      touxiangUploadChange(fileUrls) {
          this.ruleForm.touxiang = fileUrls.replace(new RegExp(this.$config.baseUrl,"g"),"");
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

<template>
	<div>

	<div class="container" :style='{"minHeight":"100vh","alignItems":"center","background":"url(http://codegen.caihongy.cn/20230922/735087380ee74ae5b7d67094b120ecee.jpg)","display":"flex","width":"100%","backgroundSize":"cover","backgroundPosition":"center center","backgroundRepeat":"no-repeat","justifyContent":"center"}'>
		<el-form class='rgs-form' v-if="pageFlag=='register'" :style='{"padding":"20px 0","margin":"120px auto 60px","borderRadius":"12px","background":"#fff","width":"35vw","position":"relative","height":"auto"}' ref="registerForm" :model="registerForm" :rules="rules">
			<div v-if="false" :style='{"width":"100%","margin":"0 0 10px 0","lineHeight":"44px","fontSize":"20px","color":"rgba(64, 158, 255, 1)","textAlign":"center"}'>USER / REGISTER</div>
			<div v-if="true" :style='{"margin":"20px auto 10px","color":"#fff","top":"-110px","textAlign":"center","width":"100%","letterSpacing":"2px","lineHeight":"44px","fontSize":"32px","position":"absolute"}'>基于. NET的医院医保管理系统注册</p></div>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="canbaorenzhanghao">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('canbaorenzhanghao')?'required':''">参保人账号：</div>
				<el-input v-model="registerForm.canbaorenzhanghao"  placeholder="请输入参保人账号" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="mima">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('mima')?'required':''">密码：</div>
				<el-input v-model="registerForm.mima" type="password" placeholder="请输入密码" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="mima2">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('mima')?'required':''">确认密码：</div>
				<el-input v-model="registerForm.mima2" type="password" placeholder="请再次输入密码" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="canbaorenxingming">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('canbaorenxingming')?'required':''">参保人姓名：</div>
				<el-input v-model="registerForm.canbaorenxingming"  placeholder="请输入参保人姓名" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="xingbie">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('xingbie')?'required':''">性别：</div>
                <el-select v-model="registerForm.xingbie" placeholder="请选择性别" >
                  <el-option
                      v-for="(item,index) in canbaorenxingbieOptions"
                      :key="index"
                      :label="item"
                      :value="item">
                  </el-option>
                </el-select>
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="nianling">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('nianling')?'required':''">年龄：</div>
				<el-input v-model.number="registerForm.nianling"  placeholder="请输入年龄" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="shenfenzheng">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('shenfenzheng')?'required':''">身份证：</div>
				<el-input v-model="registerForm.shenfenzheng"  placeholder="请输入身份证" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="lianxidianhua">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('lianxidianhua')?'required':''">联系电话：</div>
				<el-input v-model="registerForm.lianxidianhua"  placeholder="请输入联系电话" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="lianxidizhi">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('lianxidizhi')?'required':''">联系地址：</div>
				<el-input v-model="registerForm.lianxidizhi"  placeholder="请输入联系地址" />
			</el-form-item>
			<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 15px","height":"auto"}' v-if="tableName=='canbaoren'" prop="touxiang">
				<div v-if="true" :style='{"padding":"0 10px","color":"#333","textAlign":"right","background":"none","width":"130px","lineHeight":"36px","fontSize":"14px","minWidth":"80px"}' :class="changeRules('touxiang')?'required':''">头像：</div>
                <file-upload
					tip="点击上传头像"
					action="file/upload"
					:limit="1"
					:multiple="true"
					:fileUrls="registerForm.touxiang?registerForm.touxiang:''"
					@change="canbaorentouxiangUploadChange"
				></file-upload>
			</el-form-item>
			<el-button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"20px auto 5px","outline":"none","color":"#fff","borderRadius":"4px","background":"#1abc9e","display":"block","width":"80%","fontSize":"16px","height":"44px"}' type="primary" @click="submitForm('registerForm')">注册</el-button>
			<el-button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"0px auto 0px","color":"#666","textAlign":"right","display":"block","outline":"none","borderRadius":"8px","background":"none","width":"80%","fontSize":"16px","height":"44px"}' @click="resetForm('registerForm')">重置</el-button>
			<router-link :style='{"cursor":"pointer","padding":"0 10%","margin":"0 0 40px","color":"rgba(159, 159, 159, 1)","display":"inline-block","lineHeight":"1","fontSize":"14px","textDecoration":"none"}' to="/login">已有账户登录</router-link>
			<div class="idea1" :style='{"width":"100%","background":"red","display":"none","height":"40px"}'></div>
			<div class="idea2" :style='{"width":"100%","background":"blue","display":"none","height":"40px"}'></div>
		</el-form>
    </div>
  </div>
</div>
</template>

<script>

export default {
    //数据集合
    data() {
		return {
            pageFlag : '',
			tableName: '',
			registerForm: {},
			forgetForm: {},
			rules: {},
			requiredRules: {},
            canbaorenxingbieOptions: [],
		}
    },
	mounted() {
		if(this.$route.query.pageFlag=='register'){
			this.tableName = this.$route.query.role;
			if(this.tableName=='canbaoren'){
				this.registerForm = {
					canbaorenzhanghao: '',
					mima: '',
					mima2: '',
					canbaorenxingming: '',
					xingbie: '',
					nianling: '',
					shenfenzheng: '',
					lianxidianhua: '',
					lianxidizhi: '',
					touxiang: '',
				}
			}
			if ('canbaoren' == this.tableName) {
				this.requiredRules.canbaorenzhanghao = [{ required: true, message: '请输入参保人账号', trigger: 'blur' }]
			}
			if ('canbaoren' == this.tableName) {
				this.requiredRules.mima = [{ required: true, message: '请输入密码', trigger: 'blur' }]
			}
			if ('canbaoren' == this.tableName) {
				this.requiredRules.canbaorenxingming = [{ required: true, message: '请输入参保人姓名', trigger: 'blur' }]
			}
		}
	},
    created() {
		this.pageFlag = this.$route.query.pageFlag;
		if(this.$route.query.pageFlag=='register'){
		  if ('canbaoren' == this.tableName) {
			this.rules.canbaorenzhanghao = [{ required: true, message: '请输入参保人账号', trigger: 'blur' }];
		  }
		  if ('canbaoren' == this.tableName) {
			this.rules.mima = [{ required: true, message: '请输入密码', trigger: 'blur' }];
		  }
		  if ('canbaoren' == this.tableName) {
			this.rules.canbaorenxingming = [{ required: true, message: '请输入参保人姓名', trigger: 'blur' }];
		  }
			this.canbaorenxingbieOptions = "男,女".split(',');
		  if ('canbaoren' == this.tableName) {
			this.rules.nianling = [{ required: true, validator: this.$validate.isIntNumer, trigger: 'blur' }];
		  }
		  if ('canbaoren' == this.tableName) {
			this.rules.shenfenzheng = [{ required: true, validator: this.$validate.isIdCard, trigger: 'blur' }];
		  }
		  if ('canbaoren' == this.tableName) {
			this.rules.lianxidianhua = [{ required: true, validator: this.$validate.isMobile, trigger: 'blur' }];
		  }
		}
    },
    //方法集合
    methods: {
		changeRules(name){
			if(this.requiredRules[name]){
				return true
			}
			return false
		},
      // 获取uuid
      getUUID () {
        return new Date().getTime();
      },
        // 下二随
      canbaorentouxiangUploadChange(fileUrls) {
          this.registerForm.touxiang = fileUrls.replace(new RegExp(this.$config.baseUrl,"g"),"");
      },

        // 多级联动参数


      submitForm(formName) {
        this.$refs[formName].validate((valid) => {
          if (valid) {
            var url=this.tableName+"/register";
				if((!this.registerForm.canbaorenzhanghao) && `canbaoren` == this.tableName){
					this.$message.error(`参保人账号不能为空`);
					return
				}
               if(`canbaoren` == this.tableName && this.registerForm.mima!=this.registerForm.mima2) {
                this.$message.error(`两次密码输入不一致`);
                return
               }
				if((!this.registerForm.mima) && `canbaoren` == this.tableName){
					this.$message.error(`密码不能为空`);
					return
				}
				if((!this.registerForm.canbaorenxingming) && `canbaoren` == this.tableName){
					this.$message.error(`参保人姓名不能为空`);
					return
				}
				if(`canbaoren` == this.tableName && this.registerForm.nianling &&(!this.$validate.isIntNumer2(this.registerForm.nianling))){
					this.$message.error(`年龄应输入整数`);
					return
				}
					if(`canbaoren` == this.tableName && this.registerForm.shenfenzheng &&(!this.$validate.isIdCard2(this.registerForm.shenfenzheng))){
						this.$message.error(`身份证应输入身份证格式`);
						return
					}
					if(`canbaoren` == this.tableName && this.registerForm.lianxidianhua &&(!this.$validate.isMobile2(this.registerForm.lianxidianhua))){
						this.$message.error(`联系电话应输入手机格式`);
						return
					}
            this.$http.post(url, this.registerForm).then(res => {
              if (res.data.code === 0) {
                this.$message({
                  message: '注册成功',
                  type: 'success',
                  duration: 1500,
                  onClose: () => {
                    this.$router.push('/login');
                  }
                });
              } else {
                this.$message.error(res.data.msg);
              }
            });
          } else {
            return false;
          }
        });
      },
      resetForm(formName) {
        this.$refs[formName].resetFields();
      }
    }
  }
</script>

<style rel="stylesheet/scss" lang="scss" scoped>
	.container {
		position: relative;
		background: url(http://codegen.caihongy.cn/20230922/735087380ee74ae5b7d67094b120ecee.jpg);
		
		.el-input {
		  width: auto;
		}
		
		.el-date-editor.el-input {
			width: auto;
		}
		
		.el-form-item /deep/ .el-form-item__content {
						display: flex;
						flex-wrap: wrap;
					}
		
		.rgs-form .el-input /deep/ .el-input__inner {
						border-radius: 0px;
						padding: 0 10px;
						outline: none;
						color: #666;
						width: auto;
						font-size: 14px;
						border-color: #1abc9e30;
						border-width: 0 0 1px;
						border-style: solid;
						min-width: 300px;
						height: 40px;
					}
		
		.rgs-form .el-select /deep/ .el-input__inner {
						border-radius: 0px;
						padding: 0 10px;
						outline: none;
						color: #666;
						width: auto;
						font-size: 14px;
						border-color: #1abc9e30;
						border-width: 0 0 1px;
						border-style: solid;
						min-width: 300px;
						height: 40px;
					}
		
		.rgs-form .el-date-editor /deep/ .el-input__inner {
						border-radius: 0px;
						padding: 0 10px 0 30px;
						outline: none;
						color: #666;
						width: auto;
						font-size: 14px;
						border-color: #1abc9e30;
						border-width: 0 0 1px;
						border-style: solid;
						min-width: 300px;
						height: 40px;
					}
		
		.rgs-form .el-date-editor /deep/ .el-input__inner {
						border-radius: 0px;
						padding: 0 10px 0 30px;
						outline: none;
						color: #666;
						width: auto;
						font-size: 14px;
						border-color: #1abc9e30;
						border-width: 0 0 1px;
						border-style: solid;
						min-width: 300px;
						height: 40px;
					}
		
		.rgs-form /deep/ .el-upload--picture-card {
			background: transparent;
			border: 0;
			border-radius: 0;
			width: auto;
			height: auto;
			line-height: initial;
			vertical-align: middle;
		}
		
		.rgs-form /deep/ .upload .upload-img {
		  		  cursor: pointer;
		  		  border-radius: 0px;
		  		  color: #1abc9e80;
		  		  width: 160px;
		  		  font-size: 32px;
		  		  border-color: #1abc9e30;
		  		  border-width: 0 0 1px;
		  		  line-height: 80px;
		  		  border-style: solid;
		  		  text-align: center;
		  		  height: 80px;
		  		}
		
		.rgs-form /deep/ .el-upload-list .el-upload-list__item {
		  		  cursor: pointer;
		  		  border-radius: 0px;
		  		  color: #1abc9e80;
		  		  width: 160px;
		  		  font-size: 32px;
		  		  border-color: #1abc9e30;
		  		  border-width: 0 0 1px;
		  		  line-height: 80px;
		  		  border-style: solid;
		  		  text-align: center;
		  		  height: 80px;
		  		}
		
		.rgs-form /deep/ .el-upload .el-icon-plus {
		  		  cursor: pointer;
		  		  border-radius: 0px;
		  		  color: #1abc9e80;
		  		  width: 160px;
		  		  font-size: 32px;
		  		  border-color: #1abc9e30;
		  		  border-width: 0 0 1px;
		  		  line-height: 80px;
		  		  border-style: solid;
		  		  text-align: center;
		  		  height: 80px;
		  		}
	}
	.required {
		position: relative;
	}
	.required::after{
				color: red;
				left: 120px;
				position: absolute;
				content: "*";
				order: 2;
			}
</style>

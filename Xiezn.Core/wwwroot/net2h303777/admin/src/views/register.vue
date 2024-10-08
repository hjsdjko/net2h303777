<template>
	<div>
		<div class="container" :style='{"minHeight":"100vh","alignItems":"center","background":"url(http://codegen.caihongy.cn/20240220/a89cf7f79399402f91dc50a779d453a3.jpg)","display":"flex","width":"100%","backgroundSize":"cover","backgroundPosition":"center center","backgroundRepeat":"no-repeat","justifyContent":"center"}'>
			<el-form v-if="pageFlag=='register'" :style='{"padding":"20px","boxShadow":"0 1px 20px rgba(64, 158, 255, .5)","margin":"50px 0","borderRadius":"10px","background":"rgba(0,0,0,.75)","width":"550px","height":"auto"}' ref="rgsForm" class="rgs-form" :model="rgsForm" :rules="rules">
				<div v-if="true" :style='{"width":"100%","margin":"0 0 10px 0","lineHeight":"64px","fontSize":"20px","color":"#fff","textAlign":"center"}' class="title">基于. NET的医院医保管理系统注册</div>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('canbaorenzhanghao')?'required':''">参保人账号：</div>
					<el-input  v-model="ruleForm.canbaorenzhanghao"  autocomplete="off" placeholder="参保人账号"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('mima')?'required':''">密码：</div>
					<el-input  v-model="ruleForm.mima"  autocomplete="off" placeholder="密码"  type="password"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('mima')?'required':''">确认密码：</div>
					<el-input  v-model="ruleForm.mima2" autocomplete="off" placeholder="确认密码" type="password" />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('canbaorenxingming')?'required':''">参保人姓名：</div>
					<el-input  v-model="ruleForm.canbaorenxingming"  autocomplete="off" placeholder="参保人姓名"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('xingbie')?'required':''">性别：</div>
                    <el-select v-model="ruleForm.xingbie" placeholder="请选择性别" >
                        <el-option
                            v-for="(item,index) in canbaorenxingbieOptions"
                            v-bind:key="index"
                            :label="item"
                            :value="item">
                        </el-option>
                    </el-select>
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('nianling')?'required':''">年龄：</div>
					<el-input  v-model.number="ruleForm.nianling"  autocomplete="off" placeholder="年龄"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('shenfenzheng')?'required':''">身份证：</div>
					<el-input  v-model="ruleForm.shenfenzheng"  autocomplete="off" placeholder="身份证"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('lianxidianhua')?'required':''">联系电话：</div>
					<el-input  v-model="ruleForm.lianxidianhua"  autocomplete="off" placeholder="联系电话"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('lianxidizhi')?'required':''">联系地址：</div>
					<el-input  v-model="ruleForm.lianxidizhi"  autocomplete="off" placeholder="联系地址"  type="text"  />
				</el-form-item>
				<el-form-item :style='{"width":"80%","padding":"0","margin":"0 auto 2px","height":"auto"}' class="list-item" v-if="tableName=='canbaoren'">
					<div v-if="true" :style='{"width":"100%","lineHeight":"44px","fontSize":"14px","position":"relative","color":"#fff"}' class="lable" :class="changeRules('touxiang')?'required':''">头像：</div>
                    <file-upload
                        tip="点击上传头像"
                        action="file/upload"
                        :limit="3"
                        :multiple="true"
                        :fileUrls="ruleForm.touxiang?ruleForm.touxiang:''"
                        @change="canbaorentouxiangUploadChange"
                    ></file-upload>
				</el-form-item>
				<button :style='{"border":"0","cursor":"pointer","padding":"0 10px","margin":"20px auto 5px","outline":"none","color":"#fff","borderRadius":"8px","background":"rgba(44, 55, 66, 0.9)","display":"block","width":"80%","fontSize":"16px","height":"44px"}' type="button" class="r-btn" @click="login()">注册</button>
				<div :style='{"cursor":"pointer","padding":"0 10%","margin":"20px 0 0","color":"rgba(159, 159, 159, 1)","textAlign":"center","display":"block","lineHeight":"2","fontSize":"16px","textDecoration":"underline"}' class="r-login" @click="close()">已有账号，直接登录</div>
			</el-form>
			
		</div>
	</div>
</template>

<script>
export default {
	data() {
		return {
			ruleForm: {
			},
			forgetForm: {},
            pageFlag : '',
			tableName:"",
			rules: {},
            canbaorenxingbieOptions: [],
		};
	},
	mounted(){
		this.pageFlag = this.$route.query.pageFlag
		if(this.$route.query.pageFlag=='register'){
			
			let table = this.$storage.get("loginTable");
			this.tableName = table;
			if(this.tableName=='canbaoren'){
				this.ruleForm = {
					canbaorenzhanghao: '',
					mima: '',
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
				this.rules.canbaorenzhanghao = [{ required: true, message: '请输入参保人账号', trigger: 'blur' }]
			}
			if ('canbaoren' == this.tableName) {
				this.rules.mima = [{ required: true, message: '请输入密码', trigger: 'blur' }]
			}
			if ('canbaoren' == this.tableName) {
				this.rules.canbaorenxingming = [{ required: true, message: '请输入参保人姓名', trigger: 'blur' }]
			}
			this.canbaorenxingbieOptions = "男,女".split(',')
		}
	},
	created() {
	},
	destroyed() {
		  	},
	methods: {
		changeRules(name){
			if(this.rules[name]){
				return true
			}
			return false
		},
		// 获取uuid
		getUUID () {
			return new Date().getTime();
		},
		close(){
			this.$router.push({ path: "/login" });
		},
        canbaorentouxiangUploadChange(fileUrls) {
            this.ruleForm.touxiang = fileUrls;
        },

        // 多级联动参数


		// 注册
		login() {
			var url=this.tableName+"/register";
					if((!this.ruleForm.canbaorenzhanghao) && `canbaoren` == this.tableName){
						this.$message.error(`参保人账号不能为空`);
						return
					}
					if((!this.ruleForm.mima) && `canbaoren` == this.tableName){
						this.$message.error(`密码不能为空`);
						return
					}
					if((this.ruleForm.mima!=this.ruleForm.mima2) && `canbaoren` == this.tableName){
						this.$message.error(`两次密码输入不一致`);
						return
					}
					if((!this.ruleForm.canbaorenxingming) && `canbaoren` == this.tableName){
						this.$message.error(`参保人姓名不能为空`);
						return
					}
					if(`canbaoren` == this.tableName && this.ruleForm.nianling &&(!this.$validate.isIntNumer(this.ruleForm.nianling))){
						this.$message.error(`年龄应输入整数`);
						return
					}
					if(`canbaoren` == this.tableName && this.ruleForm.shenfenzheng &&(!this.$validate.checkIdCard(this.ruleForm.shenfenzheng))){
						this.$message.error(`身份证应输入身份证格式`);
						return
					}
					if(`canbaoren` == this.tableName && this.ruleForm.lianxidianhua &&(!this.$validate.isMobile(this.ruleForm.lianxidianhua))){
						this.$message.error(`联系电话应输入手机格式`);
						return
					}
            if(this.ruleForm.touxiang!=null) {
                this.ruleForm.touxiang = this.ruleForm.touxiang.replace(new RegExp(this.$base.url,"g"),"");
            }
			this.$http({
				url: url,
				method: "post",
				data:this.ruleForm
			}).then(({ data }) => {
				if (data && data.code === 0) {
					this.$message({
						message: "注册成功",
						type: "success",
						duration: 1500,
						onClose: () => {
							this.$router.replace({ path: "/login" });
						}
					});
				} else {
					this.$message.error(data.msg);
				}
			});
		}
	}
};
</script>

<style lang="scss" scoped>
	.container {
	  position: relative;
	  background: url(http://codegen.caihongy.cn/20240220/a89cf7f79399402f91dc50a779d453a3.jpg);

		.el-date-editor.el-input {
		  width: 100%;
		}
		
		.rgs-form .el-input /deep/ .el-input__inner {
						border: 1;
						border-radius: 8px;
						padding: 0 10px;
						color: rgba(64, 158, 255, 1);
						width: 100%;
						font-size: 14px;
						height: 44px;
					}
		
		.rgs-form .el-select /deep/ .el-input__inner {
						border: 1;
						border-radius: 8px;
						padding: 0 10px;
						outline: none;
						color: rgba(44, 55, 66, 0.9);
						width: 288px;
						font-size: 14px;
						height: 44px;
					}
		
		.rgs-form .el-date-editor /deep/ .el-input__inner {
						border: 1;
						border-radius: 8px;
						padding: 0 10px 0 30px;
						outline: none;
						color: rgba(44, 55, 66, 0.9);
						width: 288px;
						font-size: 14px;
						height: 44px;
					}
		
		.rgs-form .el-date-editor /deep/ .el-input__inner {
						border: 1;
						border-radius: 8px;
						padding: 0 10px 0 30px;
						outline: none;
						color: rgba(44, 55, 66, 0.9);
						width: 288px;
						font-size: 14px;
						height: 44px;
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
		  		  border-radius: 8px;
		  		  color: rgba(44, 55, 66, 0.9);
		  		  background: #fff;
		  		  object-fit: cover;
		  		  width: 90px;
		  		  font-size: 32px;
		  		  line-height: 60px;
		  		  text-align: center;
		  		  height: 60px;
		  		}
		
		.rgs-form /deep/ .el-upload-list .el-upload-list__item {
		  		  cursor: pointer;
		  		  border-radius: 8px;
		  		  color: rgba(44, 55, 66, 0.9);
		  		  background: #fff;
		  		  object-fit: cover;
		  		  width: 90px;
		  		  font-size: 32px;
		  		  line-height: 60px;
		  		  text-align: center;
		  		  height: 60px;
		  		}
		
		.rgs-form /deep/ .el-upload .el-icon-plus {
		  		  cursor: pointer;
		  		  border-radius: 8px;
		  		  color: rgba(44, 55, 66, 0.9);
		  		  background: #fff;
		  		  object-fit: cover;
		  		  width: 90px;
		  		  font-size: 32px;
		  		  line-height: 60px;
		  		  text-align: center;
		  		  height: 60px;
		  		}
	}
	.required {
		position: relative;
	}
	.required::after{
				color: red;
				left: -10px;
				position: absolute;
				content: "*";
			}
	.editor>.avatar-uploader {
		line-height: 0;
		height: 0;
	}
</style>

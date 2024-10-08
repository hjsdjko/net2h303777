const base = {
    get() {
        return {
            url : "http://localhost:8080/net2h303777/",
            name: "net2h303777",
            // 退出到首页链接
            indexUrl: 'http://localhost:8080/net2h303777/front/dist/index.html'
        };
    },
    getProjectName(){
        return {
            projectName: "基于. NET的医院医保管理系统"
        } 
    }
}
export default base

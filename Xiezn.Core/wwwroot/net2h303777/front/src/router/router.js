import VueRouter from 'vue-router'

//引入组件
import Index from '../pages'
import Home from '../pages/home/home'
import Login from '../pages/login/login'
import Register from '../pages/register/register'
import Center from '../pages/center/center'
import Storeup from '../pages/storeup/list'
import News from '../pages/news/news-list'
import NewsDetail from '../pages/news/news-detail'
import payList from '../pages/pay'

import canbaorenList from '../pages/canbaoren/list'
import canbaorenDetail from '../pages/canbaoren/detail'
import canbaorenAdd from '../pages/canbaoren/add'
import jiuyijiluList from '../pages/jiuyijilu/list'
import jiuyijiluDetail from '../pages/jiuyijilu/detail'
import jiuyijiluAdd from '../pages/jiuyijilu/add'
import yiliaofeiyongjiesuanList from '../pages/yiliaofeiyongjiesuan/list'
import yiliaofeiyongjiesuanDetail from '../pages/yiliaofeiyongjiesuan/detail'
import yiliaofeiyongjiesuanAdd from '../pages/yiliaofeiyongjiesuan/add'
import yaopinxinxiList from '../pages/yaopinxinxi/list'
import yaopinxinxiDetail from '../pages/yaopinxinxi/detail'
import yaopinxinxiAdd from '../pages/yaopinxinxi/add'
import yaopindingdanList from '../pages/yaopindingdan/list'
import yaopindingdanDetail from '../pages/yaopindingdan/detail'
import yaopindingdanAdd from '../pages/yaopindingdan/add'
import newstypeList from '../pages/newstype/list'
import newstypeDetail from '../pages/newstype/detail'
import newstypeAdd from '../pages/newstype/add'

const originalPush = VueRouter.prototype.push
VueRouter.prototype.push = function push(location) {
	return originalPush.call(this, location).catch(err => err)
}

//配置路由
export default new VueRouter({
	routes:[
		{
      path: '/',
      redirect: '/index/home'
    },
		{
			path: '/index',
			component: Index,
			children:[
				{
					path: 'home',
					component: Home
				},
				{
					path: 'center',
					component: Center,
				},
				{
					path: 'pay',
					component: payList,
				},
				{
					path: 'storeup',
					component: Storeup
				},
				{
					path: 'news',
					component: News
				},
				{
					path: 'newsDetail',
					component: NewsDetail
				},
				{
					path: 'canbaoren',
					component: canbaorenList
				},
				{
					path: 'canbaorenDetail',
					component: canbaorenDetail
				},
				{
					path: 'canbaorenAdd',
					component: canbaorenAdd
				},
				{
					path: 'jiuyijilu',
					component: jiuyijiluList
				},
				{
					path: 'jiuyijiluDetail',
					component: jiuyijiluDetail
				},
				{
					path: 'jiuyijiluAdd',
					component: jiuyijiluAdd
				},
				{
					path: 'yiliaofeiyongjiesuan',
					component: yiliaofeiyongjiesuanList
				},
				{
					path: 'yiliaofeiyongjiesuanDetail',
					component: yiliaofeiyongjiesuanDetail
				},
				{
					path: 'yiliaofeiyongjiesuanAdd',
					component: yiliaofeiyongjiesuanAdd
				},
				{
					path: 'yaopinxinxi',
					component: yaopinxinxiList
				},
				{
					path: 'yaopinxinxiDetail',
					component: yaopinxinxiDetail
				},
				{
					path: 'yaopinxinxiAdd',
					component: yaopinxinxiAdd
				},
				{
					path: 'yaopindingdan',
					component: yaopindingdanList
				},
				{
					path: 'yaopindingdanDetail',
					component: yaopindingdanDetail
				},
				{
					path: 'yaopindingdanAdd',
					component: yaopindingdanAdd
				},
				{
					path: 'newstype',
					component: newstypeList
				},
				{
					path: 'newstypeDetail',
					component: newstypeDetail
				},
				{
					path: 'newstypeAdd',
					component: newstypeAdd
				},
			]
		},
		{
			path: '/login',
			component: Login
		},
		{
			path: '/register',
			component: Register
		},
	]
})

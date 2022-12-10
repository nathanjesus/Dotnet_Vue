import Vue from 'vue'
import App from './App.vue'
import resouce from 'vue-resource'

Vue.config.productionTip = false
Vue.use(resouce)

new Vue({
  render: h => h(App),
}).$mount('#app')

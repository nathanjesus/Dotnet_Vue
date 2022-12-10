import Vue from 'vue';
import Router from 'vue-resource';

import Knight from './components/Knight'
import Hall from './components/Hall'
import Sobre from './components/Sobre'

Vue.use(Router);

export default new Router({
    routes: [
        {
            path: '/knights',
            nome: 'knights',
            component: Knight
        },
        {
            path: '/hall',
            nome: 'hall',
            component: Hall
        },
        {
            path: '/sobre',
            nome: 'sobre',
            component: Sobre
        }
    ]
})
import Vue from 'vue';
import iView from 'iview';
import App from './app.vue';
import bj from './bj.vue';

//import '../iview/iview.css';

Vue.use(iView);

new Vue({
    el: '#app',
    render: h => h(App)
 
    
});


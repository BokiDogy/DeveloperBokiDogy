const routers = [

    {
        path: '/',
        meta: {
            title: ''
        },
        component: (resolve) => require(['./wxbtest/buju.vue'], resolve)
    }
   
];
export default routers;
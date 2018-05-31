<template>
	<Table border :columns="columns" :data="data"></Table>
</template>
<script>
	import axios from 'axios';

	export default {
		data() {
			return {
				columns: [{
						title: '房屋编号',
						key: 'HouseId',
						render: (h, params) => {
							return h('div', [
								h('Icon', {
									props: {
										type: 'home'
									}
								}),
								h('strong', "    " + params.row.HouseId)
							]);
						}
					},
					{
						title: '房屋类型',
						key: 'HouseTypeName'
					},
					{
						title: '面积',
						key: 'Area'
					},
					{
						title: '地址',
						key: 'Addr'
					},
					{
						title: '客户名称',
						key: 'LoginName',
						render: (h, params) => {
							return h('div', [
								h('Icon', {
									props: {
										type: 'person'
									}
								}),
								h('strong', "    " + params.row.LoginName)
							]);
						}
					},
					{
						title: '操作',
						key: 'action',
						width: 150,
						align: 'center',
						render: (h, params) => {
							return h('div', [
								h('Button', {
									props: {
										type: 'primary',
										size: 'small'
									},
									style: {
										marginRight: '5px'
									},
									on: {
										click: () => {
											this.show(params.index)
										}
									}
								}, 'View'),
								h('Button', {
									props: {
										type: 'error',
										size: 'small'
									},
									on: {
										click: () => {
											this.remove(params.index)
										}
									}
								}, 'Delete')
							]);
						}
					}
				],
				data: []
			}
		},
		created: allquery,
		methods: {
			show(index) {
				this.$Modal.info({
					title: 'User Info',
					content: `HouseId：${this.data[index].HouseId}<br>
					HouseTypeName：${this.data[index].HouseTypeName}<br>
					Area：${this.data[index].Area}<br>
					Addr：${this.data[index].Addr}<br>
					UserName：${this.data[index].LoginName}`
				})
			},
			remove(index) {
				this.data.splice(index, 1);
			}

		}
	}

	function allquery() {
		axios.get('http://localhost:7768/Interfaces/GetAllHouse.aspx').then((respons) => {
			this.data = respons.data;
			this.data.forEach((x) => x.LoginName = x.Customer.LoginName);
		});
	}

	function getDataUrl(obj) {
		let date = new Date();
		let str = '?timer=' + date.getTime();
		for(let n in obj) {
			str += '&' + n + '=' + obj[n];
		}
		return str;
	}
</script>
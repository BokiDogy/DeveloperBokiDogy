	/**
	 * 把一个对象拼成key=值&key=值.......
	 * @param {Object} obj {对象}
	 */
	function UrlDataFormat(obj) {
		let str = '1=1';
		for(k in obj) {
			str = str + '&' + k + '=' + obj[k];
		}
		return str;
	}
	var ct={'Content-Type': 'application/x-www-form-urlencoded'};
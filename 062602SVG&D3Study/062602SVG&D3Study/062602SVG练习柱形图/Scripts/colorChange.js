//用法:
//参数c1,c2,c3代表设置的三个颜色的十六位代码,如黑色为'000000',白色为'FFFFFF',注意不要带'#'号
//count为渐变分割份数
//返回值为一个字符串数组,每个元素为一个颜色代码
//示例:
//使用函数:colors = colorChange("FF006C", "FDF003", "01A3EE", t.length);
//colors为返回的颜色代码字符串数组
//设定颜色时示例:
//color: colors[i];

//三色渐变色算法--中间突变
function colorChange(c1, c2, c3, count) {
	let a = hexToRgb(c1);
	let b = hexToRgb(c2);
	let c = hexToRgb(c3);
	let colors = [];
	for(let i = 0; i < parseInt(count / 2); i++) {
		let stepr1 = (a[0] - b[0]) / (count / 2);
		let stepg1 = (a[1] - b[1]) / (count / 2);
		let stepb1 = (a[2] - b[2]) / (count / 2);
		let numr1 = b[0] + stepr1 * i;
		let numg1 = b[1] + stepg1 * i;
		let numb1 = b[2] + stepb1 * i;
		colors.push(rgbToHex(numr1, numg1, numb1));
	}
	for(let j = 0; j <= parseInt(count / 2); j++) {
		let stepr2 = (b[0] - c[0]) / (count / 2);
		let stepg2 = (b[1] - c[1]) / (count / 2);
		let stepb2 = (b[2] - c[2]) / (count / 2);
		let numr2 = c[0] + stepr2 * j;
		let numg2 = c[1] + stepg2 * j;
		let numb2 = c[2] + stepb2 * j;
		colors.push(rgbToHex(numr2, numg2, numb2));
	}
	return colors;
}

//三色渐变色算法--渐变
function colorChange2(c1, c2, c3, count) {
	let a = hexToRgb(c1);
	let b = hexToRgb(c2);
	let c = hexToRgb(c3);
	let colors = [];
	for(let i = 0; i < parseInt(count / 2); i++) {
		let stepr1 = (b[0] - a[0]) / (count / 2);
		let stepg1 = (b[1] - a[1]) / (count / 2);
		let stepb1 = (b[2] - a[2]) / (count / 2);
		let numr1 = a[0] + stepr1 * i;
		let numg1 = a[1] + stepg1 * i;
		let numb1 = a[2] + stepb1 * i;
		colors.push(rgbToHex(numr1, numg1, numb1));
	}
	for(let j = 0; j <= parseInt(count / 2); j++) {
		let stepr2 = (c[0] - b[0]) / (count / 2);
		let stepg2 = (c[1] - b[1]) / (count / 2);
		let stepb2 = (c[2] - b[2]) / (count / 2);
		let numr2 = b[0] + stepr2 * j;
		let numg2 = b[1] + stepg2 * j;
		let numb2 = b[2] + stepb2 * j;
		colors.push(rgbToHex(numr2, numg2, numb2));
	}
	return colors;
}
		
//十六进制转rgb
function hexToRgb(hex) {
	let rgb = [];
	for(let i = 0; i < 6; i += 2) {
		rgb.push(parseInt(hex.substr(i, 2), 16));
	}
	return rgb;
}
//rgb转十六进制
function rgbToHex(r, g, b) {
	let hex = ((r << 16) | (g << 8) | b).toString(16);
	return "#" + new Array(Math.abs(hex.length - 7)).join("0") + hex;
}
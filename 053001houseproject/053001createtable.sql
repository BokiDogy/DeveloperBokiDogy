create table test_0530customers(
customerid number(4) not null primary key,
loginname varchar2(20) not null,
pwd varchar2(20) not null);

create table test_0530houses(
houseid number(4) not null primary key,
housetypename varchar2(20) not null,
area number(4) not null ,
addr varchar2(30) not null,
customerid number(4) constraint fk_customerid references test_0530customers(customerid)
);

insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (1, 'admin', '123456');
insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (2, 'wxb', 'wxbsuper');
insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (3, 'wq', '123456');
insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (4, 'gy', '123456');
insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (5, 'lxz', '123456');
insert into TEST_0530CUSTOMERS (customerid, loginname, pwd)
values (6, 'jl', '123456');

insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (1, '两室一厅', 100, '和平区', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (2, '三室二厅一卫', 120, '和平区', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (3, '两室二厅', 100, '皇姑区', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (4, '一室一厅', 50, '沈河区', 3);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (5, '别墅', 260, '和平区', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (6, '三室一厅', 130, '浑南新区', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (7, '一室一厅', 80, '和平区', 4);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (8, '公寓', 100, '和平区', 5);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (9, '两室一厅', 90, '和平区', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (10, '四室二厅', 150, '铁西区', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (11, '两室一厅', 100, '于洪区', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (12, '两室一厅', 100, '铁西区', 6);

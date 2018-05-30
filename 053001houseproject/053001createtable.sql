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
values (1, '����һ��', 100, '��ƽ��', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (2, '���Ҷ���һ��', 120, '��ƽ��', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (3, '���Ҷ���', 100, '�ʹ���', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (4, 'һ��һ��', 50, '�����', 3);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (5, '����', 260, '��ƽ��', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (6, '����һ��', 130, '��������', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (7, 'һ��һ��', 80, '��ƽ��', 4);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (8, '��Ԣ', 100, '��ƽ��', 5);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (9, '����һ��', 90, '��ƽ��', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (10, '���Ҷ���', 150, '������', 2);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (11, '����һ��', 100, '�ں���', 1);
insert into TEST_0530HOUSES (houseid, housetypename, area, addr, customerid)
values (12, '����һ��', 100, '������', 6);

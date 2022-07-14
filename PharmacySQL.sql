create database Pharmacy
use Pharmacy

--(this table is linked with Adduser.cs form which is in AdministratorUC folder)
--table for user insertion;
create table users(
id int identity(1,1) not null primary key,
userRole varchar(60) not null,
name varchar(259) not null,
dob varchar(259) not null,
mobile bigint not null,
email varchar(259) not null ,
username varchar(259) unique not null,
pass varchar(259) not null
);
select * from users
insert into users values('admin','laiba','2002','0321','l@gmail.com','admin','admin')
insert into users values('admin','laiba','2002','0321','l@gmail.com','admin22','123')
insert into users values('Administrator','demo','2002','0321','l@gmail.com','admin12','123')
insert into users values('Pharmacist','demo','2002','0321','l@gmail.com','admin123','123')
--drop table users
--(this table is linked with Addmedicine form which is in Pharmacy folder)
create table medic(
id int identity(1,1) primary key,
mid varchar(250) not null,
mname varchar(250) not null,
mnumber varchar(250) not null,
mDate varchar(250) not null,
eDate varchar(250) not null,
quantity bigint not null,
perunit bigint not null
)
select * from medic

--truncate table medic
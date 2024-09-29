create table users (
	id int primary key identity(1,1),
	username varchar(100) null,
	password varchar(100) null,
	date_reg date null
)

select * from users

create table employee (
	id int primary key identity(1,1),
	employee_id varchar(100) null,
	full_name varchar(100) null,
	gender varchar(100) null,
	tele_no varchar(100) null,
	position varchar(100) null,
	salary int,
	image varchar(max) null,
	insert_date date null,
	update_date date null,
	delete_date date null
)

select * from employee

select * from employee where delete_date is null

alter table employee add ststus varchar(100 ) null
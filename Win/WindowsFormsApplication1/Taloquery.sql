create table Auto
(
	id int identity(1, 1) not null,
	reknro nvarchar(7) not null,
	merkki nvarchar(50) not null,
	malli nvarchar(50) not null,
	vuosimalli integer null,
	vari nvarchar (50) null
	constraint pk_AUTO primary key (id),

);
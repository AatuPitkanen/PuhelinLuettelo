
create table Sukupuoli
(
	id int identity(1, 1) not null,
	Koodi nvarchar(2) not null,
	Selite nvarchar(50) not null,
	constraint Sukupuoli_PK primary key (id),
	constraint Sukupuoli_UQ unique (koodi)
);
create table Asuntotyyppi
(
	id int identity(1,1) not null,
	Koodi nvarchar(2) not null,
	Selite nvarchar(50) not null,
	constraint Asuntotyyppi_PK primary key (id),
	constraint Asuntotyyppi_UQ unique (koodi)

);
create table Asunto
(
	id int identity(1,1) not null,
	Osoite nvarchar(50) not null,
	Ala int not null,
	huoneet int not null,
	tyyppi int not null,
	Omistus bit,
	constraint Asunto_PK primary key (id),
	constraint Asunto_Asuntotyyppi_FK foreign key (tyyppi) references asuntotyyppi(id)

);
create table Henkilo
(
	id int identity(1, 1) not null,
	enimi nvarchar(50) not null,
	snimi nvarchar(50) not null,
	Sukupuoli int not null,
	Asunto int not null,
	constraint Henkilo_PK primary key (id),
	constraint Henkilo_Sukupuoli_FK foreign key (sukupuoli) references sukupuoli(id),
	constraint Henkilo_Asunto_FK foreign key (asunto) references asunto(id)	

);

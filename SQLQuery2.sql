


create table type_article(
	ID int primary key identity,
	Designation varchar(100)
);

create table article(
	ID int primary key identity,
	Article varchar(100),
	Prix float,
	ID_type int foreign key references type_article(ID),
);

create table achats(
	ID int primary key identity,
	Fourniseur varchar(100) null,
	Article int foreign key references article(ID),
	Qte float,
	Prix float,
	Created_at date
);


create table ventes(
	ID int primary key identity,
	remise float,
	Client varchar(100) null,
	Article int foreign key references article(ID),
	Qte float,
	Prix float,
	Created_at date
);
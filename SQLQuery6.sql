create table Brands ( 

BrandId int Identity(1,1) primary key,
BrandName varchar(255) not null unique 
);

Insert into Brands (BrandName)
values ('BMW')
select * from Brands

  create table Color (
  ColorId int Identity(1,1) primary key,
  colorName varchar(255) not null unique
  );

  insert into Color (colorName) 
  values('Red' )
  select * from Color;
 
  create table Car (
  CarId int Identity(1,1) primary key,
  BrandId int foreign key references Brands(BrandId),
  ColordId int foreign key  references Color(ColorId),
  DailyPrice decimal,
  Explain varchar(255), 
  ModelYear int,
  );

  insert into Car
  values(1,1,900,'BMW ,kırmızı ,2019 model, günlük 900tl',2019 )
  select * from Car
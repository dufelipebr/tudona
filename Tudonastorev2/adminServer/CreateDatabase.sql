
drop table dbo.Client
drop table dbo.Region
drop table dbo.EntityStatus

create table dbo.Client
(
clientID int identity(1,1), 
clientHost varchar(200) not null, 
clientContactName varchar(50) not null, 
clientContactNumber varchar(15) not null, 
clientPhoneNumber varchar(15) not null, 
clientFullAddress varchar(100) not null, 
clientZipCode varchar(100) not null, 
clientGEO varchar(500) not null, 
clientLogin varchar(20) not null, 
clientPWD varchar(300) not null, 
clientRegion int not null, 
clientStatus int not null
)


create table dbo.Region 
(
	regionID int, 
	regionName varchar(30), 
	regionStatus int
)

insert into dbo.Region values (1, 'Brazil', 1)

create table dbo.EntityStatus
(
	entityStatusID int, 
	entityStatusName varchar(30) ,
	entityName varchar(30)
)

insert into dbo.EntityStatus values (1, 'Active', 'Client')
insert into dbo.EntityStatus values (0, 'Inactive', 'Client')
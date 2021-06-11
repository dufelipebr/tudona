create table Client
(
clientID int identity(1,1), 
clientHost varchar(200) not null, 
clientContactName varchar(50) not null, 
clientPhoneNumber varchar(15) not null, 
clientLogin varchar(20) not null, 
clientPWD varchar(300) not null, 
clientRegion varchar(10) not null, 
clientStatus char(1) not null
)

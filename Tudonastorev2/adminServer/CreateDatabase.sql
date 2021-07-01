use azCrmDefault
GO
if object_id('dbo.Client') is not null 
	drop table dbo.Client

if object_id('dbo.Region') is not null 
	drop table dbo.Region

if object_id('dbo.EntityStatus') is not null 
	drop table dbo.EntityStatus
GO
create table dbo.Client
(
	clientID int identity(1,1), 
	clientHost varchar(200) not null, 
	clientContactName varchar(50) not null, 
	clientContactNumber varchar(15) not null, 
	clientPhoneNumber varchar(15) not null, 
	clientAddress varchar(100) not null, 
	clientAddressNum varchar(10) not null, 
	clientAddressCom varchar(10) not null, 
	clientAddressNgh varchar(30) not null, 
	clientAddressSta varchar(20) not null, 
	clientZipCode varchar(100) not null, 
	clientGEO varchar(500) not null, 
	clientLogin varchar(20) not null, 
	clientPWD varchar(300) not null, 
	clientRegionID int not null, 
	clientStatusID int not null,
	PRIMARY KEY(clientID)
)

create table dbo.Region 
(
	regionID int, 
	regionName varchar(30), 
	regionStatus int,
	PRIMARY KEY(regionID)
)



create table dbo.EntityStatus
(
	entityStatusID int, 
	entityStatusName varchar(30) ,
	entityName varchar(30),
	PRIMARY KEY(entityStatusID)
)
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Client_EntityStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Client]'))
	ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_EntityStatus] FOREIGN KEY([clientStatusID]) 	REFERENCES [dbo].[EntityStatus] ([entityStatusID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Client_EntityStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Client]'))
	ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_EntityStatus]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Client_Region]') AND parent_object_id = OBJECT_ID(N'[dbo].[Client]'))
	ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Region] FOREIGN KEY([clientRegionID]) REFERENCES [dbo].[Region] ([regionID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Client_Region]') AND parent_object_id = OBJECT_ID(N'[dbo].[Client]'))
	ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Region]
GO

GO
insert into dbo.Region values (1, 'Brazil', 1)
insert into dbo.EntityStatus values (1, 'Active', 'Client')
insert into dbo.EntityStatus values (2, 'Inactive', 'Client')


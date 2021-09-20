
if object_id('dbo.Client') is not null 
	drop table dbo.Client

if object_id('dbo.OurProducts') is not null 
	drop table dbo.OurProducts

	
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
	clientRegionID int not null, 
	clientStatusID int not null,
	clientType varchar(1) not null, 
	clientSocialNumber varchar(20) not null, 
	clientBusinessFullName varchar(70) not null,
	facebookID varchar(150),  
	instagramID varchar(150), 
	email varchar(50), 
	whatsApp varchar(20), 
	creationDate datetime, 
	modifiedDate datetime, 
	expirationDate datetime, 
	hashControl varchar(100),
	entityName varchar(30), 
	--CONSTRAINT AK_client_HashControl UNIQUE(clientHost) ,
	PRIMARY KEY(clientID)
)

create table dbo.Region 
(
	regionID int not null, 
	regionName varchar(30) not null, 
	regionStatus int not null,
	PRIMARY KEY(regionID)
)



create table dbo.EntityStatus
(
	entityStatusID int not null, 
	entityStatusName varchar(30) not null ,
	entityName varchar(30) not null,
	statusBehavior int not null, 
	PRIMARY KEY(entityStatusID,entityName)
)

create table dbo.OurProducts
(
	ourProductID int identity(1,1) not null,
	clientID int not null, 
	productName varchar(30) not null, 
	productDescription varchar(100) not null, 
	thumbName varchar(200) not null, 
	fileExtension varchar(10) not null,
	fileLenght int not null, 
	relativePath varchar(100) not null, 
	orderedBy int not null, 
	entityName varchar(30) not null, 
    entityStatusID int not null,
	CreationDate datetime not null, 
	LastModified datetime not null,
	PRIMARY KEY(ourProductID)
)


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OurProducts_EntityStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[OurProducts]'))
	ALTER TABLE [dbo].[OurProducts]  WITH CHECK ADD  CONSTRAINT [FK_OurProducts_EntityStatus] FOREIGN KEY(entityStatusID,entityName) 	REFERENCES [dbo].[EntityStatus] (entityStatusID,entityName)
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Client_EntityStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[Client]'))
	ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_EntityStatus] FOREIGN KEY([clientStatusID],entityName) 	REFERENCES [dbo].[EntityStatus] (entityStatusID,entityName)
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
insert into dbo.EntityStatus values (1, 'Active', 'Client', 1)
insert into dbo.EntityStatus values (2, 'Inactive', 'Client', 0)
insert into dbo.EntityStatus values (1, 'Active', 'OurProducts', 1)
insert into dbo.EntityStatus values (2, 'Inactive', 'OurProducts', 0)


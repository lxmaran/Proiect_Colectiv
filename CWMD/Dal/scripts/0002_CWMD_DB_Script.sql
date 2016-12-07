create table Roles
(
	Id int identity(1,1) not null primary key,
	Role varchar(50) not null
)

create table Persons
(
	Id int identity(1,1) not null primary key,
	RoleId int not null foreign key references Roles(Id),
	FirstName varchar(50) not null,
	LastName varchar(50) not null
)

create table Users
(
	Id int identity(1,1) not null primary key references Persons(Id),
	UserName varchar(50) not null,
	Password varchar(250) not null
)

create table FlowTypes
(
	Id int identity(1,1) not null primary key,
	Type varchar(50) not null
)

create table FlowTypes_Contributors
(
	FlowTypeId int not null foreign key references FlowTypes(Id),
	PersonId int not null foreign key references Persons(Id),
	PersonOrder int not null,
	primary key (FlowTypeId, PersonId)
)

create table Documents
(
	Id int identity(1,1) not null primary key,
	Name varchar(50) not null,
	Type varchar(50) not null,
	AddedDate datetime not null default getdate(),
	UpdatedDate datetime not null default getdate(),
	PersonId int not null foreign key references Persons(Id),
	PrincipalDocumentId int foreign key references Documents(Id),
	Version varchar(50) not null	
)

create table Flows
(
	Id int identity(1,1) not null primary key,
	FlowTypeId int not null foreign key references FlowTypes(Id),
	PrincipalDocumentId int not null foreign key references Documents(Id),
	CurrentPersonOrder int not null
)
create table [Users](
	[Id] int primary key identity(1,1),
	[UserName] varchar(120) unique not null,
	[Password] varchar(MAX) not null
);

create table [Roles](
	[Id] int identity(1,1) primary key,
	[Role] varchar(50) not null
);

create table [Persons](
	[Id] int references [Users]([Id]) primary key,
	[GUID] varchar(32) unique not null,
	[RoleId] int references [Roles]([Id]),
	[FirstName] varchar(50) not null,
	[LastName] varchar(50) not null
);

create table [Documents](
	[Id] int identity(1,1) primary key,
	[GUID] varchar(32) unique not null,
	[CreateDate] date not null,
	[UpdateDate] date not null,
	[PersonId] varchar(32) references [Persons]([GUID]),
	[Type] varchar(50) not null,
	[Name] varchar(50) not null
);

create table [Flows](
	[DocumentId] int references [Documents]([Id]),
	[PersonId] int references [Persons]([Id]),
	
	constraint [PK_Flow] primary key ([DocumentId],[PersonId])   
);

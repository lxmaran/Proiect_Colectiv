create table Logs
(
	Id int identity(1,1) not null primary key,
	UserId int not null,
	EventName varchar(50) not null,
	EventDate varchar(50) not null
)
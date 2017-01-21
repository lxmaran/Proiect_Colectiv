exec sp_rename 'Flows', 'Tasks'

create table Answares
(
	Id int identity(1,1) not null primary key,
	Name varchar(50) not null
)

alter table Tasks
add AnswareId int references Answares(Id)
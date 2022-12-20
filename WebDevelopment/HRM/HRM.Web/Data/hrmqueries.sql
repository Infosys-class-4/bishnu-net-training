select * from Employee

insert into Employee 
values ('Bishnu', 'Rawal', 'Koteswor, Kathmandu', 'M', '1960-2-2')

update Employee set FirstName='Sita', Gender='F'
where Id=2

delete from Employee where Id=3

--create table EmployeeDetails
--(
--	Id int not null identity,
--	NagaritaDoc image null,
--	TemporaryAddress nvarchar(200) null,
--	TranscriptDoc image null
--)

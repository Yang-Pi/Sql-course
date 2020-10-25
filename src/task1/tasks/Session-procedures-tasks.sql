Use UpdtSession
Go
--PROCEDURES
--1
Create Procedure Count_Students As
Select Count(*) From Students
Go
Exec Count_Students;

--2
Create Procedure Count_Students_Sem @Num_sem As int As
	Select Count(Distinct B.St) From Balls B 
		Join Uplans U On U.Id = B.Uplan 
		Join Disciplines D On U.Disc = D.Id 
		WHERE U.Semestr >= @Num_sem
GO
Exec Count_Students_Sem 1;
Go
Declare @num int;
Set @num = 2;
Exec Count_Students_Sem @num;

--3.1
Create Procedure List_students_of_dir_and_disc (@Dir As int, @DiscTitle as varchar(30)) As
	Select Distinct S.FIO From Students S
		Join Groups G On S.Gr = G.Id
		Join Balls B On S.Id = B.St
		Join Uplans U On B.Uplan = U.Id
		Where G.Dir = @Dir
			And U.Disc = (Select Disc.Id From Disciplines Disc Where Disc.Title = @DiscTitle)
Go
Exec List_students_of_dir_and_disc 231000, 'Физика';
Go
Declare @DirId int, @DiscTitle varchar(30);
Set @DirId = 230100;
Set @DiscTitle = 'Математика';
Exec List_students_of_dir_and_disc @DirId, @DiscTitle;

--3.2
Create Procedure Enter_Students (@FIO As varchar(30), @Group As varchar(10)) As
	Insert Into Students (FIO, Gr) Values (@FIO, @Group);
Go
Declare @StudentName varchar(30), @Group varchar(10);
Set @StudentName = 'Светлова Вероника';
Set @Group = '53504/3';
Exec Enter_Students  @StudentName, @Group;
Go
Declare @StudentName varchar(30), @Group varchar(10);
Set @StudentName = 'Новая Наталья'
Set @Group = '53504/3';
Exec Enter_Students  @StudentName, @Group;

--4
Create Procedure Next_course (@Group As varchar(10) = '13504/1') As
	Update Students Set Gr = Convert(char(1), Convert(int, Left(Gr, 1)) + 1) + Substring(Gr, 2, Len(Gr) - 1);
	Where Gr = @Group;
Go
Declare @Group varchar(10);
Set @Group='13504/3';
Exec Next_course @Group;
GO
Exec Next_course;
GO
--
Create Procedure Previous_course (@Group As varchar(10) = '23504/1') As
	Update Students Set Gr = 
		Case
			When Left(Gr, 1) > 1 Then Convert(char(1), Convert(int, Left(Gr, 1)) - 1) + Substring(Gr, 2, Len(Gr) - 1);
		End
	Where Gr = @Group
Go
Declare @Group varchar(10);
Set @Group='23504/3';
Exec Previous_course @Group;

--5
Create Procedure Number_Groups (@Dir as int, @Number as int Output) As
	Select @Number = Count(*) From Groups Where Dir = @Dir;
Go
Declare @Group int;
Exec Number_Groups 230100, @Group Output;
Select @Group;
Go

--6
Create Procedure Delete_Students_Complete As
	Insert Into ArchiveStudents Select Year(GetDate()), Id, FIO, Gr From Students  Where Left(Gr, 1) = 6;
	Delete From Students Where Left(Gr, 1) = 6;
Go
--
Create Procedure Next_course_2 As
	Exec Delete_Students_Complete;
	Update Students Set Gr =
		Convert(char(1), Convert(int, Left(Gr, 1)) + 1) + Substring(Gr, 2, Len(Gr) - 1)
	Where Id In (Select Id From Students_complete_all);
Go
Exec Next_course_2;
Go
--
Create Procedure Delete_Student (@Id int) As
	Insert Into ArchiveStudents Select Year(GetDate()), Id, FIO, Gr From Students Where Id = @Id;
	Delete From Students Where Id = @Id;
Go
Create Procedure Comeback_Student (@StId int) As
	Insert Into Students Select FIO, Gr From ArchiveStudents Where St = @StId;
	Delete From ArchiveStudents Where St = @StId;
Go
Declare @StId int;
Set @StId = (Select Id From Students Where FIO = 'Иванов Иван');
Exec Delete_Student @StId;

Declare @StId int;
Set @StId = (Select St From ArchiveStudents Where FIO = 'Иванов Иван');
Exec Comeback_Student @StId;
--
Create Procedure Comback_All_Students As
	Insert Into Students Select FIO, Gr From ArchiveStudents;
	Delete From ArchiveStudents;
Go
Exec Comback_All_Students;
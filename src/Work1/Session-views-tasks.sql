Use UpdtSession
Go
--VIEWS

--1
Create View Disciplines_with_balls As
	Select Distinct Title From Disciplines D
		Join Uplans U On D.Id = U.Disc
		Join Balls B On U.Id = B.Uplan
Go
Select * From Disciplines_with_balls

--2
Create View Students_top_and_last (Id, FIO, Complete) As
	(Select T.Id, T.FIO, 'No' From 
		(Select S.Id, S.FIO From Students S
		Except 
		Select Distinct B.St, S1.FIO 
			From Balls B Join Students S1 On B.St = S1.Id) As T)
	Union
	(Select S.Id, S.FIO, 'Five' From 
		Students S Join Balls B On S.Id = B.St And B.Ball = 5)
Go
Select * From Students_top_and_last

--3
Create View Students_complete (Student_Id, FIO, Direction_Id, Direction, Nummer_of_balls) As
	Select S.Id Student_Id, S.FIO, U.Dir Direction_Id, D.Title, Count(B.Ball) From Balls B
		Join Uplans U On B.Uplan = U.Id
		Join Directions D On U.Dir = D.Id And U.Semestr = 1
		Join Students S On B.St = S.Id
		Group by S.Id, S.FIO, U.Dir, D.Title
		Having Count(B.Ball) = 
			(Select Count(*) From Uplans U1 
				Where U.Dir = U1.Dir And U1.Semestr = 1)
Go
Select * From Students_complete

--4
Create View Students_complete_all As
	Select S.Id, S.FIO From Students S
		Join Groups G On G.Id = S.Gr
		Where Not Exists
			(Select * From Uplans U
				Where (U.Semestr = Convert(int, Left(S.Gr, 1)) * 2 - 1 
							Or U.Semestr = Convert(int, Left(S.Gr, 1)) * 2) -- из группы вычлиняем номер семестра
					And G.Dir = U.Dir
					And Not Exists
						(Select * From Balls B 
							Join Uplans U1 On B.Uplan = U.Id 
							Join Disciplines D On U.Disc = D.Id 
							Where D.Id = U.Disc And S.Id = B.St))
Go
Select * From Students_complete_all
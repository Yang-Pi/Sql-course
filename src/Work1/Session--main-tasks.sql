USE UpdtSession
GO
--4.10
Select St.FIO, Count(Distinct Upl.Disc) CD From Balls B, Students St, Uplans Upl
	Where B.St = St.Id
	AND B.Uplan = Upl.Id
	Group By St.FIO Having Count(Distinct Upl.Disc) > 1

--3.1
Select Distinct Dir.Id, Dir.Title From Balls B
	Join Uplans Upl
	On B.Uplan = Upl.Id
	And B.Ball > 2
	Join Directions Dir
	On Upl.Dir = Dir.Id

--3.2
Select Distinct Disc.Title From Uplans Upl
	Join Disciplines Disc
	On Upl.Disc = Disc.Id
	And Upl.Semestr = 1

--3.3
Select St.Gr, Count(Distinct B.St) StCount From Balls B
	Join Students St
	On B.St = St.Id
	Group By St.Gr Having Count(Distinct B.St) >= 1

Select St.Gr, Count(Distinct B.St) From Balls B
	Join Students St
	On B.St = St.Id
	Group By St.Gr

--3.4
Select Distinct Disc.Title Discipline, B.St Student_Id From Balls B
	Join Uplans Upl
	On B.Uplan = Upl.Id
	Join Disciplines Disc
	On Upl.Disc = Disc.Id
	Order By Disc.Title

--3.5
Select Gr.Id From Groups Gr
	Where Gr.Quantity > 0

--3.6
(Select St.Gr From Balls B, Students St, Uplans Upl
	Where B.St = St.Id
	AND B.Uplan = Upl.Id
	Group By St.Gr Having Count(Distinct Upl.Disc) > 1)
Union
((Select Distinct St.Gr From Students St)
 Except
 (Select Distinct St.Gr From Balls B
	 Join Students St
	 On B.St = St.Id))

--3.7
Select Distinct Disc.Id, Disc.Title From Uplans Upl
	Join Disciplines Disc
	On Upl.Disc = Disc.Id
	And Upl.Semestr Between 1 And 2

Select Distinct Disc.Id, Disc.Title, Upl.Semestr From Uplans Upl
	Join Disciplines Disc
	On Upl.Disc = Disc.Id
	And Upl.Semestr Between 1 And 2

--3.8
Select Gr.Id, Gr.Quantity From Groups Gr
	Join Students St 
	On Gr.Id <> St.Gr
	And St.Id = 1

--3.9
Select St.FIO, MIN(B.Ball) From Balls B
	Right Join Students St
	On St.Id = B.St
	Group By St.FIO

Select St.FIO, MIN(B.Ball) From Students St
	Join Balls B
	On St.Id = B.St
	Group By St.FIO

--3.10
Select Dir.Id, Dir.Title, Count(Distinct St.Id) Amount From Directions Dir
	Join Groups Gr On Dir.Id = Gr.Dir
	Join Students St On Gr.Id = St.Gr
	Join Balls B On St.Id = B.St And B.Ball = 5
	Group By Dir.Title, Dir.Id

--4.1
Select St.FIO From Students St
	Where (Select Count(Distinct Upl.Disc) From Uplans Upl
		Join Balls B
		On Upl.Id = B.Uplan
		And St.Id = B.St) = 1

--4.2
Select St.FIO From Students St
Except
Select St.FIO From Students St
	Join Balls B On St.Id = B.St

--4.3
Select Distinct Gr.Id From Groups Gr
	Join Students St On St.Gr = Gr.Id
	Join 
		(Select Distinct B.St St From Disciplines Disc 
			Join Uplans Upl On Disc.Id = Upl.Disc And Upl.Semestr = 1
			Join Balls B On Upl.Id = B.Uplan
			Join Balls B2 On B.St = B2.St
			Group By B.St Having 
				Count(Distinct Disc.Id) = 
					(Select Count(Distinct Disc.Id) From Uplans Upl
						Join Disciplines Disc On Upl.Disc = Disc.Id And Upl.Semestr = 1)
		) T1 On T1.St = St.Id 
	Group By Gr.Id

--Первая версия рабочего запроса
Select Distinct Gr.Id From 
	(Select Distinct B.St St, Disc.Id Disc From Disciplines Disc 
		Join Uplans Upl On Disc.Id = Upl.Disc And Upl.Semestr = 1
		Join Balls B On Upl.Id = B.Uplan
		Join Balls B2 On B.St = B2.St) As T1
	Join Students St On T1.St = St.Id
	Join Groups Gr On St.Gr = Gr.Id
	Group By Gr.Id Having 
		Count(T1.Disc) = (
			Select Count(Distinct Disc.Id) From Uplans Upl
				Join Disciplines Disc On Upl.Disc = Disc.Id And Upl.Semestr = 1)

--4.4
Select Gr.Id From Groups Gr
	Join Students St On Gr.Id = St.Gr
	Join ((Select St.Id From Students St) Except (Select B.St From Balls B)) BadSt
	On St.Id = BadSt.Id
	Group By Gr.Id

--4.5
(Select Disc.Title From Disciplines Disc)
Except
(Select Disc.Title From Disciplines Disc
	Join Uplans Upl
	On Disc.Id = Upl.Disc
	And Upl.Dir = 231000)

--4.6
(Select Disc.Title From Disciplines Disc)
Except
(Select Disc.Title From Disciplines Disc
	Join Uplans Upl On Disc.Id = Upl.Disc And Upl.Dir = 231000
	Join Balls B On Upl.Id = B.Uplan)

--4.7
Select Gr.Id From Groups Gr
	Join Students St On Gr.Id = St.Gr
	Group By Gr.Id 
	Having Count (*) = 
		(Select Count(*) From Groups Gr2
		Join Students St On Gr2.Id = St.Gr
		Join Balls B On St.Id = B.St
		Join Uplans Upl On B.Uplan = Upl.Id And Upl.Disc = 1
		Where Gr2.Id = Gr.Id
		Group By Gr2.Id)

Select Distinct Gr.Id From Groups Gr
	Where Not Exists 
		(Select * From Students St
			Where St.Gr = Gr.Id
			And Not Exists 
				(Select Distinct B.St From Balls B
					Join Uplans Upl On B.Uplan = Upl.Id
					Join Disciplines Disc On Upl.Disc = Disc.Id And Disc.Title = 'Физика'
					Where B.St = St.Id))

--4.8
Select Distinct Gr.Id, Count(*) From 
	(Select Distinct B.St St, Count(Distinct Disc.Id) Disc From Disciplines Disc 
		Join Uplans Upl On Disc.Id = Upl.Disc And Upl.Semestr = 1
		Join Balls B On Upl.Id = B.Uplan
		Join Balls B2 On B.St = B2.St
		Group By B.St Having 
			Count(Distinct Disc.Id) = 
				(Select Count(Distinct Disc.Id) From Uplans Upl
					Join Disciplines Disc On Upl.Disc = Disc.Id And Upl.Semestr = 1)) As T1
	Join Students St On T1.St = St.Id
	Join Groups Gr On St.Gr = Gr.Id
	Group By Gr.Id Having
		Count(*) = 
			(Select Count(*) From Groups Gr2
				Join Students St2 On Gr2.Id = St2.Gr And Gr2.Id = Gr.Id)

--4.9
Select Distinct St.FIO From Students St
	Join Balls B On St.Id = B.St
	Where (Select MIN(B.Ball) From Balls B Where B.St = St.Id) > 3

--4.10
Select St.FIO, Count(*) Amount From Students St
	Join Balls B
	On St.Id = B.St
	Group By St.FIO
	Having Count(*) = 
		(Select Max(T1.Amount) From 
			(Select Count(*) Amount From Balls B2 Group By B2.St) T1)
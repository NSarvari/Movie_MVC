# Описание на проекта
I.	Проектът е направен за цел потребителите да разгледат различни интересни филми, известни актьори и режисьорите на всеки филм.
Има login и register страници, както и две роли administrator и user, като админът има право да добави, редактира и изтрие данни, а  user само може да разгледа информациите.

II.	Проектът съдържа три библиотеки: 
1)	DataStructure, която съдържа седем модела(класове):
a)	Класът Model, който е базов клас и всички други модели(класове) го наследяват.
b)	Класът Actor, който съдържа информация за героите.
c)	Класът Movie, който съдържа информация за филимите.
d)	Класът Director, който съдържа информация за режисьорите.
e)	Класът Contact, който съдържа телефонен номер и e-mail за връзка .
f)	Класът MovieActor, който свързва клас Movie с Actor за релация много към много.
g)	Класът MovieDirector, който свързва клас Movie с Director за релация много към много.
2)	DataAccess, която съдържа migrations и ApplicationDbContext-а.
a)	ApplicationDbContext, наследява класът IdentityDbContext и съдържа връзка към всеки модел (клас).
3)	MovieReviews, която съдържа два viewModel-а: AllDirectorsViewModel и AllMoviesViewModel, седем контролера и view-та. Всички седем контролера наследяват базовият клас контролер и те са:
a)	ActorsController
b)	MoviesController
c)	DirectorsController
d)	ContactsController
e)	HomeController
f)	MovieDirectorsController


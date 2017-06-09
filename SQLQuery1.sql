﻿use [aspnet-homeless_pets-20170524112207];
drop table Pets;
create table Pets
	([PetID] bigint primary key identity(1,1) NOT NULL,
	[tel] nvarchar(20) NOT NULL,
	[Сastrated] bit NULL,
	[Type] nvarchar(20) NOT NULL,
	[Gender] bit NOT NULL,
	[Name] nvarchar(50) NOT NULL,
	[ConditionsAccept] nvarchar(max) NOT NULL,
	[Age] nvarchar(20) NOT NULL,
	[Wool] nvarchar(50) NOT NULL,
	[Colour] nvarchar(20) NOT NULL,
	[Character] nvarchar(max) NOT NULL,
	[Food] nvarchar(max) NOT NULL,
	[WC] bit NOT NULL,
	[CheckedOut] nvarchar(max) NOT NULL,
	[Address] nvarchar(100) NOT NULL,
	[Des] nvarchar(max) NULL,
	[Img] nvarchar(max) NULL);


insert into Pets(tel, [Сastrated], [Type], Gender, Name, ConditionsAccept, Age, Wool, Colour, [Character], Food, WC, CheckedOut, [Address], [Des], Img)
Values
(N'+375-29-121-34-87', 0, N'Кошка', 1, N'Маруся', N'в квартирау', N'около года', N'Короткошерстный', N'Чёрный', N'активная, дружелюбная, пока спокойная, общительная, любит ласку', N'сухой корм для котят Hills, натуральные продукты', 1, N'<ul><li>проверка на микроспорию 26.12.2016 (-)</li><li>обработка от блох - не требуется</li><li>обработка от глистов - дронтал 01.02.2017, </li><li>обработка от ушного клеща - стронгхолд 24.02.2017</li></ul>', N'пр.Любимова',N'Котенок в дар для ценителей классики. Идеальный котенок для любителей фортепианной музыки. Окрас как у клавишей фоно, музыкальный голос, великолепные манеры, прекрасное здоровье - и это все котенок Брамс. Малыш ходит исключительно в лоток с бетонитовым наполнителем, освоил когтеточку-столбик и картонную. Кушает сухой Royal Canin для котят, кошачьи консервы, пресервы, курицу, творожок. Брамс очень активный, игривый, общительный, уверенный в себе, ладит с другими котами, ласковый с человеком, но с руками играет и покусывает, обожает перебирать лапками ваши волосы, мурчит не переставая. Он будет идеальным другом и членом семьи для активных людей.', N'/Images/Cats/Marusa/1.jpg;/Images/Cats/Marusa/2.jpg;/Images/Cats/Marusa/3.jpg;/Images/Cats/Marusa/4.jpg;/Images/Cats/Marusa/5.jpg'
),
(N'+375 29 984 39 00', 1, N'Кот', 0, N'Палпи', N'в квартиру', N'около месяца', N'Полупушистый', N'Белый', N'ласковый, хороший', N'сухой корм Роял Канин, натуральная пища, пресервы', 0 , N'<ul><li>проверка на микроспорию - 29.05.2017 (-)</li><li>обработка от блох - нет необходимости</li><li>обработка от глистов - 31.05.2017 (дронтал)</li><li>обработка от ушного клеща - нет необходимости</li></ul>', N'п. Дружный, Пуховичский р-н, Минская обл., ул. Шамановского / возможна доставка в Минск', N'', N'/Images/Cats/Palpi/1.jpg;/Images/Cats/Palpi/2.jpg;/Images/Cats/Palpi/3.jpg'
),
(N'+375 29 984 39 00', 1, N'Кошка', 1, N'Малпи', N'в квартиру', N'около месяца', N'пушистый', N'Тигровый', N'ласковый, хороший', N'сухой корм Роял Канин, натуральная пища, пресервы', 0 , N'<ul><li>проверка на микроспорию - 29.05.2017 -</li><li>обработка от блох - нет необходимости</li><li>обработка от глистов - 31.05.2017 дронтал</li><li>обработка от ушного клеща - нет необходимости</li></ul>', N'п. Дружный, Пуховичский р-н, Минская обл., ул. Шамановского', N'', N'/Images/Cats/Malpi/1.jpg;/Images/Cats/Malpi/2.jpg'
),
(N'+375 29 676-85-00', 0, N'Кот', 0, N'Баден', N'в квартиру, в семью без деток дошкольного возраста.', N'около года', N'Короткошерстный', N'Рыжий', N'милый сердцу мурлыка и няшный котик', N'сухой корм и пресервы премиум класса Royal Canin , кисло-молочная и куриная продукция', 1, N'<ul><li>проверка на микроспорию – 01.02.2017г. -, 03.03.2017г. -;</li><li>обработка от блох - 01.02.2017г. капли на холку Адвантейдж;</li><li>обработка от ушных клещей – не требовалась;</li><li>дегельминтизация – 13.02.2017г. таблетки Каниквантел, 27.02.2017г. таблетки Каниквантел;</li></ul>', N'ул.Кижеватова', N'', N'/Images/Cats/Baden/1.jpg;/Images/Cats/Baden/2.jpg;/Images/Cats/Baden/3.jpg;/Images/Cats/Baden/4.jpg;/Images/Cats/Baden/5.jpg;/Images/Cats/Baden/6.jpg;/Images/Cats/Baden/7.jpg;/Images/Cats/Baden/8.jpg;/Images/Cats/Baden/9.jpg;/Images/Cats/Baden/10.jpg'
);
<h2>Периодическая загрузка событий из журналов регистрации ИБ 1С:Предприятие 8 в базу MS SQL Server/MySQL или индекс ElasticSearch</h2>
Описание http://infostart.ru/public/182820/
Порядок работы:

1) На сервере MS SQL создать пустую базу данных.

2) На сервере приложений 1С, из БД которого нужно грузить события, под административными правами запустить EventLogLoaderManager.exe

3) Указать строку соединения с базой.

Можно использовать шаблоны:
для windows-авторизации Data Source=MSSQL1;Server=имя сервера;Database=имя базы;Integrated Security=true;
для обычной авторизации  Data Source=MSSQL1;Server=имя сервера;Database=имя базы;Password=Пароль;User ID=Имя пользователя;

4) Указать интервал между циклами чтения событий из ЖР. Допустимо ставить несколько секунд - на производительности сервера не скажется.

5) Отметить те БД, события из которых необходимо периодически загружать в базу.

6) Нажать «Сохранить параметры», при этом в каталоге программы создается файл настроек setting.ini

7) Если нужна периодическая загрузка – нажимаем «Установить службу», ищем в списке служб «EventLog loader service» и исправляем аккаунт, от имени которого будет работать служба. Если строка соединения содержит логин и пароль, то можно ничего не менять, если нет, то службу нужно запускать от имени правильной учетной записи windows, которая имеет полные права на SQL-базу с событиями.

8) Если нужна разовая загрузка – запускаем из каталога программы EventLogLoader.exe. Следует учесть, что это приложение, как и служба, работает в бесконечном цикле (проверяет новые события, пишет их в базу, делает паузу, затем повторяет заново), поэтому прерывается она при нажатии любой кнопки мыши.

 

 
Некоторые особенности

1)      Для каждой ИБ журнал регистрации грузится в отдельном потоке. Если начнете грузить по сотне баз, то велика вероятность на начальном этапе повесить сервер. В дальнейшем, если проверять новые события достаточно часто (например, каждые 10 секунд), то служба быстро их записывает в базу без особой загрузки сервера.

2)      Если загрузку прервать, то при повторном запуске она продолжится с места остановки (позиция сохраняется в БД).

3)      Таблицы в БД создаются автоматически. Если вы удалили какая-нибудь таблицу - надо перезапустить службу.

4)      Все события по всем ИБ хранятся в одной таблице. Разделитель – колонка «Код информационной базы».

5)      Логи с ошибками хранятся в каталоге программы в папке «log».

6)      Работает только с платформой 8.2 (файлами lgf и lgp).

7)      В таблицах созданы только основные кластерные индексы по полю "Код информационной базы". Для ускорения запросов, которые вам требуются регулярно, нужно добавлять свои индексы.

8)      Несколько полей осталось нераспознанными (Field2, Field7, Field8). Если вам известно их назначение - сообщите, пожалуйста.

 
Описание таблиц

 

1) Infobases - список обрабатываемых ИБ. Код генерируется автоматически при добавлении новой базы в этот список. Эти же коды определяют принадлежность записей в определенной ИБ во всех других таблицах.

2) Params - хранит последние прочитанные файлы и позиции в них.

3) Назначение остальных таблиц понятно из их названия. Итоговая таблица  с событиями с присоединенными справочниками

SELECT     TOP (1000) Infobases.Name, Events.DateTime, Events.TransactionStatus, Events.TransactionStartTime, Events.TransactionMark,
                      Users.Name AS [User], Computers.Name AS Computer, Applications.Name AS App, Events.Field2, EventsType.Name AS EventType,
                      Events.EventType, Events.Comment, Metadata.Name AS Metadata, Events.DataStructure, Events.DataString,
                      Servers.Name AS [Server], MainPorts.Name AS MainPort, SecondPorts.Name AS SecondPort, Events.Seance
FROM         Events INNER JOIN
                      Applications ON Events.InfobaseCode = Applications.InfobaseCode AND Events.AppName = Applications.Code INNER JOIN
                      Computers ON Events.InfobaseCode = Computers.InfobaseCode AND Events.ComputerName = Computers.Code INNER JOIN
                      EventsType ON Events.InfobaseCode = EventsType.InfobaseCode AND Events.EventID = EventsType.Code INNER JOIN
                      Infobases ON Events.InfobaseCode = Infobases.Code INNER JOIN
                      Users ON Events.InfobaseCode = Users.InfobaseCode AND Events.UserName = Users.Code INNER JOIN
                      SecondPorts ON Events.InfobaseCode = SecondPorts.InfobaseCode AND Events.SecondPortID = SecondPorts.Code INNER JOIN
                      Servers ON Events.ServerID = Servers.Code AND Events.InfobaseCode = Servers.InfobaseCode INNER JOIN
                      MainPorts ON Events.InfobaseCode = MainPorts.InfobaseCode AND Events.MainPortID = MainPorts.Code INNER JOIN
                      Metadata ON Events.InfobaseCode = Metadata.InfobaseCode AND Events.MetadataID = Metadata.Code

 
Объемы получаемой информации

Хранение структурированных данных более затратное с точки зрения требуемого места на дисках.
Иными словами - объем базы данных будет существенно больше суммы объемов всех ЖР, которые были обработаны и загружены.

Реальный пример:

2 информационные базы с объемом ЖР 2132 Мб (1192+971).  Время первичного разбора в 2 потока (т.к. базы 2) - около 1,5 часов.

Общее количество событий - 19'507'484 млн.

Объем базы на MS SQL Server - 12879 Мб, т.е. примерно в 6 раз больше!

НО - если применить сжатие таблиц, как, например, описано здесь, то получим 1610 Мб, т.е. даже меньше исходных данных.
К сожалению, не все версии MS SQL Server поддерживают сжатие.

 

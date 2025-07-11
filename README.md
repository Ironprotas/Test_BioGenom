# Test_BioGenom

## Диаграма db

*UserEntity*

    Id (PK) 
    Name
    Email 
	Questionnaires (UserQuestionnaireEnity)
	HealthStatistics (List<UserHealthStatistics>)
    /// etc.

*UserQuestionnaireEnity*

    Id (PK)
    UserId(FK -> user.Id)
    User (navigation)
    /// fields questionnaire
  
	
*UserHealthStatistics*

    Id (PK)
    UserId(FK -> user.Id)
    User (navigation)
    AddAt (added data)
    VitamineC
    VitamineD
    Water
    /// etc


## Описание
- Созданы модели UserEntity, UserQuestionnaireEnity и UserHealthStatistics. Определены связи между таблицами. Пользователь связан c одной анкетой и множеством записей статистики здоровья.

- Создан Web API контроллер, разделённый по ответственности, который через внедрение зависимости (IIndividualReportRepository) обращается к репозиторию для получения данных.

- В репозитории реализован метод GetDailyIntake, который асинхронно извлекает из базы данных последнюю запись статистики здоровья пользователя с использованием AsNoTracking() для повышения производительности, так как данные только читаются и не предполагается их изменение.


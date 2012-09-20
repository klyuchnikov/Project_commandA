using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Security;

namespace ServiceSportsmens
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceData" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceData
    {
        [OperationContract]
        bool Auth(string login, string pass);

        [OperationContract]
        bool AuthSuperAdmin(string login, string pass);

        [OperationContract]
        Users AddUser(string firstName, string name, string patronumic, DateTime dateBirth, string login, string pass, out MembershipCreateStatus status, int coachId);

        [OperationContract]
        Users EditUser(int userId, string firstName, string name, string patronumic, DateTime dateBirth, int coachId);

        [OperationContract]
        bool DeleteUser(int userId);

        [OperationContract]
        Sports AddSport(string name);

        [OperationContract]
        Sports EditSport(int id, string name);

        [OperationContract]
        bool DeleteSport(int id);


        [OperationContract]
        Discipline AddDiscipline(string name, int sportId, int scaleId, string description);

        [OperationContract]
        Discipline EditDiscipline(int disciplineId, string name, int sportId, int scaleId, string description);

        [OperationContract]
        bool DeleteDiscipline(int disciplineId);

        [OperationContract]
        Goals AddGoal(int disciplineId, short periodDays, double value, string description, int ownerId);

        [OperationContract]
        Goals EditGoal(int GoalId, int disciplineId, short periodDays, double value, string description, int ownerId);

        [OperationContract]
        bool DeleteGoal(int GoalId);

        [OperationContract]
        Users_Goals AddUsers_Goals(int userId, int goalId, DateTime dateStart);

        [OperationContract]
        Users_Goals EditUsers_Goals(int Users_GoalsId, int userId, int goalId, DateTime dateStart);

        [OperationContract]
        bool DeleteUsers_Goals(int Users_GoalsId);

        [OperationContract]
        Users_Data AddUsers_Data(int user_goalId, DateTime date, double value);

        [OperationContract]
        Users_Data EditUsers_Data(int user_dataId, int user_goalId, DateTime date, double value);

        [OperationContract]
        bool DeleteUsers_Data(int user_dataId);

        [OperationContract]
        Standart_Data AddStandart_Data(double value, int goalId, short day);

        [OperationContract]
        Standart_Data EditStandart_Data(int standart_dataId, double value, int goalId, short day);

        [OperationContract]
        bool DeleteStandart_Data(int standart_dataId);

        [OperationContract]
        Users[] GetAllUsers();

        [OperationContract]
        Users GetUserFromId(int userId);

        [OperationContract]
        Scales[] GetAllScales();

        [OperationContract]
        Sports[] GetAllSports();

        [OperationContract]
        Discipline[] GetDiscipliniesFromSport(int sportId);

        [OperationContract]
        Goals[] GetGoalsFromDiscipline(int disciplineId);

        [OperationContract]
        Users_Goals[] GetUsers_GoalsFromUser(int userId, int goalId);

        [OperationContract]
        Users[] GetUsersFromGoal(int goalId);

        [OperationContract]
        bool AddCoachToUser(int userId, int coachId);

        [OperationContract]
        bool SetUserCoach(int userId, bool isCoach);

        [OperationContract]
        Users_Goals GetUsers_GoalsFromUserAndDiscipline(int userId, int disciplineId);

        [OperationContract]
        Standart_Data[] GetStandart_DataFromGoal(int goalId);

        [OperationContract]
        Users_Data[] GetUsers_DataFromGoal(int goalId);

        [OperationContract]
        Users[] GetAllCoachs();

        [OperationContract]
        aspnet_Users Getaspnet_Users(Guid aspnetuserId);

        [OperationContract]
        Users GetUserFromLogin(string login);
    }
}

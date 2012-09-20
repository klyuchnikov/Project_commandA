using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Security;

namespace ServiceSportsmens
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceData" в коде и файле конфигурации.
    public class ServiceData : IServiceData
    {
        private DСDataContext db;

        public ServiceData()
        {
            db = new DСDataContext();

        }

        public bool Auth(string login, string pass)
        {
            var res = Membership.ValidateUser(login, pass);
            return res;
        }

        public Users AddUser(string firstName, string name, string patronumic, DateTime dateBirth, string login, string pass, out MembershipCreateStatus status, int coachId)
        {
            var res = Membership.CreateUser(login, pass, "", "0", "0", true, out status);
            if (status == MembershipCreateStatus.Success)
            {
                db.Users.InsertOnSubmit(new Users
                {
                    AspnetUserId = db.aspnet_Users.Single(a => a.UserName == login).UserId,
                    FirstName = firstName,
                    DateBirth = dateBirth,
                    Name = name,
                    Patronumic = patronumic,
                    Right = 1,
                    CoachId = coachId
                });
                db.SubmitChanges();
                var user = db.Users.Single(a => a.AspnetUserId == db.aspnet_Users.Single(q => q.UserName == login).UserId);
                return user;
            }
            return null;
        }


        public Users EditUser(int userId, string firstName, string name, string patronumic, DateTime dateBirth, int coachId)
        {
            var user = db.Users.SingleOrDefault(a => a.Id == userId);
            if (user != null)
            {
                user.FirstName = firstName;
                user.Name = name;
                user.Patronumic = patronumic;
                user.DateBirth = dateBirth;
                  user.CoachId =coachId;
                db.SubmitChanges();
            }
            return user;
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                db.Users.DeleteOnSubmit(db.Users.Single(a => a.Id == userId));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Sports AddSport(string name)
        {
            try
            {
                var sport = new Sports() { Name = name };
                db.Sports.InsertOnSubmit(sport);
                db.SubmitChanges();
                return sport;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Sports EditSport(int id, string name)
        {
            try
            {
                var sport = db.Sports.Single(a => a.Id == id);
                sport.Name = name;
                db.SubmitChanges();
                return sport;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteSport(int id)
        {
            try
            {
                db.Sports.DeleteOnSubmit(db.Sports.Single(a => a.Id == id));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Discipline AddDiscipline(string name, int sportId, int scaleId, string description)
        {
            try
            {
                var d = new Discipline();
                d.Description = description;
                d.Name = name;
                d.ScaleId = scaleId;
                d.SportId = sportId;
                db.Discipline.InsertOnSubmit(d);
                db.SubmitChanges();
                return d;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Discipline EditDiscipline(int disciplineId, string name, int sportId, int scaleId, string description)
        {
            try
            {
                var d = db.Discipline.Single(a => a.Id == disciplineId);
                d.Description = description;
                d.Name = name;
                d.ScaleId = scaleId;
                d.SportId = sportId;
                db.Discipline.InsertOnSubmit(d);
                db.SubmitChanges();
                return d;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteDiscipline(int disciplineId)
        {
            try
            {
                db.Discipline.DeleteOnSubmit(db.Discipline.Single(a => a.Id == disciplineId));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Goals AddGoal(int disciplineId, short periodDays, double value, string description, int ownerId)
        {
            try
            {
                var g = new Goals();
                g.Description = description;
                g.DisciplineId = disciplineId;
                g.PeriodDays = periodDays;
                g.Value = value;
                g.OwnerId = ownerId;
                db.Goals.InsertOnSubmit(g);
                db.SubmitChanges();
                return g;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Goals EditGoal(int GoalId, int disciplineId, short periodDays, double value, string description, int ownerId)
        {
            try
            {
                var g = db.Goals.Single(a => a.Id == GoalId);
                g.Description = description;
                g.DisciplineId = disciplineId;
                g.PeriodDays = periodDays;
                g.Value = value;
                g.OwnerId = ownerId;
                db.SubmitChanges();
                return g;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteGoal(int GoalId)
        {
            try
            {
                db.Goals.DeleteOnSubmit(db.Goals.Single(a => a.Id == GoalId));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Users_Goals AddUsers_Goals(int userId, int goalId, DateTime dateStart)
        {
            try
            {
                var user_goal = new Users_Goals();
                user_goal.DateStart = dateStart;
                user_goal.GoalId = goalId;
                user_goal.UserId = userId;
                db.Users_Goals.InsertOnSubmit(user_goal);
                db.SubmitChanges();
                return user_goal;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Users_Goals EditUsers_Goals(int Users_GoalsId, int userId, int goalId, DateTime dateStart)
        {
            try
            {
                var user_goal = db.Users_Goals.Single(a => a.Id == Users_GoalsId);
                user_goal.DateStart = dateStart;
                user_goal.GoalId = goalId;
                user_goal.UserId = userId;
                db.SubmitChanges();
                return user_goal;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteUsers_Goals(int Users_GoalsId)
        {
            try
            {
                db.Users_Goals.DeleteOnSubmit(db.Users_Goals.Single(a => a.Id == Users_GoalsId));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Users_Data AddUsers_Data(int user_goalId, DateTime date, double value)
        {
            try
            {
                var user_data = new Users_Data();
                user_data.Date = date;
                user_data.User_GoalId = user_goalId;
                user_data.Value = value;
                db.Users_Data.InsertOnSubmit(user_data);
                db.SubmitChanges();
                return user_data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Users_Data EditUsers_Data(int user_dataId, int user_goalId, DateTime date, double value)
        {
            try
            {
                var user_data = db.Users_Data.Single(a => a.Id == user_dataId);
                user_data.Date = date;
                user_data.User_GoalId = user_goalId;
                user_data.Value = value;
                db.SubmitChanges();
                return user_data;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteUsers_Data(int user_dataId)
        {
            try
            {
                db.Users_Data.DeleteOnSubmit(db.Users_Data.Single(a => a.Id == user_dataId));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Users[] GetAllUsers()
        {
            try
            {
                return db.Users.Where(a => a.Right != 3).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Users GetUserFromId(int userId)
        {
            try
            {
                return db.Users.Single(a => a.Id == userId);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Scales[] GetAllScales()
        {
            try
            {
                return db.Scales.ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Sports[] GetAllSports()
        {
            try
            {
                return db.Sports.ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Discipline[] GetDiscipliniesFromSport(int sportId)
        {
            try
            {
                return db.Discipline.Where(a => a.SportId == sportId).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Goals[] GetGoalsFromDiscipline(int disciplineId)
        {
            try
            {
                return db.Goals.Where(a => a.DisciplineId == disciplineId).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Users_Goals[] GetUsers_GoalsFromUser(int userId, int goalId)
        {
            try
            {
                return db.Users_Goals.Where(a => a.UserId == userId && a.GoalId == goalId).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Users[] GetUsersFromGoal(int goalId)
        {
            try
            {
                return db.Users_Goals.Where(a => a.GoalId == goalId).Select(a => a.Users).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool AddCoachToUser(int userId, int coachId)
        {
            try
            {
                var user = db.Users.Single(a => a.Id == userId);
                user.CoachId = coachId;
                db.SubmitChanges();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetUserCoach(int userId, bool isCoach)
        {
            try
            {
                db.Users.Single(a => a.Id == userId).Right = isCoach ? (byte)2 : (byte)1;
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            { return false; }
        }

        public Users_Goals GetUsers_GoalsFromUserAndDiscipline(int userId, int disciplineId)
        {
            try
            {
                return db.Users_Goals.Single(a => a.UserId == userId && a.Goals.DisciplineId == disciplineId);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Standart_Data[] GetStandart_DataFromGoal(int goalId)
        {
            try
            {
                return db.Standart_Data.Where(a => a.GoalId == goalId).ToArray();
            }
            catch (Exception e)
            {
                return null;

            }
        }

        public Users_Data[] GetUsers_DataFromGoal(int goalId)
        {
            try
            {
                return db.Users_Data.Where(a => a.Users_Goals.GoalId == goalId).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public Standart_Data AddStandart_Data(double value, int goalId, short day)
        {
            try
            {
                var stand = new Standart_Data();
                stand.GoalId = goalId;
                stand.Day = day;
                stand.Value = value;
                db.Standart_Data.InsertOnSubmit(stand);
                db.SubmitChanges();
                return stand;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Standart_Data EditStandart_Data(int standart_dataId, double value, int goalId, short day)
        {
            try
            {
                var stand = db.Standart_Data.Single(a => a.Id == standart_dataId);
                stand.GoalId = goalId;
                stand.Day = day;
                stand.Value = value;
                db.SubmitChanges();
                return stand;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool DeleteStandart_Data(int standart_dataId)
        {
            try
            {
                db.Standart_Data.DeleteOnSubmit(db.Standart_Data.Single(a => a.Id == standart_dataId));
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Users[] GetAllCoachs()
        {
            try
            {
                return db.Users.Where(q => q.Right == 2).ToArray();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public aspnet_Users Getaspnet_Users(Guid aspnetuserId)
        {
            return db.aspnet_Users.Single(a => a.UserId == aspnetuserId);
        }

        public Users GetUserFromLogin(string login)
        {
            try
            {
                return db.Users.Single(a => a.aspnet_Users.UserName == login);
            }
            catch (Exception e)
            {
                return null;
            }
        }


        public bool AuthSuperAdmin(string login, string pass)
        {
            var res = Membership.ValidateUser(login, pass);
            if (res)
            {
                if (db.Users.Single(a => a.aspnet_Users.UserName == login).Right == 3)
                    return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Windows.Forms;

namespace Superadmin
{
    /// <summary>
    /// Модель данных
    /// </summary>
    [Serializable]
    public class Model
    {

        [NonSerialized]
        public ServiceConnectServer.ServiceDataClient client;

        private Model()
        {
            client = new ServiceConnectServer.ServiceDataClient();
        }


        private static Model instance;
        public static Model Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Model();
                }
                return instance;
            }
        }

        public static bool AuthorizationSuperAdmin(string login, string pass)
        {
            try
            {
                var res = Model.Instance.client.AuthSuperAdmin(login, pass);
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show("Нет соединения с сервером.");

                return false;
            }

        }
    }
}
namespace Superadmin.ServiceConnectServer
{
    public partial class Users
    {
        public override string ToString()
        {
            return this.FirstName + " " + this.Name + " " + this.Patronumic;
        }
    }
}
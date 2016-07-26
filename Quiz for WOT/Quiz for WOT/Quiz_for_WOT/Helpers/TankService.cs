using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Quiz_for_WOT.Interfaces;
using Quiz_for_WOT.Model;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace Quiz_for_WOT.Services
{
    public class TankService
    {
        private SQLiteConnection connection;
        public TankService()
        {
            
        }

        public void OpenConnection()
        {
            connection = DependencyService.Get<ISQLite>().GetConnection();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public IEnumerable<Tank> GetItems()
        {
            return (from i in connection.Table<Tank>() select i).ToList();
        }

        public Tank GetTank(int id)
        {
            //Tank tank = connection.Table<Tank>().FirstOrDefault(x => x.Id == id);
            Tank tank = connection.GetAllWithChildren<Tank>(x => x.Id == id).FirstOrDefault();
           // tank.Nation = connection.Table<Nation>().FirstOrDefault(x => x.Id == tank.NationId);
           // tank.Type = connection.Table<TankType>().FirstOrDefault(x => x.Id == tank.TypeId);
            return tank;
        }

      /*  public Tank GetTankUntil(int id)
        {
            var query = "SELECT * FROM [Tank] WHERE [Id] != " + id;
            Tank tank = connection.Query<Tank>(query).FirstOrDefault();
           // Tank tank = connection.Table<Tank>().FirstOrDefault(x => x.Id == id);
            tank.Nation = connection.Table<Nation>().FirstOrDefault(x => x.Id == tank.NationId);
            tank.Type = connection.Table<TankType>().FirstOrDefault(x => x.Id == tank.TypeId);
            return tank;
        }*/

    }
}

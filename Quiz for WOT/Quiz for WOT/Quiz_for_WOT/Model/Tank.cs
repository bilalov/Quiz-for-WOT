using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace Quiz_for_WOT.Model
{
    public class Tank
    {

        public Tank()
        {
            
        }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description_En { get; set; } = string.Empty;
    }

}

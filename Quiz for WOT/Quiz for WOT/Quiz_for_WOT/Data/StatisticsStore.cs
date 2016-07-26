using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Helpers;
using Newtonsoft.Json;

namespace Quiz_for_WOT.Data
{
    public class StatisticsStore
    {
        public static string filename = "1dgs4fgsfd454gsdt.txt";
        private FileHelper fileHelper;

        public StatisticsStore()
        {
            fileHelper = new FileHelper();
        }

        public void Unload(ScoreManager scoreManager)
        {
            scoreManager.Scores = scoreManager.Scores.OrderByDescending(x => x).ToList().Take(10).ToList();
            string str = JsonConvert.SerializeObject(scoreManager);
            fileHelper.WriteData(filename, str);
        }

        public ScoreManager Load()
        {
            string value = fileHelper.ReadData(filename);
            return JsonConvert.DeserializeObject<ScoreManager>(value);
        }
    }
}

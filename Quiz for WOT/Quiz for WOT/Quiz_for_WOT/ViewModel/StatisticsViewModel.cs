using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz_for_WOT.Data;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Interfaces;
using Quiz_for_WOT.Model;
using Newtonsoft.Json;

namespace Quiz_for_WOT.ViewModel
{
    public class StatisticsViewModel
    {
        public List<ScoreViewModel> Scores { get; set; } 
       
        public StatisticsViewModel()
        {
            Scores = new List<ScoreViewModel>();
            var count = 1;
            foreach (var score in App.ScoreManager.Scores.OrderByDescending(x=>x).ToList().Take(10))
            {
                Scores.Add(new ScoreViewModel() {Place = count,Value=score});
                count++;
            }

        }

        public class ScoreViewModel
        {
            public int Place { get; set; }
            public int Value { get; set; }
        }
        
    }
}

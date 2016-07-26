using System;
using System.Collections.Generic;
using System.Linq;
using Quiz_for_WOT.Data;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Model;

using Newtonsoft.Json;

namespace Quiz_for_WOT.Helpers
{
    public class ScoreManager
    {
        public System.Collections.Generic.List<int> Scores { get; set; } = new System.Collections.Generic.List<int>(); 

        public ScoreManager()
        {

        }

        public void AddStatictics(int score)
        {
            Scores.Add(score);
        }
    }
}

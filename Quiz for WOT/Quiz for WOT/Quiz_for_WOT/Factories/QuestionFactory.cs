using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using Quiz_for_WOT.Model;
using Quiz_for_WOT.Resx;
using Quiz_for_WOT.Services;

namespace Quiz_for_WOT.Factories
{
    public class QuestionFactory
    {
        private Random random;
        private TankService service;
        private int countTanks = 430;

        public string TrueAnswer { get; set; } = string.Empty;
        public Tank tank { get; set; }
        
        public QuestionFactory()
        {
            random = new Random();
            service = new TankService();
        }

        public Question GetQuestion(bool currentTypeQuestion)
        {
            //true - image, false - description
            if (currentTypeQuestion)
                return CreateImageQuestion();
            else return CreateDescriptionQuestion();
        }

        private Question CreateDescriptionQuestion()
        {
            Question question = new Question();

            service.OpenConnection();
            tank = service.GetTank(random.Next(1, countTanks));
            question.Answers = new string[]
            {
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
            };

            if (AppResources.Culture.Name != "ru-RU")
                question.Value = tank.Description_En;
            else question.Value = tank.Description;

            question.TrueAnswer = tank.Name;
            var trueans = random.Next(0, 3);
            question.Answers[trueans] = tank.Name;
            service.CloseConnection();

            return question;
        }

        private Question CreateImageQuestion()
        {
            Question question = new Question();
            
            service.OpenConnection();
            tank = service.GetTank(random.Next(1, countTanks));
            question.Answers = new string[]
            {
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
               service.GetTank(random.Next(1, countTanks)).Name,
            };
            question.Value = tank.Image;
            question.TrueAnswer = tank.Name;
            var trueans = random.Next(0, 3);
            question.Answers[trueans] = tank.Name;
            service.CloseConnection();

            return question;
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Quiz_for_WOT.Helpers;
using Quiz_for_WOT.Interfaces;
using Quiz_for_WOT.Model;
using Quiz_for_WOT.Services;
using Quiz_for_WOT.Data;
using Quiz_for_WOT.Factories;
using Quiz_for_WOT.Pages.Game;
using Xamarin.Forms;

namespace Quiz_for_WOT.ViewModel
{
    public class GameViewModel : ViewModelBase
    {
        //private GameProcess gameProcess;
        private readonly INavigation _navigationService;
       // private List<QuestionRequirment> listQuestionRequirments;
        private bool CurrentTypeQuestion { get; set; } = false;
        public QuestionFactory questionFactory { get; set; }

        public GameViewModel(INavigation navigationService)
        {
            _navigationService = navigationService;

            questionFactory = new QuestionFactory();
            Question = questionFactory.GetQuestion(CurrentTypeQuestion);
            CheckVisiable();
        }



        private void CheckVisiable()
        {
            switch (CurrentTypeQuestion)
            {
                case true:
                    TextQuestionFlag = false;
                    ImageQuestionFlag = true;
                break;
                case false:
                    TextQuestionFlag = true;
                    ImageQuestionFlag = false;
                    break;
            }
        }

        #region startGame

        private bool _textQuestionFlag;
        public bool TextQuestionFlag
        {
            get { return _textQuestionFlag; }

            set { Set(() => TextQuestionFlag, ref _textQuestionFlag, value); }
        }

        private int _count;
        public int Count
        {
            get { return _count; }
            set { Set(() => Count, ref _count, value); }
        }

        private int _score;
        public int Score
        {
            get { return _score; }
            set { Set(() => Score, ref _score, value); }
        }

        private Question _question;
        public Question Question
        {
            get { return _question; }

            set { Set(() => Question, ref _question, value); }
        }

        private bool _imageQuestionFlag;
        public bool ImageQuestionFlag
        {
            get { return _imageQuestionFlag; }

            set { Set(() => ImageQuestionFlag, ref _imageQuestionFlag, value); }
        } 

        private RelayCommand<string> _answerCommand;
        public RelayCommand<string> AnswerCommand
        {
            get
            {
                return _answerCommand
                    ?? (_answerCommand = new RelayCommand<string>(
                    (str) =>
                    {
                        if (Question.TrueAnswer == str)
                        {
                            Score++;
                            CurrentTypeQuestion =!CurrentTypeQuestion;
                            Question = questionFactory.GetQuestion(CurrentTypeQuestion);
                            CheckVisiable();
                            
                        }
                        else
                        {
                            
                           
                            var loseView = new LosePage();
                            _navigationService.PushAsync(loseView);  
                          
                        }

                        
                    }));
            }
        }

        private RelayCommand _giveMoneyCommand;
        public RelayCommand GiveMoneyCommand
        {
            get
            {
                return _giveMoneyCommand
                    ?? (_giveMoneyCommand = new RelayCommand(
                    () =>
                    {
                        if (Score > 0)
                        {
                            App.ScoreManager.AddStatictics(Score);
   
                            new StatisticsStore().Unload(App.ScoreManager);
                            SimpleIoc.Default.Unregister<StatisticsViewModel>();
                            
                       
                        }
                        var winGameView = new WinPage();
                        winGameView.BindingContext = Score;
                       
                        _navigationService.PushAsync(winGameView);
                    }));
            }
        }

        #endregion

    }
}

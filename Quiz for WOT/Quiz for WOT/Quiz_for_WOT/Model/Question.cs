using GalaSoft.MvvmLight;

namespace Quiz_for_WOT.Model
{
    public class Question:ObservableObject
    {
        public string[] Answers { get; set; }
        public string TrueAnswer { get; set; } 
        public string Description { get; set; }
        public string Value { get; set; }
    }

}

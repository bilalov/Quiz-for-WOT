using Quiz_for_WOT.Model.MasterDetailPage;

namespace Quiz_for_WOT.Helpers
{
    public enum MenuType
    {
        InputPage,
        About
    }
    public class HomeMenuItem : BaseModel
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.InputPage;
        }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }
    }
}

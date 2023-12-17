using PunsGame.Data;
using PunsGame.Services.Contracts;

namespace PunsGame.Services
{
    public class GameManager:IGameManager
    {
        private bool _GameStarted = false;

        public bool GameStarted 
        {
            get {return _GameStarted;}
            set {_GameStarted = value;}
        }

        public readonly List<Category> Frazes = [];
        private int _NumberOfTeams = 2; 
        public int NumberOfTeams
        {
            get {return _NumberOfTeams;}
        }

        public GameManager()
        {
            Frazes = Data.Data.Categories;
        }

        public void AddCategory(string categoryName, List<string> frazesList)
        {
            if((Frazes != null) && (Frazes.Any(category => category.CategoryName == categoryName)) && (frazesList != null))
            {
                Frazes.Add(new Category(categoryName, frazesList));
            }
        }

        public void SetNumberOfTeams(int numberOfTemas)
        {
            if(numberOfTemas >= 2 && numberOfTemas <= 5)
            {
                _NumberOfTeams = numberOfTemas;
            }
        }
    }
}
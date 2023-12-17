namespace PunsGame.Data
{
    //Hardcoded gamedata
    public static class Data
    {
        public static List<Category> Categories = new List<Category>{
            new Category("Test", new  List<string> {"Test", "Test"}),
            new Category("Test", new  List<string> {"Test", "Test"}),
            new Category("Test", new  List<string> {"Test", "Test"}),
            new Category("Test", new  List<string> {"Test", "Test"})
        };
    }

    /// <summary>
    /// Class that represents category of PunsGame fraze
    /// </summary>
    public class Category
    {
        public string CategoryName {get; set;}

        public List<string> CategoryData {get; set;}

        public Category(string categoryName, List<string> categoryData)
        {
            CategoryName = categoryName;
            CategoryData = categoryData;
        }
    }

    


}
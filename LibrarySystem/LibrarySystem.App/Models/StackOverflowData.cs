using System.Globalization;

namespace LibrarySystem.App.Models
{
    public class StackOverflowData
    {
        public List<Item> items { get; set; }

        public class Item
        {
            public double question_id { get; set; }
            public string link { get; set; }
            public string title { get; set; }
            public Owner owner { get; set; }

            public class Owner
            {
                public string display_name { get; set; }
            }
        }
    }
}

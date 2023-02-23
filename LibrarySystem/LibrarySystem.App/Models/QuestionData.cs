namespace LibrarySystem.App.Models
{
    public class QuestionData
    {
        public List<Item> items { get; set; }

        public class Item
        {
            public List<string> tags { get; set; }
            public double question_id { get; set; }
            public bool is_answered { get; set; }
            public int view_count { get; set; }
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

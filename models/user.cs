namespace ChrovaAPI
{
    public class user
    {
        private static Random _r = new Random();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public user(int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;
        }

        public static List<user> GetUsers() => new List<user>
        {
            new user(001, "Aleena West", "TrendyWest"),
            new user(002, "Josef Wilkins", "Wilkatron"),
            new user(003, "Nora McNeil", "NorAster"),
            new user(004, "Hugo Friedman", "InkyHugo"),
            new user(005, "Imani Shepherd", "ShepAsaur")
        };
    }
}

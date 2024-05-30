namespace MeetingApp.Models {
    public static class Repository {
        private static List<UserInfo> _users = new();

        static Repository() {
            _users.Add(new UserInfo() {
                Id = 1,
                Name = "Soucius Kaenj",
                Email = "souciuskaenj@gmail.com",
                Phone = "111111",
                WillAttend = true
            });

            _users.Add(new UserInfo() {
                Id = 2,
                Name = "Sean Magnus",
                Email = "seanmagnus@gmail.com",
                Phone = "111111",
                WillAttend = false
            });

            _users.Add(new UserInfo() {
                Id = 3,
                Name = "Sungerbob Squarepants",
                Email = "sungerbobsquarepants@gmail.com",
                Phone = "111111",
                WillAttend = true
            });
        }

        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user) {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id) {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
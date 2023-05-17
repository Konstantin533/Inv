namespace WebAPI
{
    public static class HelperFunctions
    {

        public static List<Person> GenerateRandomUsers(int count)
        {
            var users = new List<Person>();
            var random = new Random();

            for(int i = 0; i < count; i++)
            {
                var user = new Person();
                user.Id = Guid.NewGuid().ToString();
                user.Name = GenerateRandomName();
                user.Age = random.Next(18, 60);
                users.Add(user);
            }
            return users;
        }

        public static string GenerateRandomName()
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Emma", "Frank", "Grace", "Henry", "Isabella", "Jack" };
            var random = new Random();

            int index = random.Next(0, names.Length);
            return names[index];
        }
        
    }
}

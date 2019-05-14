namespace AutoMapperSample
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
namespace Prototype
{
    class User
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public User GetClone()
        {
            return (User)this.MemberwiseClone();
        }
    }
}

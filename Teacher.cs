namespace SimplePrototypeCSharp
{
    // ConcretePrototype2
    public class Teacher : Person
    {
        public Teacher(string name, string course) : base(name)
        {
            Course = course;
        }

        public string Course { get; set; }

        public override Person Clone(bool deepClone = false)
        {
            return (Person)MemberwiseClone();
        }
    }
}
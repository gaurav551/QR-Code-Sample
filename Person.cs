namespace Delegates
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get {return string.Concat(FirstName,LastName) ;} }
        public string Age { get; set; }
        public string Address { get; set; }
    }
}
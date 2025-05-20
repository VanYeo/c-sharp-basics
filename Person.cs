
namespace practice_dotnet
{
    public class Person
    {
        public string? FirstName;
        public string? LastName;

        public void Introduce()
        {
            Console.WriteLine("i am" + FirstName + "" + LastName);
        }
    };
}

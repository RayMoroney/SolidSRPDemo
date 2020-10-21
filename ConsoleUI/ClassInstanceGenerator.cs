
namespace ConsoleUI
{
    public static class ClassInstanceGenerator
    {
        public static IPersonModel CreatePerson()
        {
            return new PersonModel();
        }
    }
}

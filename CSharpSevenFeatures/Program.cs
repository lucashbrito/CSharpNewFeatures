using CSharpSevenFeatures.Delegate;

namespace CSharpSevenFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var outVariables = new OutVariables();

            LocalFunctions lF = new LocalFunctions();
            lF.Run();

            Exemple exemple = new Exemple();

            exemple.Main();
        }
    }
}

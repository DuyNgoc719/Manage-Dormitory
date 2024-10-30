
using doandbms.Design;
using doandbms.User;

namespace doandbms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new signIn());
        }
    }
}
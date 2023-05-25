using System;

namespace DVDLibraryApp
{
    class Program
    {
        static void Main()
        {
            DVDLibrary library = new DVDLibrary();

            library.AddDVD("The Shawshank Redemption");
            library.AddDVD("The Godfather");
            library.AddDVD("The Dark Knight");
            library.AddDVD("12 Angry Men");

            Console.WriteLine("Zaloguj się - jeśli jesteś pracownikiem, jeśli jesteś klientem, kliknij Enter");
            string userType = Console.ReadLine();

            if (userType == "admin")
            {
                AdminController.Run(library);
            }
            else
            {
                UserController.Run(library);
            }
        }
    }
}

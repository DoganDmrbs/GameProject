using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserVadidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear=1985,
                FirstName="Dogan",
                LastName="Demirbas",
                IdentitiyNumber=1234
            });
 
        }
    }
}

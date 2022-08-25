using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserVadidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1985 && gamer.FirstName=="Dogan"
               && gamer.LastName=="Demirbas" && gamer.Id == 1 &&
               gamer.IdentitiyNumber==1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    // içinde başka servis kullanıcam demek.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager ( IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}

using GameProject.Abstarct;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2020 && gamer.FirstName=="Ayşe" && gamer.LastName=="Çakır" && gamer.NatioanlyId=="12345678919" &&
                gamer.Id==1)
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

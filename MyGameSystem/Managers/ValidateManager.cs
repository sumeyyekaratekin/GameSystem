using MyGameSystem.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem.Managers
{
    class ValidateManager : IValidateService
    {
        public void Validate(Person person)
        {
            if (person.Name.Length > 2 && person.Surname.Length > 1 && person.Tc.Length == 11 
                && person.YearOfBirth > 1900 &&  person.YearOfBirth <= 2002)
            {
                Console.WriteLine(person.Name + " " + person.Surname + " identity verified.");
                PlayerManager playerManager = new PlayerManager();
                playerManager.Add(new Player());
            }
            else
            {
                Console.WriteLine(person.Name + " " + person.Surname + " Authentication failed.");

            }
        }
    }
}

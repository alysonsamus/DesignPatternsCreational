using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public sealed class CharacterFactory
    {
        public static Character CreateCharacter(string CharType, string Name, int Age) {
            
            if (CharType is null)
            {
                Console.WriteLine("Error");
            }

            Character persona = CharType switch
            {
                "F" => new Fighter(Name, Age),
                "M" => new Mage(Name, Age),
                _ => throw new ApplicationException(),
            };
            return persona;

        }
    }
}

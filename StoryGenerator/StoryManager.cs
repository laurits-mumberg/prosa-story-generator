using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using StoryGenerator.Characters;

namespace StoryGenerator
{
    public class StoryManager
    {
        public Queue<ICharacter> Characters = new Queue<ICharacter>();
        
        public void AddCharacter(ICharacter character)
        {
            if (!CharactersActive(character.GetType()))
            {
                Characters.Enqueue(character);
            }
        }

        public void RemoveCharacter(ICharacter character)
        {
            Characters = new Queue<ICharacter>(Characters.Where(x => x != character));
        }

        public ICharacter GetCharacterOfType<T>() where T : ICharacter
        {
            return Characters.OfType<T>().First();
        }
        
        public bool CharactersActive(params Type[] characterTypes)
        {
            foreach (Type characterType in characterTypes)
            {
                if (!Characters.Any((character => character.GetType() == characterType)))
                {
                    
                    return false;
                }
            }
            
            return true;
        }

        public bool OnlyCharactersActive(params Type[] checkCharacters)
        {
            if (Characters.Count != checkCharacters.Length)
            {
                return false;
            }

            return CharactersActive(checkCharacters);
        }
    }
}
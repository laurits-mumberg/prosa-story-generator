using System;

namespace StoryGenerator.Characters
{
    public class RedRidingHood : ICharacter
    {
        private StoryManager _storyManager;

        public RedRidingHood(StoryManager storyManager)
        {
            this._storyManager = storyManager;
        }
        public void React()
        {
            if(_storyManager.OnlyCharactersActive(typeof(Grandma), this.GetType())) EatPie();
            if(_storyManager.OnlyCharactersActive(typeof(Hunter), this.GetType())) Scream();
            if(_storyManager.CharactersActive(typeof(Wolf), this.GetType())) GiveWolfFlower();
        }

        private void EatPie()
        {
            Console.WriteLine("Eat pie");
            _storyManager.AddCharacter(new Fairy(_storyManager));
        }

        private void Scream()
        {
            Console.WriteLine("Scream");
            _storyManager.AddCharacter(new Grandma(_storyManager));
        }

        private void GiveWolfFlower()
        {
            Console.WriteLine("Give wolf flower");
            ((Wolf)_storyManager.GetCharacterOfType<Wolf>()).RecieveFlower();
        }
    }
}
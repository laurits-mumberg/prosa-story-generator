using System;

namespace StoryGenerator.Characters
{
    public class Wolf : ICharacter
    {
        private StoryManager _storyManager;

        public Wolf(StoryManager storyManager)
        {
            this._storyManager = storyManager;
        }
        public void React()
        {
            throw new System.NotImplementedException();
        }

        public void RecieveFlower()
        {
            Console.WriteLine("Cry");
        }
    }
}
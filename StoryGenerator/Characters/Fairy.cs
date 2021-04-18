namespace StoryGenerator.Characters
{
    public class Fairy : ICharacter
    {
        private StoryManager _storyManager;

        public Fairy(StoryManager storyManager)
        {
            this._storyManager = storyManager;
        }

        public void React()
        {
            throw new System.NotImplementedException();
        }
    }
}
namespace StoryGenerator.Characters
{
    public class Grandma : ICharacter
    {
        private StoryManager _storyManager;

        public Grandma(StoryManager storyManager)
        {
            this._storyManager = storyManager;
        }
        public void React()
        {
            throw new System.NotImplementedException();
        }
    }
}
namespace StoryGenerator.Characters
{
    public class Hunter : ICharacter
    {
        private StoryManager _storyManager;

        public Hunter(StoryManager storyManager)
        {
            this._storyManager = storyManager;
        }
        public void React()
        {
            throw new System.NotImplementedException();
        }
    }
}
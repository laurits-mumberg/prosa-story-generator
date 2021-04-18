using System;
using StoryGenerator.Characters;

namespace StoryGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryManager storyManager = new StoryManager();
            storyManager.AddCharacter(new RedRidingHood(storyManager));
            storyManager.AddCharacter(new Wolf(storyManager));

            storyManager.Characters.Peek().React();
        }
    }
}
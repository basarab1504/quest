using System.Collections.Generic;

namespace quest
{
    class Quest
    {
        List<string> reward;

        public Quest(List<string> reward)
        {
            this.reward = reward;
        }

        public void Finish(Character character)
        {
            foreach (var item in reward)
                character.Put(item);
        }
    }
}

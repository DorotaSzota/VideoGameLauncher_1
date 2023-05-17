using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VideoGame1.Program;

namespace VideoGame1
{
    internal class EventManager
    {

        private List<GameEvent> events = new List<GameEvent>();
        public void RegisterEvent(GameEvent gameEvent)
        {
            events.Add(gameEvent);
        }

        public void TriggerEvent()
        {
            foreach (GameEvent gameEvent in events)
            {
                gameEvent.Invoke();
            }
        }
    }
}

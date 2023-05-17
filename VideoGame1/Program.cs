namespace VideoGame1
{
    internal class Program
    {
        public delegate void GameEvent();
        static void Main(string[] args)
        {
            var warrior1 = new Warrior("Astravius");
            var mage1 = new Mage("Banana");
            var game1 = new GameManager<Character>();
            var eventManager1 = new EventManager();
            
            

            warrior1.Play();
            game1.StartGame(warrior1);
            eventManager1.RegisterEvent(mage1.Play);
            eventManager1.TriggerEvent();

            Console.ReadKey();
        }
    }
}
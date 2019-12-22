using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            GamesContext db = new GamesContext();

            db.Games.Add(new Game() { Name = "Tom Clancy's Rainbow Six", Genre = "Action" });
            db.Games.Add(new Game() { Name = "Assassin's Creed Odyssey", Genre = "Action/RPG" });
            db.Games.Add(new Game() { Name = "Dark Souls", Genre = "Action/RPG" });
            db.Games.Add(new Game() { Name = "Call of Duty®: Modern Warfare", Genre = "Action" });
            db.Games.Add(new Game() { Name = "Red Dead Redemption 2", Genre = "Action" });
            db.Games.Add(new Game() { Name = "Grand Theft Auto V", Genre = "Action" });
            db.Games.Add(new Game() { Name = "Supreme Commander", Genre = "RTS" });
            db.Games.Add(new Game() { Name = "Heroes of Might and Magic III", Genre = "TBS" });
            db.Games.Add(new Game() { Name = "STAR WARS Jedi: Fallen Order", Genre = "Action" });

            db.Stores.Add(new Store() { Name = "EGS", City = "Кэри(USA)", HaveSales = true });
            db.Stores.Add(new Store() { Name = "Steam", City = "Белвью(USA)", HaveSales = true });
            db.Stores.Add(new Store() { Name = "Origin", City = "Редвуд-Сити(USA)", HaveSales = false });

            db.Games_Stores.Add(new Game_Store() { GameId = 1, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 2, StoreId = 1 });
            db.Games_Stores.Add(new Game_Store() { GameId = 2, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 3, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 4, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 5, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 5, StoreId = 1 });
            db.Games_Stores.Add(new Game_Store() { GameId = 6, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 7, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 8, StoreId = 2 });
            db.Games_Stores.Add(new Game_Store() { GameId = 9, StoreId = 3 });

            db.SaveChanges();

            var gamesStores = db.Games_Stores.Join(db.Games, gs => gs.GameId, g => g.Id, (gs, g) => new { g.Name, g.Genre, gs.StoreId }).Join(db.Stores, gs => gs.StoreId, s => s.Id, (gs,s) => new {gs.Name, gs.Genre, StoreName = s.Name, s.City, s.HaveSales });

            foreach (var a in gamesStores.Where(store => store.StoreName == "Steam"))
                Console.WriteLine($"{a.Name} {a.Genre} {a.StoreName} {a.City}, Have sales = {a.HaveSales}");

            Console.ReadKey();
        }
    }
}

using ProjectV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV2.Data
{
    public class Help
    {
        public static void HelpMePLS(ProjectV2Context context)
        {
            if (!context.Games.Any())
            {
                Store store1 = new Store()
                {
                    Name = "Steam",
                    Discription = "Steam — онлайн-сервис цифрового распространения компьютерных игр и программ, " +
                    "разработанный и поддерживаемый компанией Valve. Steam выполняет роль средства технической защиты авторских прав, платформы для " +
                    "многопользовательских игр и потокового вещания, а также социальной сети для игроков.",
                    StoreLink = "https://store.steampowered.com/",
                    ImgLink = "Steam.png"
                };
                Store store2 = new Store()
                {
                    Name = "Epic Game Store",
                    Discription = "Epic Games Store — онлайн-сервис цифрового распространения компьютерных игр, разработанный и управляемый американской компанией Epic Games.",
                    StoreLink = "https://www.epicgames.com/store/ru",
                    ImgLink = "Epic.png"
                };
                Store store3 = new Store()
                {
                    ImgLink = "Origin.png",
                    Name = "Origin",
                    Discription = "Origin — платформа цифровой дистрибуции компании Electronic Arts, которая даёт возможность пользователям приобретать компьютерные игры через Интернет и загружать их с помощью клиента Origin",
                    StoreLink = "https://www.origin.com/rus/ru-ru/store"
                };
                Store store4 = new Store()
                {
                    ImgLink = "GOG.png",
                    Name = "GOG",
                    Discription = "GOG.com is a digital distribution platform with a curated selection of games, a you buy it, you own it philosophy, and utmost care about customers.",
                    StoreLink = "https://www.gog.com/"
                };

                context.Stores.AddRange(store1, store2, store3, store4);

                Studio studio1 = new Studio()
                {
                    Name = "Capcom",
                    ImgLink = "Capcom.png",
                    Foundation = 1979,
                    Discription = "Capcom Co., Ltd.  is a " +
                    "Japanese video game developer and publisher known for creating numerous multi-million selling game franchises, including Street Fighter, " +
                    "Mega Man, Resident Evil, Devil May Cry, Onimusha, Dino Crisis, Dead Rising, Sengoku BASARA, Monster Hunter, Breath of Fire, and Ace Attorney as well " +
                    "as games based on Disney animated properties. Established in 1979, it has become an international enterprise with subsidiaries in North America, Europe, and Japan."
                };
                Studio studio2 = new Studio()
                {
                    Name = "EA DICE",
                    ImgLink = "DICE.png",
                    Foundation = 1992,
                    Discription = "EA Digital Illusions Creative Entertainment или DICE — шведский разработчик компьютерных игр, полностью принадлежащий Electronic Arts. " +
                "Компания основана в 1992 году, создаёт игры для основных игровых приставок и ПК. DICE является создателем серии игр «Battlefield» и продолжает работу над ней."
                };
                Studio studio3 = new Studio()
                {
                    Name = "Ubisoft",
                    ImgLink = "Ubisoft.png",
                    Foundation = 1986,
                    Discription = "Ubisoft Entertainment SA is a French video game company headquartered in Montreuil with several development studios across the world. " +
                    "It publishes games for several video game franchises, including Assassin's Creed, Far Cry, Just Dance, Prince of Persia, Rayman, Raving Rabbids, and Tom Clancy's. As " +
                    "of March 2018, Ubisoft is the fourth largest publicly traded game company in the Americas and Europe in terms of revenue and market capitalisation, after Activision Blizzard, " +
                    "Electronic Arts, and Take-Two Interactive."
                };
                Studio studio4 = new Studio()
                {
                    Name = "CD Projekt",
                    ImgLink = "CDPR.jpg",
                    Foundation = 1994,
                    Discription = "CD Projekt S.A. is a Polish video game developer, publisher and distributor based in Warsaw, founded in May 1994 by Marcin Iwiński and Michał Kiciński. Iwiński " +
                    "and Kiciński were video game retailers before they founded the company, which initially acted as a distributor of foreign video games for the domestic market. The department" +
                    " responsible for developing original games, CD Projekt Red, best known for The Witcher series, was formed in 2002. In 2008, CD Projekt launched the digital distribution service GOG.com " +
                    "(originally as Good Old Games)."
                };

                context.Studios.AddRange(studio1, studio2, studio3, studio4);

                Game game1 = new Game()
                {
                    Name = "MONSTER HUNTER: WORLD",
                    Device = "PC",
                    Genre = "Action",
                    Discription = "Welcome to a new world! In Monster Hunter: World, the latest installment " +
                    "in the series, you can enjoy the ultimate hunting experience, using everything at your disposal " +
                    "to hunt monsters in a new world teeming with surprises and excitement.",
                    Price = 199,
                    ImgLink = "MHW.jpg",
                    Studio = studio1,
                    Store = store1,
                    BuyLink = "https://store.steampowered.com/app/582010/MONSTER_HUNTER_WORLD/"
                };
                Game game2 = new Game()
                {
                    Name = "Battlefield 1",
                    Device = "PC",
                    Genre = "Action",
                    Discription = "Battlefield™ 1 погружает вас в эпоху Первой мировой войны, когда новые " +
                    "технологии и глобальный конфликт навсегда изменили принципы военного дела. Участвуйте в каждой битве, " +
                    "управляйте каждой огромной машиной, выполняйте маневры, меняющие исход всего боя. Весь мир охвачен войной. " +
                    "Узнайте, что ждет вас на линии фронта.",
                    Price = 199,
                    ImgLink = "BF1.jpg",
                    Studio = studio2,
                    Store = store3,
                    BuyLink = "https://www.origin.com/rus/ru-ru/store/battlefield/battlefield-1"
                };
                Game game3 = new Game()
                {
                    Name = "Tom Clancy’s The Division® 2",
                    Device = "PC",
                    Genre = "Action",
                    Discription = "Washington D.C. is on the brink of collapse. Lawlessness and instability threaten our society, " +
                    "and rumours of a coup in the Capitol are only amplifying the chaos. All active Division agents are desperately needed " +
                    "to save the city before it's too late.",
                    Price = 458,
                    ImgLink = "Division2.png",
                    Studio = studio3,
                    Store = store2,
                    BuyLink = "https://www.epicgames.com/store/en-US/product/the-division-2/home?lang=en-US"
                };
                Game game4 = new Game()
                {
                    Name = "The Witcher 3: Wild Hunt",
                    Device = "PC",
                    Genre = "Action",
                    Discription = "Become a professional monster slayer and embark on an adventure of epic proportions! Upon its release, The Witcher 3: Wild Hunt " +
                    "became an instant classic, claiming over 250 Game of the Year awards. Now you can enjoy this huge, over 100-hour long, open-world adventure along" +
                    " with both its story-driven expansions worth an extra 50 hours of gameplay. This edition includes all additional content - new weapons, armor, companion outfits, " +
                    "new game mode and side quests.",
                    Price = 99,
                    ImgLink = "Witcher3.png",
                    Studio = studio4,
                    Store = store4,
                    BuyLink = "https://www.gog.com/game/the_witcher_3_wild_hunt_game_of_the_year_edition"
                };

                context.Games.AddRange(new List<Game> { game1, game2, game3, game4 });

                News_single news1 = new News_single()
                {
                    Title = "Онлайн The Witcher 3: Wild Hunt побил рекорд дополнения Blood and Wine",
                    Text = "Онлайн The Witcher 3: Wild Hunt продолжает расти. 27 декабря в RPG от CD Projekt RED одновременно играли почти 73 тыс. пользователей Steam. Этот показатель больше, чем в июне 2016 года, когда вышло дополнение " +
                    "Blood and Wine. Тогда сюжет про ведьмака проходили около 50 тыс. игроков." +
                    "Резкий скачок онлайна в The Witcher 3: Wild Hunt был зафиксирован после премьеры сериала «Ведьмак» от Netflix, которая состоялась 20 декабря.Спустя два дня после выхода шоу в RPG одновременно играли более " +
                    "48 тыс.пользователей.В ноябре пиковый показатель онлайна достиг 26 тыс.человек." +
                    "В первом сезоне сериала «Ведьмак» вышло восемь серий, которые сразу доступны подписчикам Netflix.Пользователи портала Metacritic оценили сериал 7,9 баллами из 10, а критики дали шоу 53 балла из 100.",
                    Games = game4
                };

                News_single news2 = new News_single()
                {
                    Title = "Capcom Details ‘Monster Hunter World: Iceborne’ 12.01 Update in Latest Dev Diary",
                    Text = "Capcom has released the outline for the 12.01 update for the Monster Hunter World: Iceborne expansion, which is due out on December 5 at 12:00 am PT / 3:00 am ET. It’s a big one, so check out the details on the official site. " +
                    "In addition, Capcom has released a new developer diary introducing the update’s new monsters, new Tundra Region, more Layered Armor, Seliana Fests," +
                    "and more.Meanwhile, for PlayStation 4 owners, a video that introduces all the upcoming Horizon Zero Dawn: The Frozen Wilds collaboration gear was also released.",
                    Games = game1
                };
                News_single news3 = new News_single()
                {
                    Title = "В The Division 2 появится рождественский автомат Томпсона, стреляющий снежками",
                    Text = "Обновление выйдет 10 декабря. Разработчики добавили необычный способ получения рождественского оружия: игрокам придётся убивать специальных лут-гоблинов в " +
                    "шапках Санта-Клауса, из которых выпадает автомат Томпсона. Что касается шапки Санта-Клауса, то для её получения пользователям нужно будет зайти в игру с 10 декабря 2019 года " +
                    "по 7 января 2020 года. Кроме этого, игрокам подарят по три контейнера со снаряжением. Вместе с рождественскими косметическими предметами, Ubisoft добавит в игру временное событие " +
                    "«Тихая ночь». С ним в шутере появится 35 новых предметов, включая четыре формы: Midnight, Harrier, Reaper и Scavenger.",
                    Games = game3
                };
                News_single news4 = new News_single()
                {
                    Title = "EA brings the legendary Wake Island to Battlefield V",
                    Text = "EA may have released Battlefield V over a year ago now, but it is still bringing new maps to the first-person shooter. " +
                    "Initially launched with three episodic campaigns, EA introduced a fourth episode last December, which it has since followed up with a fifth called War in " +
                    "the Pacific. The latter originally added two maps, Pacific Storm and Iwo Jima, which EA has now complemented with Wake Island, a fan favourite first seen in Battlefield 1942.Wake " +
                    "Island is now twice as large as it was 17 years ago, with EA bringing land, sea and air battles to the classic map. The reimagining also looks drastically better than it did in Battlefield 1942 or Battlefield 1943. ",
                    Games = game2
                };
                News_single news5 = new News_single()
                {
                    Title = "Начинаются бесплатные выходные в Tom Clancy's The Division 2",
                    Text = "Компания Ubisoft объявила о начале акции в шутере Tom Clancy’s The Division 2. Начиная с 13 июня все желающие смогут бесплатно поиграть в проект. " +
                    "Предложение действительно для платформ PlayStation 4, Xbox One, ПК и продлится до 16 июня включительно. Игроки получат доступ ко всему контенту, которые доступен в платной версии " +
                    "игры. Разумеется, все заработанные во время бесплатных выходных прогресс, опыт и валюта останутся на аккаунте игрока при условии покупки полноценной копии. Для участия в бесплатных выходных" +
                    " нужно перейти на сайт игры и зарегистрироваться в акции. События Tom Clancy’s The Division 2 разворачиваются в Вашингтоне спустя полгода после пандемии, описанной в первой части. Особое внимание " +
                    "уделяется многопользовательскому режиму, позволяющему взаимодействовать в группах до восьми человек.",
                    Games = game3
                };

                DLC dlc1 = new DLC()
                {
                    Name = "Battlefield 1 «Во имя Царя»",
                    Discription = "Очутитесь на крупнейшем фронте Первой мировой в самом масштабном на " +
                    "сегодняшний день дополнении для Battlefield. Дополнение Battlefield 1 «Во имя Царя», выходящее в сентябре - второе дополнение для Battlefield 1 . " +
                    "В нем в битву вступает русская армия - в том числе женский батальон смерти, представленный русскими разведчицами.",
                    BuyLink = "https://www.battlefield.com/ru-ru/news/in-the-name-of-the-tsar-new-info",
                    Price = 100,
                    Game = game2,
                    Studio = studio2,
                    ImgLink = "BF1DLC.jpg"
                };
                DLC dlc2 = new DLC()
                {
                    Name = "Monster Hunter World: Iceborne",
                    Discription = "A diverse locale, rich with endemic life.Numerous monsters that prey on each other and get into turf wars.A new hunting experience," +
                    " making use of the densely packed environment.Monster Hunter: World, the game that brought you a new style of hunting action,is about to get even " +
                    "bigger with the massive Monster Hunter World: Iceborne expansion!",
                    BuyLink = "https://store.steampowered.com/app/1118010/Monster_Hunter_World_Iceborne/",
                    Price = 100,
                    Game = game1,
                    Studio = studio1,
                    ImgLink = "Iceborn.png"
                };
                DLC dlc3 = new DLC()
                {
                    Name = "Year 1 Pass",
                    Discription = "Enhance your Tom Clancy's The Division® 2 experience with the Year 1 Pass!",
                    BuyLink = "https://www.epicgames.com/store/en-US/product/the-division-2/season-pass",
                    Price = 100,
                    Game = game3,
                    Studio = studio3,
                    ImgLink = "Division2Pass.jpg"
                };
                DLC dlc4 = new DLC()
                {
                    Name = "The Witcher 3: Wild Hunt - Expansion Pass",
                    Discription = "The Expansion Pass secures your access to two epic adventures set in the vibrant world of monster hunter Geralt of Rivia.",
                    BuyLink = "https://www.gog.com/game/the_witcher_3_wild_hunt_expansion_pass",
                    Price = 100,
                    Game = game4,
                    Studio = studio4,
                    ImgLink = "Witcher3Pass.jpg"
                };

                context.DLCs.AddRange(dlc1, dlc2, dlc3, dlc4);

                context.News.AddRange(news1, news2, news3, news4, news5);

                context.SaveChanges();
            }
        }
    }
}

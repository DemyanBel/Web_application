using System.Collections.Generic;

namespace WebApplicationfromLab_7.Pages.Models
{
    public static class GameData
    {
        public static List<GameScene> Scenes = new List<GameScene>()
        {
            new GameScene
            {
                Id = 1,
                Text = "Вы просыпаетесь в темной комнате. Вы не помните кто вы и как здесь оказались.",
                Image = "/images/room1.jpg",
                Music = "/music/ambient.mp3",
                Choices = new List<Choice>
                {
                    new Choice { Text = "Осмотреть комнату", NextSceneId = 2 },
                    new Choice { Text = "Позвать на помощь", NextSceneId = 3 }
                }
            },
            new GameScene
            {
                Id = 2,
                Text = "Комната очень пыльная и темная .Однако над дверью горит свет.",
                Image = "/images/room1.jpg",
                Music = "/music/ambient.mp3",
                Choices = new List<Choice>
                {
                    new Choice { Text = "Открыть дверь", NextSceneId = 4 },
                    new Choice { Text = "Осмотреть пыль", NextSceneId = 3}
                }
            },
            new GameScene
            {
                Id = 3,
                Text = "...........",
                Image = "/images/TV.jpg",
                Music = "/music/Noise_TV.mp3",
                Choices = new List<Choice>
                {
                    new Choice { Text = "Выключить телевизор", NextSceneId = 2},
                    new Choice { Text = "Позвать на помощь", NextSceneId = 5}
                }
            },
            new GameScene
            {
                Id = 4,
                 Text = "Темный коридор. Кажется где-то капает вода. Ноги вас еле слушаются, но вы уверены, что нужно идти вперед.",
                 Image = "/images/hallway.jpg",
                 Music = "/music/holl.mp3",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Идти", NextSceneId = 7 }
                 }
            },
            new GameScene
            {
                Id = 5,
                Text = "Вы звали и звали на помощь, но ничего не происходило. Резко включившийся телевизор взорвался. Вы умерли...",
                Image = "/images/dead.jpg",
                Music = "/music/flashband.mp3",
                Choices = new List<Choice>()
                {
                     new Choice { Text = "Нажмите для продолжения", NextSceneId = 6 }
                }
            },
            new GameScene
            {
                Id = 6,
                Text = "Вы получили концовку Z..",
                Image = "/images/end_Z.jpg",
                Choices = new List<Choice>()
                {
                     new Choice { Text = "Нажиме чтобы начать сначала", NextSceneId = 1 }
                }
            },
            new GameScene
            {
                Id = 7,
                 Text = "Коридор не кончается. Стоит ли продолжать или стоит повернуть назад?",
                 Image = "/images/hallway.jpg",
                 Music = "/music/holl.mp3",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Продолжить идти", NextSceneId = 8 },
                     new Choice { Text = "Развернуться", NextSceneId = 9 }
                 }
            },
            new GameScene
            {
                Id = 9,
                 Text = ".......",
                 Image = "/images/MonsterFace.jpg",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Нажмите для продолжения", NextSceneId = 10 }
                 }
            },
            new GameScene
            {
                Id = 10,
                 Text = "Вы получили концовку Y..",
                 Image = "/images/end_Z.jpg",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Нажиме чтобы начать сначала", NextSceneId = 1 }
                 }
            },
            new GameScene
            {
                Id = 8,
                 Text = "Кажется снова дверь...",
                 Image = "/images/door2.jpg",
                 Music = "/music/holl.mp3",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Открыть дверь", NextSceneId = 11 }
                 }
            },
            new GameScene
            {
                Id = 11,
                 Text = "За дверью оказался лес. Тишина и лишь ворона над дверью издает какие-то звуки.",
                 Image = "/images/forestDoor.jpg",
                 Music = "/music/voron.mp3",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Пойти прямо", NextSceneId = 12 },
                     new Choice { Text = "Пойти направо", NextSceneId = 12 },
                     new Choice { Text = "Пойти налево", NextSceneId = 12 },
                 }
            },
            new GameScene
            {
                Id = 12,
                 Text = "Бэта версия окончена. Если хотите продолжение просите))",
                 Image = "/images/beta.jpg",
                 Choices = new List<Choice>()
                 {
                     new Choice { Text = "Нажиме чтобы начать сначала", NextSceneId = 1 }
                 }
            },
        };
    }
}
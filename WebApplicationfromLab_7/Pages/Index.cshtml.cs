using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using WebApplicationfromLab_7.Pages.Models;

namespace WebApplicationfromLab_7.Pages
{
    public class IndexModel : PageModel
    {
        private const string GameStateSessionKey = "TextAdventureGameState";
        private const string GameStartedSessionKey = "GameStarted";
        public GameScene CurrentScene { get; set; }
        public string BackgroundMusic { get; set; }
        public bool IsMusicPlaying { get; set; }
        public bool GameStarted { get; set; }

        public void OnGet()
        {
            LoadGameState();
        }
        public IActionResult OnPostStartGame()
        {
            HttpContext.Session.SetString(GameStartedSessionKey, "true");
            LoadGameState();
            return RedirectToPage();
        }
        public IActionResult OnPost(int choiceId)
        {
            LoadGameState();
            if (CurrentScene.Choices != null && choiceId >= 0 && choiceId < CurrentScene.Choices.Count)
            {
                var selectedChoice = CurrentScene.Choices[choiceId];
                GameState gameState = new GameState() { CurrentSceneId = selectedChoice.NextSceneId };
                SaveGameState(gameState);
            }
            return RedirectToPage();
        }
        private void LoadGameState()
        {
            var gameStarted = HttpContext.Session.GetString(GameStartedSessionKey);
            GameStarted = gameStarted == "true";

            if (GameStarted)
            {
                var gameStateJson = HttpContext.Session.GetString(GameStateSessionKey);
                GameState gameState;

                if (gameStateJson != null)
                {
                    gameState = JsonSerializer.Deserialize<GameState>(gameStateJson);
                }
                else
                {
                    gameState = new GameState() { CurrentSceneId = 1 };
                    SaveGameState(gameState);
                }
                CurrentScene = GameData.Scenes.Find(s => s.Id == gameState.CurrentSceneId);
                BackgroundMusic = CurrentScene.Music;
            }
            else
            {
                CurrentScene = new GameScene();
                BackgroundMusic = "";
            }
        }

        private void SaveGameState(GameState gameState)
        {
            var gameStateJson = JsonSerializer.Serialize(gameState);
            HttpContext.Session.SetString(GameStateSessionKey, gameStateJson);
        }
    }
}
using System.Collections.Generic;
namespace WebApplicationfromLab_7.Pages.Models
{
    public class GameScene
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Music { get; set; }
        public List<Choice> Choices { get; set; } = new List<Choice>();
    }
}
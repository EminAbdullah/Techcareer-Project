using GameShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class GameController : Controller
    {
        private readonly ShopContext context;

        public GameController(ShopContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("games/{type?}")]
        public IActionResult List(string type="all")
        {

            List<Game> games;

            if (type.Equals("all"))
            {
                games = context.Games.ToList();
            }
            else
            {
               games=context.Games.Where(g=> g.Type ==type).ToList();
            }
            return View(games);
        }
		[Route("game/{id}/{slug?}")]
		public IActionResult Details(int id)
        {
            var game = context.Games.Find(id);
            if (game != null && game.ImageFileName !=null)
            {
                game.ImageFileName = "/images/" + game.ImageFileName;
            }
  
            return View(game);
        }
    }
}

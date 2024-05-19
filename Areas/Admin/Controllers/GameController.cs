using GameShop.Models;
using Microsoft.AspNetCore.Mvc;


namespace GameShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController : Controller
    {
        private readonly ShopContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public GameController(ShopContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("[area]/games/{type?}")]
        public IActionResult List(string type = "all")
        {
            List<Game> games;

            if (type.Equals("all"))
            {
                games = context.Games.ToList();
            }
            else
            {
                games = context.Games.Where(g => g.Type == type).ToList();
            }
            return View(games);
        }

        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var game = context.Games.Find(id.Value);
                if (game != null)
                {
                    return View("AddEdit", game);
                }
            }
            return View("AddEdit", new Game());
        }

        [HttpPost]
        public IActionResult Add(Game game, IFormFile? imageFile)
        {
            if (ModelState.IsValid)
            {

                if (imageFile != null && imageFile.Length > 0)
                {

                    var uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    var fileName = Path.GetFileName(imageFile.FileName);
                    var filePath = Path.Combine(uploadDir, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }
                  
                    game.ImageFileName = fileName;
                    

                }
                
                
                if (game.Id == 0)
                {
                    context.Games.Add(game);
                }
                else
                {
                    context.Games.Update(game);
                }

                context.SaveChanges();
                return RedirectToAction("List");
            }
            return View("AddEdit", game);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var game = context.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }

            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("List");
        }

	}
}

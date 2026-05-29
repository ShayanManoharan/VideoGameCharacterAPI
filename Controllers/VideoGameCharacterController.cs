using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoGameCharactersController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character { Id = 1, Name = "Mario", Game = "Super Mario Brothers", Role = "Hero" },
            new Character { Id = 2, Name = "Link", Game = "Legend of Zelda", Role = "Hero" },
            new Character { Id = 3, Name = "Bowser", Game = "Super Mario Brothers", Role = "Villain" }
        };

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetAllCharacters()
        {
            return Ok(await Task.FromResult(characters));
        }
    }
}
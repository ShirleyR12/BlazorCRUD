using BlazorFullStack.Client.Pages;
using BlazorFullStack.Server.Data;
using BlazorFullStack.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorFullStack.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }
   

    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
    {
        var heroes = await _context.SuperHero.Include(x => x.Comic).ToListAsync();
        return Ok(heroes);
    }

    [HttpGet("comics")]
    public async Task<ActionResult<List<Comic>>> GetComics()
    {
        var comics = await _context.Comic.ToListAsync();
        return Ok(comics);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
    {
        var hero = await _context.SuperHero
                .Include(x => x.Comic)
                .FirstOrDefaultAsync(x => x.Id == id);
        if(hero == null)
            {
                return NotFound("Não encontramos o Heroi");
            }
        return Ok(hero);
    }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> CreateSuperHero(SuperHero hero)
        {
            hero.Comic = null;
            _context.SuperHero.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await GetDbHeroes());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateSuperHero(SuperHero hero, int id)
        {
            var dbHero = await _context.SuperHero
                .Include(x => x.Comic)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbHero == null)
                return NotFound("Heroi não encontrado");

            dbHero.FisrtName = hero.FisrtName;
            dbHero.LastName = hero.LastName;
            dbHero.HeroName = hero.HeroName;
            dbHero.ComicId = hero.ComicId;

            await _context.SaveChangesAsync();
            return Ok(await GetDbHeroes());
        }

        private async Task<List<SuperHero>> GetDbHeroes()
        {
            return await _context.SuperHero
                .Include(x => x.Comic).ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteSuperHero(int id)
        {
            var dbHero = await _context.SuperHero
                .Include(x => x.Comic)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (dbHero == null)
                return NotFound("Heroi não encontrado");

             _context.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await GetDbHeroes());
        }

    }
}

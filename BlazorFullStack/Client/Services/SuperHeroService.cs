using BlazorFullStack.Client.Pages;
using BlazorFullStack.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorFullStack.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _http;

        public SuperHeroService(NavigationManager navigationManager, HttpClient http)
        {
            _navigationManager = navigationManager;
            _http = http;
        }

        public List<SuperHero> Heroes { get; set; } = new List<SuperHero>();
        public List<Comic> Comics { get; set; } = new List<Comic>();

        public async Task CreateHero(SuperHero hero)
        {
            var result = await _http.PostAsJsonAsync("api/superhero", hero);
            if(result != null)
            {
                await SetHeroes(result);
            }
        }
        
        private async Task SetHeroes(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SuperHero>>();
            Heroes = response;
            _navigationManager.NavigateTo("superheroes");
        }
        public async Task DeleteHero(int id)
        {
            var result = await _http.DeleteAsync($"api/superhero/{id}");
            await SetHeroes(result);
        }

        public async Task GetComics()
        {
            var result = await _http.GetFromJsonAsync<List<Comic>>($"api/superhero/comics");
            if (result != null)
                Comics = result;
        }

        public async Task<SuperHero> GetSingleHero(int id)
        {
            var result = await _http.GetFromJsonAsync<SuperHero>($"api/superhero/{id}");
            if (result != null)
                return result;
            throw new Exception("Não foi possível encontrar o Heroi");
        }

        public async Task GetSuperHores()
        {
            var result = await _http.GetFromJsonAsync<List<SuperHero>>("api/superhero");
            if (result != null)
                Heroes = result;
        }

        public async Task UpdateHero(SuperHero hero)
        {
            var result = await _http.PutAsJsonAsync($"api/superhero/{hero.Id}", hero);
            await SetHeroes(result);
        }
    }
}

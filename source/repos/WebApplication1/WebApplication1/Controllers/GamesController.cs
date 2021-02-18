﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 10 });
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 15 });
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 20 });
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 25 });
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 30 });
            return games;
        }
        [HttpGet]
        public IEnumerable<Games> GetGames_List()
        {
            return GetGames();
        }
        [HttpGet("{id}")]
        public ActionResult<Games> GetGames_ById(int id)
        {
            var games = GetGames().Find(x => x.Id == id);
            if(games != null)
            {
                return games;
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}

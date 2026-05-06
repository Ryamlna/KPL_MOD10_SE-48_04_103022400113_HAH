﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MOD10
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
        {
            new Game(1, "Valorant","Riot Games" , 2020, "FPS", 8.5, new string[] { "PC" }, new string[] { "Multiplayer" }, true, 0),
            new Game(2, "GTA V", "Rockstar Games" , 2013, "Open World", 9.5, new string[] { "PC", "PS4", "PS5", "Xbox" }, new string[] { "Singleplayer", "Multiplayer" }, true, 300000),
            new Game(3, "The Witcher 3","CD Projekt Red" , 2015, "RPG", 9.7, new string[] { "PC", "PS4", "PS5", "Xbox", "Switch" }, new string[] { "Singleplayer" }, false, 250000)
        };


        [HttpGet]
        public ActionResult <IEnumerable<Game>> GetAll()
        {
            return Ok (games);
        }


        [HttpGet("{id}")]
        public Game Get(int id)
        {
            return games[id];
        }


        [HttpPost]
        public void Post([FromBody] Game newgame)
        {
            games.Add(newgame);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Game updateGame)
        {
            games[id] = updateGame;
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            games.Remove(games[id]);
        }
    }
}
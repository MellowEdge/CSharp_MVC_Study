using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab6_1.Models
{
    public class GameDbInit : DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext db)
        {
            db.Games.Add(new Game { Name = "Haloes 6", Publisher = "X-box Studios", Price = 70 });
            db.Games.Add(new Game { Name = "Fall Lads", Publisher = "Indie Studios", Price = 20 });
            db.Games.Add(new Game { Name = "Half-Live 2.9", Publisher = "Val-Vee", Price = 60 });

            base.Seed(db);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GameApp.Data
{
    public class GameAppInitializer : DropCreateDatabaseIfModelChanges<GameAppContext>
    {
        protected override void Seed(GameAppContext context)
        {
            //SEED

            base.Seed(context);
        }
    }
}

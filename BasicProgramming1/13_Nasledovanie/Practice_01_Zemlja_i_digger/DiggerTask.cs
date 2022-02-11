using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01_Zemlja_i_digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public string GetImageFileName()
        {
            return default;
        }

        public int GetDrawingPriority()
        {
            return default;
        }

        public CreatureCommand Act(int x, int y)
        {
            return default;
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return default;
        }
    }

    public class Player : ICreature
    {
        public string GetImageFileName()
        {
            throw new NotImplementedException();
        }

        public int GetDrawingPriority()
        {
            throw new NotImplementedException();
        }

        public CreatureCommand Act(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            throw new NotImplementedException();
        }
    }
}
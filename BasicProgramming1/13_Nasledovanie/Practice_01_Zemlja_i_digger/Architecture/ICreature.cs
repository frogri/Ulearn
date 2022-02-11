namespace Practice_01_Zemlja_i_digger
{
    public interface ICreature
    {
        string GetImageFileName();
        int GetDrawingPriority();
        CreatureCommand Act(int x, int y);
        bool DeadInConflict(ICreature conflictedObject);
    }
}
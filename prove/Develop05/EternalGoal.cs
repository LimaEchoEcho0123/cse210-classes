public class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, string points) :base(shortname, description, points)
    {

    }
    public override bool IsComplete()
    {
        return false;
        // Will never be completed
    }
    public override void SetComplete(bool value)
    {
        
    }

    public override void RecordEvent()
    {

    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{getname()},{getdescription()},{getpoints()},{IsComplete()}";
    }
}
using System.Buffers.Binary;
using System.ComponentModel;
using System.Reflection.Metadata;

public class SimpleGoal : Goal
{
    public bool _isComplete = false;

    public SimpleGoal(string shortname, string description, string points) :base(shortname, description, points)
    {

    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetComplete(bool value)
    {
        _isComplete = value;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {getname()}, {getdescription()}, {getpoints()}, {IsComplete()}";
    }
}
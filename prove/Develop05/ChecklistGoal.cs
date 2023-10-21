public class ChecklistGoal : Goal
{
    private int _amountcompleted = 0;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string shortname, string description, string points, int bonus, int target) :base(shortname, description, points)
    {
        _bonus = bonus;
        _target = target;
    }



    //  getters
    public int targetget()
    {
        return _target;
    }

    public int bonusget()
    {
        return _bonus;
    }
    public int getamountcompleted()
    {
        return _amountcompleted;
    }

    public override void RecordEvent()
    {
        _amountcompleted += 1;
        if (IsComplete() == true)
        {

        }
    }


    public override void SetComplete(bool value)
    {
        _amountcompleted = 0;
    }
    public override bool IsComplete()
    {
       if (_amountcompleted == _target)
       {
            return true;
       }
       else
       {
            return false;
       }
    }


    public string GetDetailString()
    {
        string condition = "( )";
        if (IsComplete() == true)
        {
            condition = "(X)";
        }
        
        return $"{condition} {getname()} ({getdescription()}... completed: {getamountcompleted()}/{targetget()})";
    }   
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal,{getname()},{getdescription()},{getpoints()},{getamountcompleted()},{targetget()},{bonusget()},{IsComplete()}";
    } 
}
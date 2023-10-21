public abstract class Goal 
{
    private string _shortname;

    private string _description;

    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract void SetComplete(bool value);

    public abstract string GetStringRepresentation();  
    //  Set getters and setters .... check other class override string representation
    public string getname()
    {
        return _shortname;
    }

    public string getdescription()
    {
        return _description;
    }

    public string getpoints()
    {
        return _points;
    }

    public void setpoints(string points)
    {
        _points = points;
    }

    public virtual string GetStringDetail()
    {
        string condition = "( )";
        if(IsComplete() == true)
        {
            condition = "(X)";
        }
        return $"{condition} {getname()} ({getdescription()})";
    }
   
}

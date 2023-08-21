namespace Core.Persistence.Dynamic;

public class Sort
{
    public string Field { get; set; }
    public string Dir { get; set; }
    
    public Sort()
    {
        Field = string.Empty;
        Dir = string.Empty;
    }
    
    
    public Sort(string field, string dir)
    {
        Dir = dir;
        Field = field;
    }
}
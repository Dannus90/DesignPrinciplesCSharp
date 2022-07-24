using System.Text;

namespace Builder.Exercise;
    
public static class ExecuteExercise
{
    public static void RunExercise()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");
        Console.WriteLine(cb);
    }
}

internal class Field 
{
    public string Type = "", Name = "";
    
    public override string ToString()
    {
        return $"public {Type} {Name}";
    }
}

internal class Class 
{
    public string Name = "";
    public List<Field> Fields = new List<Field>();
    
    public Class()
    {
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"public class {Name}")
            .AppendLine("{");
        foreach (var f in Fields)
            sb.AppendLine($"  {f};");
        sb.AppendLine("}");
        return sb.ToString();
    }
}

public class CodeBuilder
{
    private readonly Class _theClass = new();
  
    public CodeBuilder(string rootName)
    {
        _theClass.Name = rootName;
    }

    public CodeBuilder AddField(string name, string type)
    {
        _theClass.Fields.Add(new Field { Name = name, Type = type });
        return this;
    }

    public override string ToString()
    {
        return _theClass.ToString();
    }
}




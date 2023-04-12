internal class Program
{
    private static void Main()
    {
        foreach (var d in typeof(ArgumentException).GetMethods())
        {
            Console.WriteLine($"{d.Name} \n{nameof(d.IsAbstract)} - {d.IsAbstract} {nameof(d.IsFamily)} - {d.IsFamily} {nameof(d.IsFamilyAndAssembly)} - {d.IsFamilyAndAssembly} {nameof(d.IsFamilyOrAssembly)} - {d.IsFamilyOrAssembly} {nameof(d.IsAssembly)} - {d.IsAssembly} {nameof(d.IsPrivate)} - {d.IsPrivate} {nameof(d.IsPublic)} - {d.IsPublic} {nameof(d.IsConstructor)} - {d.IsConstructor} {nameof(d.IsStatic)} - {d.IsStatic} {nameof(d.IsVirtual)} - {d.IsVirtual} {nameof(d.ReturnType)} - {d.ReturnType}");
        }
        foreach (var d in typeof(ArgumentException).GetConstructors())
        {
            Console.WriteLine($"{d.Name} \n{nameof(d.IsFamily)} - {d.IsFamily} {nameof(d.IsFamilyAndAssembly)} - {d.IsFamilyAndAssembly} {nameof(d.IsFamilyOrAssembly)} - {d.IsFamilyOrAssembly} {nameof(d.IsAssembly)} - {d.IsAssembly} {nameof(d.IsPrivate)} - {d.IsPrivate} {nameof(d.IsPublic)} - {d.IsPublic}");
        }
        foreach (var d in typeof(ArgumentException).GetFields())
        {
            Console.WriteLine($"{d.Name} \n{nameof(d.IsFamily)} - {d.IsFamily} {nameof(d.IsFamilyAndAssembly)} - {d.IsFamilyAndAssembly} {nameof(d.IsFamilyOrAssembly)} - {d.IsFamilyOrAssembly} {nameof(d.IsAssembly)} - {d.IsAssembly} {nameof(d.IsPrivate)} - {d.IsPrivate} {nameof(d.IsPublic)} - {d.IsPublic} {nameof(d.IsStatic)} - {d.IsStatic}");
        }
        foreach (var d in typeof(ArgumentException).GetProperties())
        {
            Console.WriteLine($"{d.Name} \n{nameof(d.Attributes)} - {d.Attributes} {nameof(d.CanRead)} - {d.CanRead} {nameof(d.CanWrite)} - {d.CanWrite} {nameof(d.GetMethod)} - {d.GetMethod} {nameof(d.SetMethod)} - {d.SetMethod} {nameof(d.PropertyType)} - {d.PropertyType}");
        }
        Console.ReadKey();
    }
}
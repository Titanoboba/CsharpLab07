using System;
using System.Reflection;
using System.Xml.Linq;
using Lab07;

class Programm
{
    public static void Main()
    {
        Lion lion = new Lion("Russia", false, "myLion");
        Console.WriteLine(lion.Country);
        lion.SayHello();

        var root = new XElement("Classes");

        foreach (var cls in Assembly.LoadFrom("Lab07ClassLibrary.dll").GetTypes().Where(t => t.IsClass))
        {
            var commentAttr = cls.GetCustomAttribute<commentAttribute>();
            var comment = commentAttr?.comment ?? "defaultComment";

            var classElement = new XElement("Class",
                new XAttribute("Name", cls.Name),
                new XAttribute("Comment", comment));

            root.Add(classElement);
        }

        var xmlFilePath = "Classes.xml";
        root.Save(xmlFilePath);

        Console.WriteLine($"XML was created: {xmlFilePath}");
    }
}
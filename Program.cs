using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

var xml =
    new XElement("Something",
        new XAttribute("Att", "s"),
        new XAttribute("Att2", "gg"),
        new XElement("AnotherSomething"),
        new XElement("AnotherSomething"));

File.WriteAllText("something.xml", xml.ToString());
var fileText = File.ReadAllText("something.xml");

if (Debugger.IsAttached)
{
    // Run the debugger to hit this breakpoint, 
    // or click the line number to add a red dot.
    Console.WriteLine("Hit breakpoint");
    Debugger.Break();
}

Console.WriteLine(fileText);

using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

var xml =
    new XElement("MichaelHatfield",
        new XAttribute("HairColor", "red"),
        new XAttribute("Smell", "poop"),
        new XElement("Skills"),
        new XElement("Fruits"));

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

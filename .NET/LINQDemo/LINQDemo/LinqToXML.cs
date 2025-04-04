using System;
using System.Linq;
using System.Xml.Linq;

class LinqToXML
{
    public static void Execute()
    {
        XDocument xmlDoc = new XDocument(
            new XElement("Students",
                new XElement("Student",
                    new XAttribute("ID", "1"),
                    new XElement("Name", "Alice"),
                    new XElement("Age", "22")
                ),
                new XElement("Student",
                    new XAttribute("ID", "2"),
                    new XElement("Name", "Bob"),
                    new XElement("Age", "24")
                )
            )
        );

        xmlDoc.Save("Students.xml");
        Console.WriteLine("XML file 'Students.xml' created successfully.");

        var students = xmlDoc.Descendants("Student")
                             .Where(s => (int)s.Element("Age") > 22)
                             .Select(s => s.Element("Name").Value);

        Console.WriteLine("Students older than 22:");
        foreach (var name in students)
        {
            Console.WriteLine(name);
        }
    }
}


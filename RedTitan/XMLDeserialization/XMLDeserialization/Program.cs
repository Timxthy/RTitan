using System;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        var serializer = new XmlSerializer(typeof(StartUpPrograms));

        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sample.xml");

        // Check if the XML file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"XML file not found at path: {filePath}");
            return;
        }

        // Read the XML file using a StreamReader and handle different locales.
        using (var reader = new StreamReader(filePath))
        {
            var cultureInfo = CultureInfo.InvariantCulture; // You can change this to the desired culture.
            var xmlTextReader = new System.Xml.XmlTextReader(reader);
            var programs = (StartUpPrograms)serializer.Deserialize(xmlTextReader);
            xmlTextReader.Close();

            // Access the deserialized data here.
            foreach (var program in programs.Programs)
            {
                Console.WriteLine($"Path: {program.Path}");
                Console.WriteLine($"Arguments: {program.Arguments}");
                Console.WriteLine($"AutoStart: {program.AutoStart}");
                Console.WriteLine($"MinProductVersion: {program.MinProductVersion}");
                Console.WriteLine();
            }

            // Indicate that deserialization is complete
            Console.WriteLine("XML Deserialization complete.");
        }
    }
}

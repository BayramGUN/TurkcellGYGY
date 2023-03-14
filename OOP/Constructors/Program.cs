// See https://aka.ms/new-console-template for more information

using Constructors;


ReportGenerator reportGenerator = new ReportGenerator("C:\\data.json");
Console.WriteLine(reportGenerator.ReadingDataPath);


ReportGenerator reportGeneratorTwo = new ReportGenerator(readingPath: "C:\\data.xml");
Console.WriteLine(reportGeneratorTwo.ReadingDataPath);


Bread bread = new Bread(2, "Bran Bread");
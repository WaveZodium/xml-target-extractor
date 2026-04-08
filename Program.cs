/////////////////////////////////////////////////////////////////////////////////////////
//
// Solution to a task where an XML file is processed to find a specific element by id,
// extract the value of its direct <target> element, and write the result to a file.
//
// The program handles missing elements and file errors gracefully.
//
/////////////////////////////////////////////////////////////////////////////////////////
using System.Xml.Linq;

// Define the id of the element to find in the XML document
string elementIdToFind = "42014";

// Define the path to the XML file
string sourceFilePath = "source_file/gentext.xml";

// Check if the file exists at the specified path
if (!File.Exists(sourceFilePath)) {
    Console.WriteLine($"File not found: {sourceFilePath}");
    return;
}

// Print a message indicating that the XML document is being loaded
Console.WriteLine($"Loading XML document from: {sourceFilePath}");

// Load the XML document from the specified file path
// Documentation: https://learn.microsoft.com/en-us/dotnet/standard/linq/load-xml-file
XElement xmlDoc = XElement.Load(sourceFilePath);
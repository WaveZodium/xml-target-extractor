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

// Search for the element with the specified id in the loaded XML document
var elementWithCorrectId = xmlDoc.Descendants()
    .FirstOrDefault(e => e.Attribute("id")?.Value == elementIdToFind);

// Check if the element with the specified id was found
if (elementWithCorrectId == null) {
    Console.WriteLine($"Element with id={elementIdToFind} not found.");
    return;
}

// Get the child element target of the found element
var targetElement = elementWithCorrectId.Element("target");

// Check if the target element exists
if (targetElement == null) {
    Console.WriteLine($"Target element not found within element with id={elementIdToFind}");
    return;
}

// Get the value of the target element
string targetValue = targetElement.Value; // Trim() can be used if you want to remove leading and trailing whitespace from the value
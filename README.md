# XML Extraction Task

## Description
This console application reads an XML file, finds the first element with the attribute `id="42014"`, extracts the value of its direct `target` element, and writes the result to `result.txt`.

## How it works
The application:

1. Loads the XML file
2. Searches all descendant elements for the first element with `id="42014"`
3. Reads the direct `target` child element of that match
4. Writes the extracted value to `result.txt`

## Input file
The XML file is expected at:

```text
source_file/gentext.xml
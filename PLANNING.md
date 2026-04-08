# Planning

## Goal
Read the XML file, find the first element with the attribute `id="42014"`, extract the value of its direct `target` element, and write that value to a text file.

## Steps
- Read the XML file
- Check whether the file exists and can be loaded
- Search for the first element with the attribute `id="42014"`
- If no such element is found, output an error message and exit

- Find the direct `target` child element of the matching element
- If the `target` element is not found, output an error message and exit

- Read the value of the `target` element
- Write the value to `result.txt`
- If the file cannot be written, output an error message and exit

- Output a success message to the console
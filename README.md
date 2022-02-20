# pdfdj
pdfdj is a tool to merge and split PDF documents.

It is written and runs on .NET 6.0 Framework.

It can be used from: 
1. PdfDJ.exe Windows Application (only on Windows OS)
2. pdjc.exe/dll Console application (on Windows, Linux and Mac OS)

Download link: https://github.com/renzfe/pdfdj/releases

## Features
1. Merge two PDF files into single document 
2. Split a single PDF document into multiple PDF files 


# PdfDJ.exe 
PdfDJ is a Windows application to merge and split PDF documents.

## How to Merge PDF
1. Run PdfDJ.exe
2. Click Merge button
3. Drag and drop the first file
4. Drag and drop the second file
5. Optionally drag and drop the output directory
6. Click Merge button

![Merge](/docs/Merge-Demo.gif)

## How to Split PDF
1. Run PdfDJ.exe
2. Click Split button
3. Drag and drop the file to split
4. Select the page/s where to finish a document and start a new one
5. Click Split button

![Split](/docs/Split-Demo.gif)


# pdfdjc.exe / pdfdjc.dll
pdjc is a Console Application to merge and split PDF documents.

## How to Merge PDF
On Windows OS:

**`pdjc.exe`** **`merge`** **`-i C:\temp\file1.pdf C:\temp\file2.pdf`** **`-o  C:\temp`**  

On Linux or Mac OS:

**`dotnet pdjc.dll`** **`merge`** **`-i /tmp/file1.pdf /tmp/file2.pdf`** **`-o  /tmp`**  


Options:
```
  -i, 		--inputfiles		Required. Input pdf files to be merged.
  -o, 		--outputdirectory	Required. Output directory where the merged file is created.
  --help				Display this help screen.
  --version				Display version information.
```

## How to Split PDF
On Windows OS:

**`pdjc.exe`** **`split`** **`-i C:\temp\file.pdf`** **`-o  C:\temp`** **`-p 2 3`** 

On Linux or Mac OS:

**`dotnet pdjc.dll`** **`split`** **`-i /tmp/file.pdf`** **`-o  /tmp`**  **`-p 2 3`** 


Options:
```
  -i, 		--inputfile		Required. Input pdf file to be splitted.
  -o, 		--outputdirectory	Required. Output directory where the splitted files are created.
  -p,		--pages			Required. Pages where to split file.
  --help				Display this help screen.
  --version				Display version information.
```



License
---
The license of the project is the [GNU General Public License v3.0](LICENSE).

using StringReverseClient;

WebServiceOperation webServiceOperation = new();
var pathForInput = @"D:\IN.txt";
var pathForOutput = @"D:\OUT.txt";
var textInFile = TextOperation.Read(pathForInput);
var url = "https://localhost:8010/GetReversedText";
var reversedTextList = new List<string>();
foreach (var text in textInFile)
{
    var reversedText = await webServiceOperation.ReadApiData(url, text);
    reversedTextList.Add(reversedText);
}

TextOperation.Write(reversedTextList.ToArray(), pathForOutput);
// See https://aka.ms/new-console-template for more information
using SolutionsPetrovskiyCleverens;
using SolutionsPetrovskiyCleverens.Properties;
using SolutionsPetrovskiyCleverens.Controls;
using System.Configuration;
using System.Text.RegularExpressions;

WriteIntro.Writeintro();

List<string> workList = new List<string>();
workList.Add("aaabbcccdde");
workList.Add("zzzzbrrrracadddabraaaaaa");
workList.Add("ааааббббвввддджжжжжкккк");
workList.Add("а1ббБИддД6");
workList.Add("метрополитенмосквы");

foreach (string work in workList)
{
    var mistakes = new Mistakes().GetMistakes(work);

    if (mistakes != "OK")
    {
        WriteIntro.WriteNewLine(mistakes);
        continue;
    }

    var compression = new CompressionString(work);

    WriteIntro.WriteNewLine("* Входная строка " + work);
    compression.Conpression();

    WriteIntro.WriteNewLine("** Компрессия = " + compression.compressString);

    var reCompr = new ReCompressionString(compression.compressString);

    reCompr.ReCompression();
    WriteIntro.WriteNewLine("*** Декомпрессия " + reCompr.reCompression);
}

Console.ReadLine();
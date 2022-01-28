using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using XMLMinimizer;

string path = @"C:\Users\enric\OneDrive\Desktop\YourFolder";
DirectoryInfo d = new DirectoryInfo(path); //Assuming Test is your Folder

FileInfo[] Files = d.GetFiles("*.svg"); //Getting Text files

var xmlMin = new XMLMinifier(XMLMinifierSettings.Aggressive);
string code = "";

foreach (FileInfo file in Files)
{
    string text = System.IO.File.ReadAllText(file.FullName);
    string minText = xmlMin.Minify(text);
    string rsl = Regex.Replace(minText, "</?(svg|SVG).*?>", "", RegexOptions.IgnoreCase);
    rsl = rsl.Replace("\"", "'");

    string result = Path.GetFileNameWithoutExtension(file.FullName) + ".min" + Path.GetExtension(file.FullName);
    File.WriteAllText(Path.Combine(path, result), rsl);
}
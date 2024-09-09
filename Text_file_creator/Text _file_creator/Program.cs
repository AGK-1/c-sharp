///////Text Create
Console.WriteLine("Please write file name");
string cdext = Console.ReadLine();
Console.WriteLine("Please write the directory! (Where you want save file?)");
string cpath = Console.ReadLine();
Console.WriteLine("If you want add your text)");
string ctxt = Console.ReadLine();
FileCreation.Textcre(cdext,cpath,ctxt);


public class FileCreation
{
	public static void Textcre(string cText,string cpath,string cTxt)
	{
		DateTime now = DateTime.Now;
		string path = @$"{cpath}\{cText}.txt";
		using (StreamWriter mw = File.CreateText(path))
		{
			mw.WriteLine("Hello");
			mw.WriteLine(now.ToString());
			mw.WriteLine($"{cTxt}");
			
		}
		Console.WriteLine("Your textfile is done!");
	}
	
}









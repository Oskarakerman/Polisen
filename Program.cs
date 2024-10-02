// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Report
{
    public int ReportNumber {get; set;}
    public int Date {get; set;}
    public string Station {get; set;}
    public string Description {get; set;}

    public Report(int ReportNumber, string Station, string Description, int Date)
    {
        this.ReportNumber = ReportNumber;
        this.Station = Station; 
        this.Description = Description; 
        this.Date = Date; 
    }
    public static void AddReport()
    {
        Console.WriteLine("Lägg till ett rapportnummer");
        int ReportNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Ange datum för rapporten");
        int Date = int.Parse(Console.ReadLine());
        Console.WriteLine("Ange vilken station"); 
        string Station = Console.ReadLine(); 
        Console.WriteLine("Ange en beskrivning"); 
        string Description = Console.ReadLine();  
    }
}
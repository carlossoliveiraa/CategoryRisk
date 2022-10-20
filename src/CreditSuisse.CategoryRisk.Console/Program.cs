using CreditSuisse.CategoryRisk.Console.Configurations;
using CreditSuisse.CategoryRisk.Domain.Entity;
using System.Globalization;

int count;
DateTime date;
List<ITrade> listPortifolio;


InputDate(out count, out date, out listPortifolio);

OutputDate(count, date, listPortifolio);



static void InputDate(out int count, out DateTime date, out List<ITrade> listPortifolio)
{
    CultureInfo enUS = new CultureInfo("en-US");
    date = DateTime.ParseExact("12/11/2020", "MM/dd/yyyy", enUS, DateTimeStyles.None);
   
    Trade xx1 = new Trade 
    {
        Value = 2000000, 
        ClientSector = "Private", 
        NextPaymentDate = DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", enUS, DateTimeStyles.None) 
    };
    Trade xx2 = new Trade 
    { 
        Value = 400000, 
        ClientSector = "Public", 
        NextPaymentDate = DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", enUS, DateTimeStyles.None) 
    };
    Trade xx3 = new Trade 
    {
        Value = 5000000, 
        ClientSector = "Public", 
        NextPaymentDate = DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", enUS, DateTimeStyles.None) 
    };
    Trade xx4 = new Trade 
    { 
        Value = 3000000, 
        ClientSector = "Public", 
        NextPaymentDate = DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", enUS, DateTimeStyles.None)
    };

    listPortifolio = new List<ITrade>() { xx1, xx2, xx3, xx4 };
    count = listPortifolio.ToList().Count();
}

static void OutputDate(int count, DateTime date, List<ITrade> listPortifolio)
{
    Categories categories = new Categories(listPortifolio);
    List<string> tradeCategories = categories.GetCategories(date);


    Console.WriteLine("Sample input");
    Console.WriteLine(date);
    Console.WriteLine( count);
    Console.WriteLine(" ");

    for (int i = 0; i < listPortifolio.Count; i++)
    {
        ITrade? trade = listPortifolio[i];
        Console.WriteLine(trade.Value + ", " + trade.ClientSector + ", " + trade.NextPaymentDate.ToString("MM/dd/yyyy"));
    }
     
    Console.WriteLine(" ");

    Console.WriteLine("Sample output");
  
    tradeCategories.ForEach(risk => Console.WriteLine(risk));

    Console.ReadKey();
}
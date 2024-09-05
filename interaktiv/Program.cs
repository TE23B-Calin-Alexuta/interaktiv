using System;


string choice = "";

Console.WriteLine("Du är fattig och lever i östeuropa");
Console.WriteLine("Du ser en man som har pengar och verkar jobba för staten");
Console.WriteLine("Du kan råna han för att ingen är där och ta hans plåbok");
Console.WriteLine("Eller kan han ge dig ett jobb där du kan få bra betalt");
Console.WriteLine("Vad gör du? (rånar) mannen eller försöker (prata) med han?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "rånar")
{
  Console.WriteLine("Du springer iväg men mannen som du rånade var viktig.");
  Console.WriteLine("Därför är polisen efter dig och dem kommer inte ge upp tills dem får dig fast.");
  Console.WriteLine("Du försöker rymma men det går inte.");
  Console.WriteLine("Polisen hittar dig och skjuter dig.");
  Console.WriteLine("Du överlever men dem skickar dig till gulag.");
}
else if (choice == "prata")
{
  Console.WriteLine("Du pratar med mannen.");
  Console.WriteLine("Han tycker att du passar in på att jobba för staten.");
  Console.WriteLine("Han säger att du ska följa med han");
  Console.WriteLine("Du följer med till en svart LADA och sätter dig i framsätet.");
  Console.WriteLine("Efter 10 min kommer du till en gammal fabrik där du ska tillverka vapen för staten.");
  Console.WriteLine("Du kan tacka (ja) eller (nej) till jobbet");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "ja")
  {
    Console.WriteLine("Du får ett jobb där du tillverkar vapen för staten.");
    Console.WriteLine("Du är fortfarande fattig men du har nu ett jobb.");
  }
  else if (choice == "nej")
  {
    Console.WriteLine("Du har inget jobb och du blir skickad till gulag av staten på grund av att dem har hört att du har andra tankar än dem.");
    Console.WriteLine("Du blir dödad av en vakt som inte gillade dig och du blir bortglömd av alla.");
  }
  else
  {
    Console.WriteLine("Du skrev fel och blir därför skickad till krig dör du kommer att dö.");
  }
}
else
{
  Console.WriteLine("Du skrev fel och blir därför skickad till krig dör du kommer att dö.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();
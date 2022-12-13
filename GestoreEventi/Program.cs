using GestoreEventi;
Evento evento1 = new Evento("", "", 150,2 );

Console.Write("inserisci il nome dell'evento: ");
Console.Read();
Console.WriteLine("inserisci la data dell'evento: ");
Console.Read();
Console.WriteLine("inserisci numero di posti totali: " );
Console.Read();
Console.WriteLine("quanti posti vuoi prenotare? ");
var prenotazioni = Console.Read();
evento1.PrenotaPosti(prenotazioni);
Console.WriteLine("numero posto prenotato: ");
Console.WriteLine("numero posti disponibili: ");
Console.WriteLine("vuoi disdire dei posti?");
Console.WriteLine("indica il numero di posti da disdire: ");
var disdire = Console.Read();
evento1.DisdiciPosti(disdire);

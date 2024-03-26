using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia :");
Nokia nokia = new Nokia("91894502","Nokia 01","018955587", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone("91891684", "15 ProMax", "22514881101", 512);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
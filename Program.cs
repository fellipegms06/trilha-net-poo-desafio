using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "3897", modelo: "Nokia plus", iMEI: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "XS Max", iMEI:"222222222", memoria: 264);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
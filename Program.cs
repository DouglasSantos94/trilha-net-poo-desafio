using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "5555555555", modelo: "2310", imei: "5489419648", memoria: 64);

nokia.Ligar();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("iPhone: ");

Smartphone iphone = new Iphone(numero: "666666", modelo: "XS", imei: "1854189126", memoria: 256);

iphone.Ligar();
iphone.InstalarAplicativo("Waze");
using DesafioPOO.Models;

Console.WriteLine("\n***Smartphone Nokia***");

Smartphone nokia = new Nokia("99 88888-7777", "G11 Plus", "111111111", 128 );
nokia.Ligar();
nokia.InstalarAplicativo("FaceBook");


Console.WriteLine("\n***Smartphone - Iphone***");

Smartphone iphone = new Iphone("88 99999-6666", "15 Pro Max", "222222222", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tinder");

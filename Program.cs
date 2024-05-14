using DesafioPOO.Models;

Smartphone iphone = new Iphone("123", "A32", "REW#$", 250);
Smartphone nokia = new Nokia("1265", "G10", "TRE34", 100);

iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();
iphone.Ligar();

nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();
nokia.Ligar();
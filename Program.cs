using DesafioPOO.Models;

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "001122334455667", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Smartphone iphone = new Iphone("987654321", "iPhone 13", "998877665544332", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");


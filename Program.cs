using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "010101", modelo: "Nokia G11 Plus", imei: "898989898", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "020202", modelo: "iPhone 15 Pro", imei: "676767676", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
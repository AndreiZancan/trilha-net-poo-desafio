﻿using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Console.WriteLine("Testes com o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9 9999-9999", modelo: "G50 4G", imei: "123456789123456", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Testes com o Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "1 2345-4321", modelo: "15 Pro Max", imei: "10987654321", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("DIO");
﻿ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";

Console.WriteLine(contaDoBruno.saldo);

bool resultadoSaque = contaDoBruno.Sacar(500);

Console.WriteLine(contaDoBruno.saldo);
Console.WriteLine(resultadoSaque);

Console.ReadKey();

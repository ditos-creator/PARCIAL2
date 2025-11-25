using System;

public class TV : Maquina
{
    public override void Prender()
    {
        Console.WriteLine("el Televisor se prendio por medio del control");
    }
    public override void Apagar ()
    {
        Console.WriteLine("el Televisor se apago por error con el control");
    }
}
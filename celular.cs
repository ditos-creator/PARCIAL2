using System;

public class Celular : Maquina, IEnviarm
{   
   public override void Prender()
    {
        Console.WriteLine("el celular se esta prendiendo ");
    }
 public  void IEnviarM()
    {
        Console.WriteLine("estas enviando un mensaje a tu mama");

    }
    public  override void Apagar ()
    {
        Console.WriteLine("el celular se esta apagando");
    }
}

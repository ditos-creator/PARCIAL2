using System ;

public class Parcial()
{
    public static void Main(string[] args)
    {
        var tecnospark = new Celular();
        var lenovo = new TV();
        var alex = new Celular();

       Console.WriteLine("telefono");
        tecnospark.Prender();
        tecnospark.IEnviarM();
        tecnospark.Apagar();

       Console.WriteLine("TV");
       lenovo.Prender();
       lenovo.Apagar();

       Console.WriteLine("Alex");
       alex.Prender();
       alex.Apagar();
      

    
    }
}

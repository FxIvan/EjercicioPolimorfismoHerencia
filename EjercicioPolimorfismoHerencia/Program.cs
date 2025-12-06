//Actividad 1: Jerarquía simple y método polimórfico

//Objetivo: internalizar herencia + método sobrescrito + ejecución polimórfica.

//Crea una clase base Animal con un método HacerSonido().

//Crea 3 clases derivadas: Perro, Gato, Pato.

//Sobrescribe el método en cada derivada.

//Crea una lista de Animal y agrega un Perro, un Gato y un Pato.

//Ejecuta un bucle llamando HacerSonido().

//Qué aprendes:

//Una sola referencia (Animal) invoca comportamientos distintos.
abstract public class Animal
{
    abstract public void HacerSonido();
}


public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Wuo Wuo Wuo Wuo");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Mia Miau Miau");
    }
}

public class Pato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Quack Quack Quack");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Gato(),
            new Pato()
        };

        foreach (var animal in animales)
        {
            animal.HacerSonido();
        }
    }
}
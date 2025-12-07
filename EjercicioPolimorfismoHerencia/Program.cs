/*
Actividad 1: Jerarquía simple y método polimórfico

Objetivo: internalizar herencia + método sobrescrito + ejecución polimórfica.

- Crea una clase base Animal con un método HacerSonido().
- Crea 3 clases derivadas: Perro, Gato, Pato.
- Sobrescribe el método en cada derivada.
- Crea una lista de Animal y agrega un Perro, un Gato y un Pato.
- Ejecuta un bucle llamando HacerSonido().

Qué aprendes:
- Una sola referencia (Animal) invoca comportamientos distintos.

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
*/



/*
Actividad 2: Agregar datos y comportamiento común

Objetivo: comprender qué se hereda y qué se especializa.

En Animal, agrega: Nombre, Edad, Comer().

En derivadas, agrega comportamientos únicos:
- Perro.Correr()
- Gato.Arañar()
- Pato.Nadar()

En el programa:
- Crea varios animales
- Guarda todos como Animal en una lista
- Llama comportamientos de la clase base
- Luego baja al tipo concreto (casting seguro) solo cuando lo necesites

Qué aprendes:
- Qué es comportamiento común
- Qué es comportamiento específico
- Cómo conviven ambos

abstract public class Animal
{
    public string Nombre { get; set; }
    public int Edad {  get; set; }

    abstract public string Comer();
    abstract public string Arañar();
    abstract public string Nadar();
}

public class Perro : Animal
{
    public Perro()
    {
        this.Nombre = "Roko";
        this.Edad = 5;
    }
    public override string Arañar()
    {
        return "Abrime la puerta gatito";
    }

    public override string Comer()
    {
        return "yo estoy comiendo hueso del asado";
    }

    public override string Nadar()
    {
        return "Me meti a la pileta de mi dueño"; 
    }
}

public class Caballo : Animal
{
    public Caballo()
    {
        this.Nombre = "Mike tayson";
        this.Edad = 8;
    }
    public override string Arañar()
    {
        // El caballo no puede arañar
        throw new NotImplementedException();
    }

    public override string Comer()
    {
        return "Estoy comiendo pasto";
    }

    public override string Nadar()
    {
        // El caballo no puede nadar
        return "Estoy en un lago nadando";
    }
}

public class Pajaro : Animal
{
    public Pajaro()
    {
        this.Nombre = "Bichito de Luz";
        this.Edad = 4;
    }

    public override string Arañar()
    {
        // El caballo no puede arañar
        throw new NotImplementedException();
    }

    public override string Comer()
    {
        return "Estoy comiendo MAIZ";
    }

    public override string Nadar()
    {
        throw new NotImplementedException();
    }
}
*/

/*
Actividad 3: Polimorfismo aplicado a lógica real

Objetivo: entender para qué sirve realmente.

1.Crea una función:
   public void AtenderAnimal(Animal a)
   Dentro llama:
    - a.Comer()
    - a.HacerSonido()

2.Pásale distintos animales.

Qué aprendes:
- Un método puede recibir cualquier derivado sin que tú lo sepas de antemano.
- Polimorfismo = código más genérico y flexible.
 */

public class Animal
{
    public virtual string Comer()
    {
        return "El animal esta comiendo";
    }

    public virtual string HacerSonido()
    {
        return "El animal esta haciendo sonido";
    }

    public static void AtenderAnimal(Animal a)
    {
        string salidaComer = a.Comer();
        string salidaSonido = a.HacerSonido();
        Console.WriteLine(salidaComer + "\n" + salidaSonido);
    }
}

public class Perro : Animal
{
    public override string Comer()
    {
        return "El perro esta comiendo";
    }

    public override string HacerSonido()
    {
        return "El perro esta ladrando";
    }

}

public class Gato : Animal
{
    public override string Comer()
    {
        return "El gato esta comiendo un pescado";
    }

    public override string HacerSonido()
    {
        return "El gato esta maullando";
    }
}

class Program
{
    static void Main()
    {
        /*
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

        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Caballo(),
            new Pajaro(),
        };

        foreach (var animal in animales)
        {
            Console.WriteLine(
                "--------------------------- \n" +
                $"Nombre: {animal.Nombre}" +
                $"\nEdad: {animal.Edad}" +
                $"\nEstoy: { animal.Comer() }");

            if (animal.Nombre == "Mike tayson")
            {
                Console.WriteLine(
                "--------------------------- \n" +
                "Este es dato el caballo\n" +
                $"Nombre: {animal.Nombre}" +
                $"\nEdad: {animal.Edad}" +
                $"\nEstoy: {animal.Comer()}" +
                $"\nEstoy: {animal.Nadar()}" 
                );
            }
        }
        */

        Animal perro = new Perro();
        Animal gato = new Gato();

        Animal.AtenderAnimal(perro);
        Animal.AtenderAnimal(gato);
    }
};
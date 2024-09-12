namespace csharp;

using System;

public class OOPExercises
{

    class Voiture
    {
        private int portes;
        public int Portes
        {
            set
            {
                this.portes = value;
            }
            get
            {
                return this.portes;
            }
        }
    }

    class Maison
    {
        public int Fenetres
        {
            set; get;
        }
    }

    private readonly Voiture voiture;
    private readonly Maison maison;

    public OOPExercises()
    {
        Console.WriteLine("OOP Exercises: ");
        this.voiture = new();
        this.maison = new();
    }

    public void AccessorExercise1()
    {
        this.voiture.Portes = 4;
        Console.WriteLine($"La voiture a {this.voiture.Portes} portes.");
    }

    public void AccessorExercise2()
    {
        this.maison.Fenetres = 8;
        Console.WriteLine($"La maison a {this.maison.Fenetres} fenetres.");
    }

    ~OOPExercises()
    {
        Console.WriteLine("OOP Exercises Finished.\n");
    }

}
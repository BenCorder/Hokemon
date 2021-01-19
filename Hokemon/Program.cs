using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello to Hokeworld!");

            Hokemon hokeObject01 = new Hokemon(); // INSTANTIATION of object hokeObject01

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hokeObject01.get_details();

            Hokemon hoke02 = new Hokemon();  // INSTANTIATION of object 2

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            Console.WriteLine("Name of Hokemon: {0}", hoke02.Name);
            Console.WriteLine("***********");
            Console.WriteLine("****Details below***");
            hoke02.get_details();

            Hokemon hoke03 = new Hokemon();  // INSTANTIATION of object 2

            //Console.WriteLine("Hokemon name is: {0}", hokeObject01.Name);

            hoke03.get_details();

            Battle_Arena firstArena = new Battle_Arena(); // INSTANTIATED Battle_Arena

            firstArena.ChallengeMe(hokeObject01);

            firstArena.ChallengeAccepted(hokeObject01, hoke03); // Passing two objects into 
                                                                // the firstArena
            Hokemon hoke04 = new Hokemon(); //INSTANTIATION from Hokeon Class

            Halor haloHokemon01 = new Halor(); //INSTANTIATION from Hokeon Class
            haloHokemon01.get_details();

            //Demonstrating POLYMORPHISM with about method
            //a Hokemon instance hoke02
            //a halor instance haloHokemon01

        hoke02.about();
            haloHokemon01.about()
        /*
                    Battle_Arena firstArena = new Battle_Arena(); // INSTANTUATED Battle_Arena
          */
        }
    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Falcon = new Bird();

            Falcon.canFly = true;

            Falcon.featherColor = "Brown";

            Falcon.Wings = "Large";

            Falcon.Beak = "Sharp";

            Falcon.SizeOutof100 = 20;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile MonitorLizard = new Reptile();

            MonitorLizard.Scales = "Rough Scales";

            MonitorLizard.isHerbivore = false;

            MonitorLizard.Amphibious = "Land";

            MonitorLizard.hasTail = true;

            MonitorLizard.SizeOutof100 = 35; 

        }
    }
}

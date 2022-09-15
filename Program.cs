using System;

namespace Studieguide2
{
    internal class Program : Car
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Console.WriteLine("Välj del i uppgiften, 1 eller 2.");
            String input = Console.ReadLine();
            if (input == "1")
            {
                Car userCar = new Car();

                Console.WriteLine("\nVilket bilmärke?");
                userCar.carBrand = Console.ReadLine();

                Console.WriteLine("\nVilken modell?");
                userCar.model = Console.ReadLine();

                Console.WriteLine("\nVilken årsmodell?");
                userCar.make = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nHur många kilometer har den gått?");
                userCar.kilometer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nJaså, du har en " + userCar.carBrand + " av " + userCar.model + "-modell, från " + userCar.make +
                    ", och den har alltså gått " + userCar.kilometer + " kilometer, det låter intressant!");

                Console.WriteLine("\nProgrammet startar om...\n");

                Run();
            }
            else
            {
                Car car1 = new Car();

                Console.WriteLine("\nBetsäm bilmärke, modell, årsmodell och antal kilometer för bil 1");
                Console.WriteLine("Exempel: Volvo V90 2020 75000");
                input = Console.ReadLine();
                string[] data = input.Split(' ');
                car1.carBrand = data[0];
                car1.model = data[1];
                car1.make = Convert.ToInt32(data[2]);
                car1.kilometer = Convert.ToInt32(data[3]);

                Car car2 = new Car();

                Console.WriteLine("\nBetsäm bilmärke, modell, årsmodell och antal kilometer för bil 2");
                Console.WriteLine("Exempel: Volvo V90 2020 75000");
                input = Console.ReadLine();
                data = input.Split(' ');
                car2.carBrand = data[0];
                car2.model = data[1];
                car2.make = Convert.ToInt32(data[2]);
                car2.kilometer = Convert.ToInt32(data[3]);

                Car car3 = new Car();

                Console.WriteLine("\nBetsäm bilmärke, modell, årsmodell och antal kilometer för bil 3");
                Console.WriteLine("Exempel: Volvo V90 2020 75000");
                input = Console.ReadLine();
                data = input.Split(' ');
                car3.carBrand = data[0];
                car3.model = data[1];
                car3.make = Convert.ToInt32(data[2]);
                car3.kilometer = Convert.ToInt32(data[3]);

                Car car4 = new Car();

                Console.WriteLine("\nBetsäm bilmärke, modell, årsmodell och antal kilometer för bil 4");
                Console.WriteLine("Exempel: Volvo V90 2020 75000");
                input = Console.ReadLine();
                data = input.Split(' ');
                car4.carBrand = data[0];
                car4.model = data[1];
                car4.make = Convert.ToInt32(data[2]);
                car4.kilometer = Convert.ToInt32(data[3]);

                Console.WriteLine("\nBilförsäljaren har de här bilarna: ");

                Console.WriteLine("\nBil 1 - " + "Bilmärke: " + car1.carBrand + ", Modell: " + car1.model + ", Årsmodell: " +
                    car1.make + ", Antal kilometer: " + car1.kilometer);
                Console.WriteLine("\nBil 2 - " + "Bilmärke: " + car2.carBrand + ", Modell: " + car2.model + ", Årsmodell: " +
                    car2.make + ", Antal kilometer: " + car2.kilometer);
                Console.WriteLine("\nBil 3 - " + "Bilmärke: " + car3.carBrand + ", Modell: " + car3.model + ", Årsmodell: " +
                    car3.make + ", Antal kilometer: " + car3.kilometer);
                Console.WriteLine("\nBil 4 - " + "Bilmärke: " + car4.carBrand + ", Modell: " + car4.model + ", Årsmodell: " +
                    car4.make + ", Antal kilometer: " + car4.kilometer);

                Console.WriteLine("\nProgrammet startar om...\n");

                Run();
            }
        }
    }

    class Car
    {
        public string carBrand;
        public string model;
        public int make;
        public int kilometer;
    }

}

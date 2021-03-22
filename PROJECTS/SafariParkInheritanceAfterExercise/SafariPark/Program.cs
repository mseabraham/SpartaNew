using System;
using System.Collections.Generic;

namespace ClassesApp
{
    class Program
    {
      

    public static void SpartaWrite (Object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
        }
        // final Main for inheritance lecture
        static void Main(string[] args)
        {
            //POLYMORPHISM
            List<IShootable> gameWap = new List<IShootable>(){
            new LaserGun("Zapatron 500"),
            new WaterPistol("SuperSoaker Pro"),
            new Hunter("Michael", "Abraham", new Camera("IPhone")),
            new Camera("Panasonic")
            };

            foreach (var wap in gameWap)
            {
                Console.WriteLine( wap.Shoot()); 
            }


            //SHOOTOUT
            Console.WriteLine("\nPOLYMORPHIC SHOOTOUT!");
            Camera cam = new Camera("Disposable Camera");
            WaterPistol pistol = new WaterPistol("SuperSplasher");
            LaserGun laserGun = new LaserGun("RayGun");
            Hunter sam = new Hunter("Sammy", "Sniper", cam);
            Console.WriteLine(sam.Shoot());
            sam.Shooter = laserGun;
            Console.WriteLine(sam.Shoot());
            sam.Shooter = pistol;
            Console.WriteLine(sam.Shoot());
            sam.Shooter = laserGun;
            Console.WriteLine(sam.Shoot());

            //Hunter h = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //Hunter h2 = new Hunter();
            //Console.WriteLine(h2.Shoot());
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");

            /*
            List<Object> gameObject = new List<Object>()
            {
                new Person ("Michael", "Abraham"),
                new Airplane (400, 200, "booing"),
                new Vehicle(12,20),
                new Hunter ("Henry", "Hooray-Hodgkins", "Pentax")
            };

            foreach (var gameObj in gameObject)
            {
                Console.WriteLine(gameObj);
            }

            Person phillip = new Person("Phillip", "Shaw");
            SpartaWrite(phillip);*/
        }
    }
    
}

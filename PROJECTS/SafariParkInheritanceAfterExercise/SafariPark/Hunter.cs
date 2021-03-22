using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Hunter : Person, IShootable
    {
        //private string _camera;
        public IShootable Shooter { get; set; }

        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            //return $"{GetFullName()} has taken a photo with their {Shooter}";
            return $"{GetFullName()}... {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}

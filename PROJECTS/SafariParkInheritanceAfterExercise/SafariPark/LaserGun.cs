using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand) { }

        public override string Shoot()
        {
            return $"Zap!! {base.Shoot()}";
        }
    }
}
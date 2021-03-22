using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_83
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity, int speed, int altitude) : base(capacity, speed)
        {
            _altitude = altitude;

        }

        public void Ascend()
        {

        }

        public void Descend()
        {

        }

        public override string Move()
        {
            //return $"{base.Move()} times at an altitude of {_altitude} meters.";
        }
    }
}
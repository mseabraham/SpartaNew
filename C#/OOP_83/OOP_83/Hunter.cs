using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_83
{
    class Hunter : Person
    {

        private string _camera;

        public Hunter (string fName, string lName, string camera=""): base(fName, lName)
        {
            this._camera = camera;

        }

        public Hunter()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }


        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }
    }
}

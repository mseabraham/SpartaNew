using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public interface IMoveable
    {
        string Move();

        string Move(int times);
    }

    public interface IShootable
    {
        string Shoot();
    }
}

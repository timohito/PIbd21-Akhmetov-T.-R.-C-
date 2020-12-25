using System;
using System.Collections.Generic;

namespace Dozer
{
    class CarComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Dozer && y is Dozer)
            {
                return ComparerDozer((Dozer)x, (Dozer)y);
            }
            if (x is Car && y is Dozer)
            {
                return 1;
            }
            if (x is Dozer && y is Car)
            {
                return -1;
            }
            if (x is Car && y is Car)
            {
                return ComparerCar((Car)x, (Car)y);
            }
            throw new Exception();
        }

        private int ComparerCar(Car x, Car y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerDozer(Dozer x, Dozer y)
        {
            var res = ComparerCar(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Truba != y.Truba)
            {
                return x.Truba.CompareTo(y.Truba);
            }
            if (x.Kovsh != y.Kovsh)
            {
                return x.Kovsh.CompareTo(y.Kovsh);
            }
            return 0;
        }
    }
}

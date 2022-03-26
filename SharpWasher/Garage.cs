using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{

    internal class Garage<T> : IEnumerable<T>
    {
        private List<T> cars = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var car in cars)
            {
                yield return car;
            }
        }
        public void Add(T car)
        {
            cars.Add(car);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

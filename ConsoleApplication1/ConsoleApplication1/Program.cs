using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableEx
{
    class Program
    {
        public interface IComparableEx { int CompareTo(object other); }
        public interface IComparable<in T> { int CompareTo(T other); }

        static void Main(string[] args)
        {
            string[] colors = { "Green", "Red", "Blue", "Yellow" };
            Array.Sort(colors);
            foreach(string c in colors)
            {
                Console.Write(c + " ");
            }

            // Array.Sort(str[]) 메서드가 정렬을 제대로 수행하는 것은
            // System.String이 IComparable 인터페이스들을 구현하고 있기 때문.

            // IComparable
            Console.WriteLine("Beck".CompareTo("Anne"));        // 1
            Console.WriteLine("Beck".CompareTo("Beck"));        // 0
            Console.WriteLine("Beck".CompareTo("Chris"));       // -1

            // a.CompareTo(b)
            // a가 b보다 뒤에 와야 하면 양수를 리턴.
            // a가 b와 같은 위치이어야 하면 0 리턴.
            // a가 b보다 앞에 와야 하면 음수를 리턴.
        }
    }
}

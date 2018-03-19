using System.Linq;

namespace ChoiceA.Triangle
{
    public class Triangle
    {        
        public TriangleType GetTriangleType(int a, int b, int c)
        {
            if (!InputsAreValidForATriangle(a, b, c))
            {
                return TriangleType.Error;
            }

            int[] values = new int[3] { a, b, c };
            var numberOfDistinctSides = values.Distinct().Count();

            if (AllThreeSidesAreEqual(numberOfDistinctSides))
            {
                return TriangleType.Equilateral;
            }

            if (TwoSidesAreEqual(numberOfDistinctSides))
            {
                return TriangleType.Isosceles;
            }

            if (NoSidesAreEqual(numberOfDistinctSides))
            {
                return TriangleType.Scalene;
            }

            return TriangleType.Error;
        }

        private static bool InputsAreValidForATriangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            
            return false;
        }

        private static bool AllThreeSidesAreEqual(int numberOfDistinctSides)
        {
            return numberOfDistinctSides == 1;
        }


        private static bool TwoSidesAreEqual(int numberOfDistinctSides)
        {
            return numberOfDistinctSides == 2;
        }

        private static bool NoSidesAreEqual(int numberOfDistinctSides)
        {
            return numberOfDistinctSides == 3;
        }

    }   
}

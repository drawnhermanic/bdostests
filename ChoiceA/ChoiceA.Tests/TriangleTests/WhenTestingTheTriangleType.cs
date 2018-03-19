using ChoiceA.Triangle;
using NUnit.Framework;
using Should;
using SpecsFor;


namespace ChoiceA.Tests.TriangleTests
{
    public class WhenTestingTheTriangleType : SpecsFor<ChoiceA.Triangle.Triangle>
    {
        [TestFixture(-1, 2, 3)]
        [TestFixture(1, -2, 3)]
        [TestFixture(1, 2, -3)]
        [TestFixture(1, 2, -3)]
        [TestFixture(2, 2, 5)] //cannot make a triangle
        [TestFixture(10, 1, 1)] //cannot make a triangle
        public class GivenInvalidInputs : WhenTestingTheTriangleType
        {
            private readonly int _sideA;
            private readonly int _sideB;
            private readonly int _sideC;            
            private TriangleType _result;

            public GivenInvalidInputs(int sideA, int sideB, int sideC)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;                
            }                        

            protected override void When()
            {
                _result = SUT.GetTriangleType(_sideA, _sideB, _sideC);
            }

            [Test]
            public void ThenItShouldReturnATriangleErrorType()
            {
                _result.ShouldEqual(TriangleType.Error);
            }
        }

        [TestFixture(1, 1, 1, TriangleType.Equilateral)]
        [TestFixture(3, 3, 2, TriangleType.Isosceles)]
        [TestFixture(3, 6, 7, TriangleType.Scalene)]
        public class GivenValidInputs : WhenTestingTheTriangleType
        {
            private readonly int _sideA;
            private readonly int _sideB;
            private readonly int _sideC;
            private TriangleType _result;
            private TriangleType _expectedResult;

            public GivenValidInputs(int sideA, int sideB, int sideC, TriangleType expectedResult)
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
                _expectedResult = expectedResult;
            }

            protected override void When()
            {
                _result = SUT.GetTriangleType(_sideA, _sideB, _sideC);
            }

            [Test]
            public void ThenItShouldReturnTheExpectedTriangleType()
            {
                _result.ShouldEqual(_expectedResult);
            }
        }
    }
}

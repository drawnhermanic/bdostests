using ChoiceA.ReverseWords;
using NUnit.Framework;
using Should;
using SpecsFor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceA.Tests.ReverseWordsTests
{
    public class WhenTestingReverseWords : SpecsFor<ReverseWordsInString>
    {
        public class GivenAStringToReverse : WhenTestingReverseWords
        {
            private string _input;
            private string _expectedResult;
            private char[] _result;

            protected override void Given()
            {
                _input = "Cat";
                _expectedResult = "taC";
            }

            protected override void When()
            {
                _result = SUT.Process(_input.ToCharArray());
            }

            [Test]
            public void ThenItShouldReverseAWord()
            {
                _result.ShouldEqual(_expectedResult.ToCharArray());
            }
        }

        public class GivenASentenceOfWorkdsToReverse : WhenTestingReverseWords
        {
            private string _input;
            private string _expectedResult;
            private char[] _result;

            protected override void Given()
            {
                _input = "Cat and dog";
                _expectedResult = "taC dna god";
            }

            protected override void When()
            {
                _result = SUT.Process(_input.ToCharArray());
            }

            [Test]
            public void ThenItShouldReverseWordsInTheString()
            {
                _result.ShouldEqual(_expectedResult.ToCharArray());
            }
        }
    }
}

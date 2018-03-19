using ChoiceA.ReverseWords;
using NUnit.Framework;
using Should;
using SpecsFor;
using System;
using System.Collections.Generic;


namespace ChoiceA.Tests.ReverseWordsTests
{
    public class WhenTestingALinkedList : SpecsFor<ChoiceA.LinkedList.LinkedList<int>>
    {
        public class GivenAnInvalidNumberFromTheTail : WhenTestingALinkedList
        {
            private System.Exception _expectedException;
            private int? _result;

            protected override void Given()
            {
                SUT.AddNode(1);
                SUT.AddNode(2);
                SUT.AddNode(3);
            }

            protected override void When()
            {
                try
                {
                    _result = SUT.GetNodeFromTail(5)?.Data;
                }
                catch (System.Exception ex)
                {
                    _expectedException = ex;
                }
            }

            [Test]
            public void ThenItShouldThrowAnException()
            {
                _expectedException.ShouldBeType<IndexOutOfRangeException>();
            }
        }

        public class GivenALinkedList : WhenTestingALinkedList
        {
            private int _expectedCount;

            protected override void Given()
            {
                _expectedCount = 3;

                SUT.AddNode(1);
                SUT.AddNode(2);
                SUT.AddNode(3);
            }

            [Test]
            public void ThenItShouldReturnTheExpectedCount()
            {
                SUT.Count.ShouldEqual(_expectedCount);
            }
        }

        public class GivenALinkedListFindTheFifthElementFromTheTail : WhenTestingALinkedList
        {
            private int? _expectedResult;
            private int? _result;

            protected override void Given()
            {
                _expectedResult = 7;
                
                SUT.AddNode(11);
                SUT.AddNode(10);
                SUT.AddNode(9);
                SUT.AddNode(8);
                SUT.AddNode(7);
                SUT.AddNode(6);
                SUT.AddNode(5);
                SUT.AddNode(4);
                SUT.AddNode(3);
                SUT.AddNode(2);
            }

            protected override void When()
            {
                _result = SUT.GetNodeFromTail(5)?.Data;
            }

            [Test]
            public void ThenItShouldReturnTheExpectedElement()
            {
                _result.ShouldEqual(_expectedResult);
            }
        }        
    }
}

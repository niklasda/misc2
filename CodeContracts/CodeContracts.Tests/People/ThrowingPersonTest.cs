using System.Diagnostics.Contracts;
using CodeContracts.People;
using CodeContracts.People.Exceptions;
using CodeContracts.Tests.People.EventHandler;
using MbUnit.Framework;

namespace CodeContracts.Tests.People
{
    public class ThrowingPersonTest
    {
        [Test]
        public void TestThrowingPerson1()
        {
            Contract.ContractFailed += ContractFailed.Contract_ContractFailed;

            var farfar = new ThrowingPerson("St�lFarfar", 201);
            Assert.AreEqual("St�lFarfar", farfar.Name);
            Assert.AreEqual(201, farfar.Age);

        }

        [Test]
        [ExpectedException(typeof(AgeException))]
        public void TestThrowingPerson2()
        {
            Contract.ContractFailed += ContractFailed.Contract_ContractFailed;

            var poser = new ThrowingPerson("St�l", 201);
            Assert.IsNotNull(poser);
        }
    }
}
using FlowerShop;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            IClient c = Substitute.For<IClient>();
            IOrderDAO a = Substitute.For<IOrderDAO>();
            List<Flower> f = new List<Flower>();
            IOrder o = new Order(a, c, false);

            //Act
            o.Deliver();

            //Assert
            a.SetDelivered(Arg.Any<IOrder>());




            Assert.Pass();
        }
    }
}
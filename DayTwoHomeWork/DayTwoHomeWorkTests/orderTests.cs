using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayTwoHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpectedObjects;

namespace DayTwoHomeWork.Tests
{
    [TestClass()]
    public class orderTests
    {
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book_TotalAmount_ShouldBe_100()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100,quantity:1),
                new Book(name:"2",price:100,quantity:0),
                new Book(name:"3",price:100,quantity:0),
                new Book(name:"4",price:100,quantity:0),
                new Book(name:"5",price:100,quantity:0)
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 100;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
    }
}
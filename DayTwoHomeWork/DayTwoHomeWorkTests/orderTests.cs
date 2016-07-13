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
                new Book(name:"1",price:100),
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 100.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_1Book2_TotalAmount_ShouldBe_190()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100)
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 190.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }

        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_1_Book2_and_1_Book3_TotalAmount_ShouldBe_270()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100),
                new Book(name:"3",price:100),
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 270.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_1_Book2_and_1_Book3_and_1_Book4_TotalAmount_ShouldBe_320()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100),
                new Book(name:"3",price:100),
                 new Book(name:"4",price:100)
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 320.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_1_Book2_and_1_Book3_and_1_Book4_and_1_Book5_TotalAmount_ShouldBe_375()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100),
                new Book(name:"3",price:100),
                new Book(name:"4",price:100),
                new Book(name:"5",price:100)
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 375.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_1_Book2_and_2_Book3_TotalAmount_ShouldBe_370()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100),
                new Book(name:"3",price:100),
                new Book(name:"3",price:100),
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 370.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
        [TestMethod()]
        public void GetOrderTotalAmountTest_Buy_1_Book1_and_2_Book2_and_2_Book3_TotalAmount_ShouldBe_460()
        {
            //arrange 
            List<Book> buyList = new List<Book>()
            {
                new Book(name:"1",price:100),
                new Book(name:"2",price:100),new Book(name:"2",price:100),
                new Book(name:"3",price:100),
                new Book(name:"3",price:100),
            };
            var target = new order(buyList);

            //act
            var acutal = target.GetOrderTotalAmount();
            //assert
            var expected = 460.0;
            expected.ToExpectedObject().ShouldEqual(acutal);
        }
    }
}
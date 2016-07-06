using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneHomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
namespace DayOneHomeWork.Tests
{
    [TestClass()]
    public class OrderTests
    {
        private IEnumerable<Order> GetInputDataSet = new List<Order>()
        {
           new Order(1  ,1  ,11,21),
            new Order(2 ,2  ,12,22),
            new Order(3 ,3  ,13,23),
            new Order(4 ,4  ,14,24),
            new Order(5 ,5  ,15,25),
            new Order(6 ,6  ,16,26),
            new Order(7 ,7  ,17,27),
            new Order(8 ,8  ,18,28),
            new Order(9 ,9  ,19,29),
            new Order(10,10,20,30),
            new Order(11,11,21,31)
        };
        [TestMethod()]
        public void GetGroupSum_GroupBy_3_SumByCost_should_be_6_15_24_21()
        {
            //arrange
            IEnumerable<Order> input = GetInputDataSet;
            int groupBy = 3;
            int[] expected ={ 6, 15, 24, 21 };

            //act
            var actual = Order.GetGroupSum(input, groupBy, Order.ResultSumBy.Cost);

            //assetra
            expected.ToExpectedObject().ShouldEqual(actual);
            
        }
        [TestMethod()]  
        public void GetGroupSum_GroupBy_4_SumByRevenue_should_be_50_66_60()
        {
            //arrange
            var input = GetInputDataSet;
            int groupBy = 4;
            int[] expected = { 50, 66, 60 };

            //act
            var actual = Order.GetGroupSum(input, groupBy, Order.ResultSumBy.Revenue);
            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
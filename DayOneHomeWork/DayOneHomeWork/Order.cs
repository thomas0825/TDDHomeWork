using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneHomeWork
{
    public class Order
    {
        public enum ResultSumBy
        {
            Cost, Revenue
        }
        public static int[] GetGroupSum(IEnumerable<Order> orders,  int groupBy, ResultSumBy resultSumBy  )
        {
            var  result=new List<int>();
            int counter = 1;
            int tempSum = 0;
            foreach(var order in orders)
            {
                if(resultSumBy == ResultSumBy.Cost)
                {
                    tempSum += order.Cost;
                } else if(resultSumBy == ResultSumBy.Revenue) {
                    tempSum += order.Revenue;
                }

                if(counter / groupBy == 1)
                {
                    result.Add(tempSum);
                    counter = 1;
                    tempSum = 0;
                    continue;
                }
                counter++;
            }
            if(tempSum != 0) { result.Add(tempSum); }
            return result.ToArray<int>();
        }
 
        public Order(int id,int cost , int revenue , int sellprice)
        {
            ID = id;
            Cost = cost;
            Revenue = revenue;
            SellPrice = sellprice;              
        }

        public int Cost { get; private set; }
        public int ID { get; private set; }
        public int Revenue { get; private set; }
        public int SellPrice { get; private set; }
    }
}

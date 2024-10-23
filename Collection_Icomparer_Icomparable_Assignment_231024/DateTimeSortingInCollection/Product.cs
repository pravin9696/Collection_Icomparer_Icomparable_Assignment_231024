using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Icomparer_Icomparable_Assignment_231024.DateTimeSortingInCollection
{
    public class ProductAssignment
    {
        public void Solution()
        {
            Product p1 = new Product() {price=100,name="aaa",ManuDate=new DateTime(2024,12,10) };
            Product p2 = new Product() { price = 80, name = "bbb", ManuDate = new DateTime(2024, 12, 09) };
            Product p3 = new Product() { price = 100, name = "ccc", ManuDate = new DateTime(2024, 11, 10) };
            Product p4 = new Product() { price = 80, name = "ddd", ManuDate = new DateTime(2024, 12, 10) };

            ArrayList ProdArrayList = new ArrayList() { p1,p2,p3};            
            ProdArrayList.Add(p4);
            Console.WriteLine("all production information");
            foreach (var item in ProdArrayList)
            {
                Product tempP = item as Product;
                tempP.showProduct();
            }
            Console.WriteLine("sort product price price and Manu.Date");
            ProdArrayList.Sort();
            foreach (var item in ProdArrayList)
            {
                Product tempP = item as Product;
                tempP.showProduct();
            }
        }
    }
    internal class Product:IComparable
    {
        public int price { get; set; }
        public string name { get; set; }
        public DateTime ManuDate { get; set; }

        public void showProduct()
        {
            Console.WriteLine($"Price ={price} Manu.Date ={ManuDate.ToShortDateString()} Name ={name}");
        }
        public int CompareTo(Object obj)
        {
            Product temp = obj as Product;

            if (this.price > temp.price)
            {
                return 1;//assending order sorting
            }
            else if (this.price < temp.price)
            {
                return -1;
            }
            else // price are equal
            {
                //Arrange product by Mdate
                if (this.ManuDate>temp.ManuDate)
                {
                    return 1;
                }
                else if(this.ManuDate<temp.ManuDate)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }

        }
    }
}

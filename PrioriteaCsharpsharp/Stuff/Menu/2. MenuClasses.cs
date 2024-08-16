using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioriteaCsharpsharp
{
    //------------------CLASSES------------------//
    public class milkteadata
    {
     
        public double price;
        public int valqua;
        public double priceval;

        public milkteadata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class frappedata
    {

        public double price;
        public int valqua;
        public double priceval;

        public frappedata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class fruitteadata
    {

        public double price;
        public int valqua;
        public double priceval;

        public fruitteadata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class oreomixesdata
    {

        public double price;
        public int valqua;
        public double priceval;

    public oreomixesdata(double mprice, int mvalqua, double mpriceval)
    {
        price = mprice;
        valqua = mvalqua;
        priceval = mpriceval;
    }
    }
    public class icedblendedcoffeedata
    {

        public double price;
        public int valqua;
        public double priceval;

        public icedblendedcoffeedata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class cheesecakedata
    {

        public double price;
        public int valqua;
        public double priceval;

        public cheesecakedata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class yakultmixesdata
    {

        public double price;
        public int valqua;
        public double priceval;

        public yakultmixesdata(double mprice, int mvalqua, double mpriceval)
        {
            price = mprice;
            valqua = mvalqua;
            priceval = mpriceval;
        }
    }
    public class addonsdata
    {
        public double adding;
        public double addval;
        public double[] addons = new double[] { 10, 15, 15, 20, 20, 20 };

        public addonsdata(int v)
        {
        }

        public addonsdata(double madding, double[] marray, double maddval)
        {
            adding = madding;
            addons = marray;
            addval = maddval;
        }            

    }

    public class totals
    {
        public double totalprice;
        public int totalquantity;
        
        public totals(double totprice, int totquantity)
        {
            totalprice = totprice;
            totalquantity = totquantity;
        }
    }
}

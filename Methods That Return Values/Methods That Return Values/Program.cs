using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;

//Use methods to calculate the total purchase price
/*double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10, 98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)                           //You use the for loop to get the sum of all of the discounted item prices
{
    total += GetDiscountedPrice(i);  
}
caleb samcollins kaniu alfred brian johnte victork andy mandela mark
amake boruett maxwell jeddy mutonga poze barongo kerre njiru kevind
moha khalid boru farah yasin abdiaziz nura gideon kabachia fabian 
phil ken kagwagwa fredrick mweki powon carl indasi timo muriki 
billy davi jemo atika mwangangi simon gaiti mf segera felix
iank kiruka keepon warui collins austin bruce kelvinm ted josphat
francis
total -= TotalMeetsMinimum() ? 5.00 : 0.00;                      //Since TotalMeetsMinimum returns a bool value, you can call the method 

Console.WriteLine($"Total: ${FormatDecimal(total)}");            //Use FormatDecimal to format the displayed purchase price
mark eric kelvin austin nyandusi obare abdiaziz amake jemo banda 
mf solo kinyanjui somo samcollins johnte warui bitega andy mark
muema danden dagi bencarson jamal maulid teddy brando pascal glen
savio gaitungu kagwe victorm job lesan trapper shem victor sbho  
jeff kiruka alex ken linus timo mbirwe masinde arnold ken   
roy steve malcolm johnte winston gachango roy jasper lincoln 
double GetDiscountedPrice(int itemIndex)
{                                                                  22N   11W  3NW  
    //Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);        //The value returned must match the data type specified in the method signature.
}
bool TotalMeetsMinimum()                                         //You return the result of the comparison that evaluates to a bool
{
    //Check if the total meets the minimum
    return total>=minimumSpend;

}

string FormatDecimal(double input)
{
    //Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);                     //You can call othr methods in a return statement expression
}
//Output:    Total: $44.58 */


//Return Numbers From Methods

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd}\t USD\t =\t ${vnd}\t VND"); 
Console.WriteLine($"${vnd}\t VND\t =\t {VndToUsd(vnd)}\t\t USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd/rate;
}
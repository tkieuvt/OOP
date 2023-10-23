// See https://aka.ms/new-console-template for more information
using System;
// class Chitieu
// {
//     double income,outcome;
//     public double balance,cost;
//     public double Income
//     {
//         get {return income;}
//         set {income=value;}
//     }
//     public double Outcome
//     {
//         get {return outcome;}
//         set {outcome=value;}
//     }
//     public void tinh(double income,double outcome)
//     {
//         cost = outcome/income*100;
//         balance = income-outcome;
//         Console.WriteLine("so du:{0} \nmuc chi tieu:{1}",balance,cost);
//         if ((balance<10) | (cost>90)) 
//         {
//             Console.WriteLine("sap het tien");
//         }
//         else {Console.WriteLine("Con tien");}
//     }
// }
class Chitieu
{
    double income,outcome,balance,cost;
    public Chitieu(double income,double outcome)
    {
        this.income=income;
        this.outcome=outcome;
    }
    public double Cost
    {
        get {return outcome/income*100;}
    }
    public double Balance
    {
        get {return income-outcome;}
    }
    public void ktr()
    {
        Console.WriteLine("so du:{0} \nmuc chi tieu:{1}",Balance,Cost);
        if ((Balance<=10) | (Cost>=90)) 
        {
            Console.WriteLine("sap het tien");
        }
        else {Console.WriteLine("Con tien");}
    }
}
class baitap
{
    static void Main(string[] args)
    {
        Chitieu chitieu = new Chitieu(520,500);
        chitieu.ktr();
    }
}



Console.WriteLine("welcome- to Acacia accounting system");
Console.WriteLine("inter the costum type gold - silver - regular ");
string costumtype = Console.ReadLine();
Console.WriteLine("inter the invoice value");
double invoicevalue = Convert.ToInt32(Console.ReadLine());
double tot1 = 0;
double tot2= 0;
double tot3 = 0;
double desc1=0;
double desc2 = 0;
double totdesc = 0;
if (costumtype=="gold")
{
    tot1 = invoicevalue * 0.8;
    desc1 = invoicevalue * .2;
        if (invoicevalue>100)
    { 
        desc2 = invoicevalue * .05;
        totdesc=desc1+ desc2;
        tot2 = invoicevalue-desc1-desc2;
    }
        else
    {
        tot2 = tot1;
       
    }
    Console.WriteLine($"the total invoice value is:"); Console.WriteLine(invoicevalue);
    Console.WriteLine($"the coustm type desc valu:"); Console.WriteLine(desc1);
    Console.WriteLine($"the over limt desc valu:"); Console.WriteLine(desc2);
    Console.WriteLine($"the total desc valu:"); Console.WriteLine(totdesc);
    Console.WriteLine($"the net invoice value is:"); Console.WriteLine(tot2);
}

else if (costumtype == "silver")
{
    tot1 = invoicevalue * 0.9;
    desc1 = invoicevalue * 0.1;
    if (invoicevalue > 100)
    {
        desc2 = invoicevalue * .03;
        totdesc = desc1 + desc2;
        tot2 = invoicevalue - desc1 - desc2;
    }
    else
    {
        tot2 = tot1;

    }
    Console.WriteLine($"the total invoice value is:"); Console.WriteLine(invoicevalue);
    Console.WriteLine($"the coustm type desc valu:"); Console.WriteLine(desc1);
    Console.WriteLine($"the over limt desc valu:"); Console.WriteLine(desc2);
    Console.WriteLine($"the total desc valu:"); Console.WriteLine(totdesc);
    Console.WriteLine($"the net invoice value is:"); Console.WriteLine(tot2);
}

else if (costumtype == "regular")
{
    tot1 = invoicevalue * 0.95;
    desc1 = invoicevalue * 0.05;
    totdesc = desc1 + desc2;
    if (invoicevalue > 100)
    {
        desc2 = invoicevalue * .02;
        tot2 = invoicevalue - desc1 - desc2;
    }
    else
    {
        tot2 = tot1;

    }
    Console.WriteLine($"the total invoice value is:"); Console.WriteLine(invoicevalue);
    Console.WriteLine($"the coustm type desc valu:"); Console.WriteLine(desc1);
    Console.WriteLine($"the over limt desc valu:"); Console.WriteLine(desc2);
    Console.WriteLine($"the total desc valu:"); Console.WriteLine(totdesc);
    Console.WriteLine($"the net invoice value is:"); Console.WriteLine(tot2);
}


else 
    {
    Console.WriteLine($"the total invoice value is:"); Console.WriteLine(invoicevalue);
    Console.WriteLine($"the over limt desc valu: 0 ");
    Console.WriteLine("the costum is normal");
}

Console.WriteLine("thank you");
Console.WriteLine("programing by amer");
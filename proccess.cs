using System;
//روند انجام عملیات
public class proccess
{
hesab h = new hesab();   
//پر کردن حساب 
public void fill()
{

h.Name="alireza";
h.family="razavi";
h.cartnumber="6219861046101464";
h.mojodi=35000000;
h.pass=7777;
}
//چک کردن پسورد و ورود
public void checkpass()

{
    int pas;


do
{
    System.Console.WriteLine("-------------------------------------------------");
System.Console.WriteLine("pass khod ra vared konid");

pas=Convert.ToInt32(Console.ReadLine());

if (pas != h.pass)
{
   System.Console.WriteLine("-----pass eshtebah ast-----"); 
   
}
} while (pas != h.pass);

showmenu();
}

//موجودی
public void mojodi()
{
System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine("mojodi="+h.mojodi);

showmenu();
}
//عوض کردن پسورد
public void changepass()
{
     System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine("***ramze jadid khod ra vared konid***");
h.pass=Convert.ToInt32(Console.ReadLine());
checkpass();

}
//برداشت وجه
public void bardasht()
{
    System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine("5000=>1");
System.Console.WriteLine("10000=>2");
System.Console.WriteLine("20000=>3");
System.Console.WriteLine("50000=>4");
System.Console.WriteLine("saire mabaleq=>5");
System.Console.WriteLine("laghve amalyat=>6");
System.Console.WriteLine("-----------------------------------------------------------");
 int p=Convert.ToInt32(Console.ReadLine( )); 

 if (p==1)
{
pang();
}

if (p==2)
{
  dah(); 
}
   
if (p==3)
{
  bist(); 
}
if (p==4)
{
  pangah(); 
}
if (p==5)
{
  bardashtevajh(); 
}
if (p==6)
{
  showmenu();
}
}


public void pang()
{

h.mojodi=h.mojodi-5000;
System.Console.WriteLine("--------------------------");

System.Console.WriteLine("****amaliat anjam shod****");
showmenu();
}
public void dah()
{

h.mojodi=h.mojodi-10000;
System.Console.WriteLine("--------------------------");
System.Console.WriteLine("****amaliat anjam shod****");
showmenu();
}
public void bist()
{

h.mojodi=h.mojodi-20000;
System.Console.WriteLine("--------------------------");
System.Console.WriteLine("****amaliat anjam shod****");
showmenu();
}
public void pangah()
{

h.mojodi=h.mojodi-50000;
System.Console.WriteLine("--------------------------");
System.Console.WriteLine("amaliat anjam shod");
showmenu();
}

public void bardashtevajh()
{
int m;

do
{ System.Console.WriteLine("------------------------------------------------------");
    System.Console.WriteLine("mablaq ra vared konid");
    m=Convert.ToInt32(Console.ReadLine());
    if (m>h.mojodi)
    {
        System.Console.WriteLine("---in meqdar qable anjam nemibashad---");
    }
   
} while (m>h.mojodi);
h.mojodi=h.mojodi-m;
showmenu();
}


//کارت به کارت
public void cart()
{
string cart;


do
{
    System.Console.WriteLine("------------------------------------------------------");
   System.Console.WriteLine("shomare cart maqsad ra vared konid"); 
cart=Console.ReadLine();
if(cart==h.cartnumber)
{
System.Console.WriteLine("*****shomare cart sahih nemibashd*****");
System.Console.WriteLine("------------------------------------------");
   System.Console.WriteLine("shomare cart maqsad ra vared konid"); 
cart=Console.ReadLine();
}

} while (cart.Length!=16 );
bardasht();

}

//خرید شارژ
public void menu()
{

    System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine("hamrah aval=>1");
System.Console.WriteLine("irancel=>2");
System.Console.WriteLine("raitel=>3");
System.Console.WriteLine("laghve amalyat=>4");
System.Console.WriteLine("-----------------------------------------------------------");
 int s=Convert.ToInt32(Console.ReadLine( )); 

 if (s==1)
{
irancel();
}

if (s==2)
{
  hamrahaval(); 
}
   
if (s==3)
{
  raitel(); 
}
if (s==4)
{
    showmenu();
}
}

public void irancel()
{
string irancel;
do
{
    
    System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("shomare mobaile khod ra vared konid");
    irancel=Console.ReadLine();
    if (irancel.Length!=11)
    {
        System.Console.WriteLine("****shomare vared shode sahih nemibashad****");
    }
    
    
    
} while (irancel.Length!=11);
bardasht();
}
public void hamrahaval()
{
string hamrah;

do
{
      System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("shomare mobaile khod ra vared konid");
    hamrah=Console.ReadLine();
    if (hamrah.Length!=11)
    {
              System.Console.WriteLine("****shomare vared shode sahih nemibashad****");
    }
    
} while (hamrah.Length!=11);
bardasht();
}
public void raitel()
{
string raitel;

do
{
      System.Console.WriteLine("---------------------------------------");
    System.Console.WriteLine("shomare mobaile khod ra vared konid");
    raitel=Console.ReadLine();
    if (raitel.Length!=11)
    {
              System.Console.WriteLine("****shomare vared shode sahih nemibashad****");
    }
    
} while (raitel.Length!=11);
bardasht();
}



//منو

public void showmenu()
{
    System.Console.WriteLine("------------------------------------------------------");
System.Console.WriteLine("mojodi=>1");
System.Console.WriteLine("changepass=>2");
System.Console.WriteLine("bardasht=>3");
System.Console.WriteLine("cart be cart=>4");
System.Console.WriteLine("kharide sharjh=>5");
System.Console.WriteLine("etmam amaiat=>6");
System.Console.WriteLine("-----------------------------------------------------------");
 int a=Convert.ToInt32(Console.ReadLine( )); 
if (a==1)
{
mojodi();
}

if (a==2)
{
    changepass();
}
if (a==3)
{
    bardasht();
}

if (a==4)
{
    cart();
}
if(a==5)
{
menu();
}

if (a==6)
{
    System.Console.WriteLine("etmam ");
}

}


}
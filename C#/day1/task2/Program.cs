/*
 Task 2:
Write a C# program to display all the types of Variables in Console Application.
- Needs to Add variables like,
A) String Variable
B) Integer Variable
C) Float Type Variable
D) Long Type Variable
E) Double Type Variable
F) Bool Variable
G) Char Type Variable
- Needs to add examples also.
1) Create a variable without assigning a value, and assign the value later
2) Overwrite an existing variable value
3) Combine text and variable on display
4) Add a variable to another variable
5) Declare many variables of the same type with a comma separated list
 */


//1)
string mystring;
int myint;
float myfloat;
long mylong;
Double mydouble;
bool mybool;
char mychar;
mystring = "hello om dave here";
myint = 0;
myfloat = 0.5f;
mylong = 1000000;
mydouble = 6545.415D;
mybool = false;
mychar = 'O';
Console.WriteLine("1)");
Console.WriteLine("this is variable contain string datatype : " + mystring);
Console.WriteLine("this is variable contain int datatype : " + myint);   
Console.WriteLine("this is variable contain float datatype : " + myfloat); 
Console.WriteLine("this is variable contain long datatype : " + mylong);  
Console.WriteLine("this is variable contain Double datatype : " + mydouble);    
Console.WriteLine("this is variable contain bool datatype : " + mybool);  
Console.WriteLine("this is variable contain char datatype : " + mychar);
//2)
Console.WriteLine("2)");

mystring = "Om dave from theonetechnologies";
Console.WriteLine("overwritten string value: " + mystring);

//3)
Console.WriteLine("3)");

Console.WriteLine("this is variable contain char datatype : " + mychar);

//4)
Console.WriteLine("4)");

int myint1 = myint;
Console.WriteLine("the value of myint1 is :" +myint1);

//5)
Console.WriteLine("5)");

int a, b, c, d, e;
a = 10;
b = c = d = e = a;
Console.Write( b );
Console.ReadKey();
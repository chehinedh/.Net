// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;

Plane plane = new Plane();
plane.Capacity= 2000;
plane.ManufactureDate=DateTime.Now;
plane.Planeid = 1;
plane.Planetyp = Planetype.Boing;

 Plane plane2= new Plane(2100,DateTime.Now,Planetype.Airbus);



Passenger passenger= new Passenger();
passenger.FirstName = "houssem";
passenger.LastName = "balti";
Console.WriteLine( passenger.Checkprofile("houssem", "balti"));
Passenger Staff= new Staff();
Passenger traveller = new Traveller();
passenger.PassengerType();
Staff.PassengerType();
traveller.PassengerType();

ArrayList list = new ArrayList();
list.Add(passenger);
list.Add(12);
list.Add("Hello");
foreach(var item in list)
{
    Console.WriteLine(item);
}

List<int> list2 = new List<int>();
list2.Add(1);
list2.Add(2);
List<Plane> planes = new List<Plane>()
{
    plane,new Plane(1200,DateTime.Now,Planetype.Boing)
};
foreach(var item in planes)
{
    Console.WriteLine(item);
};
Action<String,int> action;
static void Test(string a ,int v) { };
action = delegate(string a ,int b) { };
action("hello",2);
Func<Boolean,string,double> func;
static double  Test2(Boolean a,string b) { return 0; }
func =  (Boolean a , string b)=>10;
double a =func(true,"houssem");
Console.WriteLine(a);
Flight flight= new Flight();
flight.Destination = "Paris";
ServiceFlight service = new ServiceFlight();
service.GetFlights("Paris", delegate (string a, Flight flight)
{
    return flight.Destination == a;
});

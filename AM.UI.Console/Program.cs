// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;

Plane plane = new Plane();
plane.Capacity= 2000;
plane.ManufactureDate=DateTime.Now;
plane.Planeid = 1;
plane.Planetyp = Planetype.Boing;

 Plane plane2= new Plane(2100,DateTime.Now,Planetype.Airbus);



Passenger passenger= new Passenger();
passenger.FirstName = "chehine";
passenger.LastName = "dhemaied";
Console.WriteLine( passenger.Checkprofile("chehine", "dehamied"));
Passenger Staff= new Staff();
Passenger traveller = new Traveller();
passenger.PassengerType();
Staff.PassengerType();
traveller.PassengerType();





using Domain.Model;
using Intrastructure.Service;

var carServise=new CarServise();
int n=0;
while(true){
    System.Console.WriteLine();
    System.Console.WriteLine("input 1 for get cars");
System.Console.WriteLine("input 2 for add cars");
System.Console.WriteLine("input 3 for updete cars");
System.Console.WriteLine("input 4 for delete cars");
System.Console.WriteLine("input 5 for search cars");
System.Console.WriteLine("input 6 for exit  program");
System.Console.WriteLine();

var input =Convert.ToInt32(Console.ReadLine());
if(input==1){
    var cars=carServise.GetCars();

for (int i = 0; i < cars.Count(); i++)
{
    
    System.Console.WriteLine($"Id->{cars[i].Id=i+1}");
    System.Console.WriteLine($"Name->{cars[i].Name}");
    System.Console.WriteLine($"Color->{cars[i].Color}");
    System.Console.WriteLine($"Release->{cars[i].Release}");
    System.Console.WriteLine($"Mileage->{cars[i].Mileage}");
    System.Console.WriteLine($"Price->{cars[i].Price}");
        System.Console.WriteLine("//---------------------------------------\\");


}

}else if(input==2){
    var  car= new Cars();
    
   
    car.Name=System.Console.ReadLine();
    car.Color=System.Console.ReadLine();
    car.Release=Convert.ToInt16(Console.ReadLine());
    car.Mileage=Convert.ToInt16(Console.ReadLine());
    car.Price=Convert.ToInt16(Console.ReadLine());
    carServise.AddCars(car);

}else if(input==3){
var updetecar=new Cars(){
    Id=Convert.ToInt16(Console.ReadLine()),
    Name=System.Console.ReadLine(),
    Color=System.Console.ReadLine(),
    Release=Convert.ToInt16(Console.ReadLine()),
    Mileage=Convert.ToInt16(Console.ReadLine()),
    Price=Convert.ToInt16(Console.ReadLine()),
};
carServise.UpdateCar(updetecar);
}else if(input==4){
    var id=Convert.ToInt16(Console.ReadLine());
    carServise.DeleteCar(id);
}else if(input==5){
    int _id=Convert.ToInt16(Console.ReadLine());
   var car=carServise.GetCars();
  System.Console.WriteLine($"   { car[_id-1].Name}");
System.Console.WriteLine( $"    {car[_id-1].Color}");
System.Console.WriteLine( $"    {car[_id-1].Release}");
System.Console.WriteLine( $"    {car[_id-1].Release}");
System.Console.WriteLine($"     { car[_id-1].Mileage}");

}else if(input==6){
    return 0;
}


}

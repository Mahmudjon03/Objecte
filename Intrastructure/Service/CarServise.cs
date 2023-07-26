namespace Intrastructure.Service;
using Domain.Model;
public class CarServise
{
    List<Cars> _car;
    public CarServise()
    {
        _car=new List<Cars>();
    }
    public List<Cars> GetCars(){
        return _car;
    }
    public void AddCars(Cars car){
        if(car==null){
            System.Console.WriteLine("fill the properties");
        }else{
           
           
           
          _car.Add(car);
        }
    }
    public string UpdateCar(Cars carr)
    {
        var found=_car.Find(x=>x.Id==carr.Id);
        if(found==null){
            System.Console.WriteLine("car not found");
        }
        found.Name=carr.Name;
        found.Color=carr.Color;
        found.Mileage=carr.Mileage;
        found.Price=carr.Price;
        found.Release=carr.Release;
        return "Update successfully";
    }
    public string DeleteCar(int id){
      var found= _car.Find(x=>x.Id==id);
       if(found==null){
            System.Console.WriteLine("car not found");
        }
        _car.Remove(found);
        return "Delete successfully";
        
        }
        }

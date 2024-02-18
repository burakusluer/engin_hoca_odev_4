Customer customer=new Customer() {Id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara" };
Customer customer3 = new Customer();
Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

Console.WriteLine(customer2.FirstName);
class Customer
{
    public Customer()
    {
        
    }
    public Customer(int id,string FirstName,string LastName,string City)
    {
        this.Id = id;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.City = City;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}
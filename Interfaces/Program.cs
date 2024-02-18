IPersonManager employeeManager=new EmployeeManager();//interface ve abstractlar newlenemez
IPersonManager customerManager=new CustomerManager();//interface ve abstractlar newlenemez
ProjectManager projectManager=new ProjectManager();
projectManager.Add(customerManager);

interface IPersonManager
{
	public void Add();
	public void Update();
}
class CustomerManager : IPersonManager
{
    public int denem { get; set; }
    public void Add()
    {
        //Müşteri Ekleme Kodları
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Çalışan Ekleme Kodları
        Console.WriteLine("Çalışan Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Çalışan Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}
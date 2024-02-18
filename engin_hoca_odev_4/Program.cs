//value type
//int sayi1 = 10;
//int sayi2 = 20;
//sayi1 = sayi2;
//sayi2 = 100;
//Console.WriteLine($"sayı1 in değeri:{sayi1}");

//reference type but immutable
//string isim1 = new string("Burak");
//string isim2 = "Kaan";
//isim1 = isim2;
//isim2 = "eskiden Kaan idi";
//Console.WriteLine($"isim1 degisken degeri:{isim1}");

//reference type
//int[] sayiDizi1 = new int[3] { 1, 2, 3 };
//int[] sayiDizi2 = new int[3] { 4, 5, 6 };
//sayiDizi1 = sayiDizi2;
//sayiDizi2[0] = 14;
//sayiDizi2 = [15,16,17];//its newly constructed new reference not same as sayiDizi1

//foreach (int sayi in sayiDizi1)
//{
//    Console.WriteLine(sayi);
//}

Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Derin";
Console.WriteLine(person2.FirstName);//Derin

Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "12312312";
Employee employee = new Employee();
employee.FirstName = "Ahmet";

Person person3 = customer;


//Console.WriteLine($"person as a customer FirstName:{person3.FirstName}/CreditCardNumber:{((Customer)person3).CreditCardNumber}");

PersonManager personManager = new PersonManager();
personManager.Add(employee);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}
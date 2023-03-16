// See https://aka.ms/new-console-template for more information

using Polimorphism;
Console.WriteLine("Hello, World!");
HoricotBean horicotBean = new HoricotBean {
    Name = "Horicot bean"
};
Baklava baklava = new Baklava
    {Name = "Baklava"};


Chef chef = new Chef();

chef.Cook(horicotBean);
chef.Cook(baklava);


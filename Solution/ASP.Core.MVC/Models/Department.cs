namespace ASP.Core.MVC.Models
{
    public class Department
    {
        public List<Person> stuff;
        public string name;
        public Person Boss;
        static Department self=null;
        public static Department Create()
        {
            return self;
        }
        static Department()
        {
            self = new Department
            {

                stuff = new List<Person>{ new Person { Name="A",Surname= "B",Patronymic="C",Birth=DateTime.Now,Post="Worker" }
                  , new Person { Name="A1",Surname= "B",Patronymic="C",Birth=DateTime.Now,Post="Worker" }
                  , new Person { Name="A2",Surname= "B",Patronymic="C",Birth=DateTime.Now,Post="Worker" }
                  , new Person { Name="A3",Surname= "B",Patronymic="C",Birth=DateTime.Now,Post="Worker" }
                  , new Person { Name="A4",Surname= "B",Patronymic="C2",Birth=DateTime.Now,Post="Boss" }
                  , new Person { Name="A5",Surname= "B",Patronymic="C2",Birth=DateTime.Now,Post="Worker" }
                  , new Person { Name="A6",Surname= "B",Patronymic="C2",Birth=DateTime.Now,Post="Worker" }
            }
            };
            self.name = "Отдел расследований";
            self.Boss = self.stuff[4];
        }
    }
    public class Person
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public DateTime Birth;
        public string Post;
        public override string ToString()
        {
            return $"{Name} {Patronymic} {Surname}";
        }
    }
}

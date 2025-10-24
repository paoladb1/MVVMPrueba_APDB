using MVVMPrueba_APDB.Models;

namespace MVVMPrueba_APDB.ViewModel;

internal class PersonviewModel
{
    public person Person { get; set; }
    public PersonviewModel()
    {
        Person = new Person()
         {

            Name = "Paola",
            Age = 19,
            Married = true,
            Birthday = new DateTime(2006, 14, 06),
            Weight = 70,
            LunchTime = new TimeSpan(14, 0, 0)



        };

    }
}

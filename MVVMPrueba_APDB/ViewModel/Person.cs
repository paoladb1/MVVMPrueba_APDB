using MVVMPrueba_APDB.Models;

namespace MVVMPrueba_APDB.ViewModel
{
    internal class Person : person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Married { get; set; }
        public DateTime Birthday { get; set; }
        public int Weight { get; set; }
        public TimeSpan LunchTime { get; set; }
    }
}
namespace MVVMPrueba_APDB.ViewModel;


internal class GenteviewModel
{

    public List<string> Gente { get; set; }

    public GenteviewModel()
    {
        Gente = new List<string>
        {
            "Juan",
            "Maria",
            "Pedro",
            "Ana",
            "Luis"
        };
    }
}
public class Vehiculo{
    private string Nombre;
    private string TipoDeCombustible;
    private string Marca;
    private string Estado;
    public string FrasedeMovimiento;
    public Vehiculo(){

    }
    public Vehiculo(string nombre, string tipoCom, string marca, string estado){
        Nombre = nombre;
        TipoDeCombustible = tipoCom;
        Marca = marca;
        Estado = estado;
    }
    public Vehiculo(string nombre, string tipoCom, string marca, string estado, string frasedeMovimiento){
        Nombre = nombre;
        TipoDeCombustible = tipoCom;
        Marca = marca;
        Estado = estado;
        FrasedeMovimiento = frasedeMovimiento;
    }
    public string getNombre(){
        return Nombre;
    }
    public string getTipodeCombustible(){
        return TipoDeCombustible;
    }
    public string getMarca(){
        return Marca;
    }
    public string getEstado(){
        return Estado;
    }
    public void setNombre(string aux){
        Nombre = aux;
    }
    public void setTipodeCombustible(string aux){
        TipoDeCombustible = aux;
    }
    public void setMarca(string aux){
        Marca = aux;
    }
    public void setEstado(string aux){
        Estado = aux;
    }
    public void Moverse(){
        string Aux = "";
        for(int i =0; i < FrasedeMovimiento.Length; i++){
            Aux += "-";
        }
        Console.WriteLine(@$"
| {Aux}
| {FrasedeMovimiento}
| {Aux}");
    }
}
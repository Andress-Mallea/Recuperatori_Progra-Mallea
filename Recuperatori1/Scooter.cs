public class Scooter: Vehiculo{
    private string FrasedeMovimientoScooter = "Avanzando con batería eléctrica";
    private int NumeroLLantas = 3;
    public Scooter(string nombre, string marca, string estado){
        setNombre(nombre);
        setTipodeCombustible("Baterias Electricas");
        setMarca(marca);
        setEstado(estado);
        FrasedeMovimiento = FrasedeMovimientoScooter;
    }
    public void Moverse(){
        string Aux = "";
        for(int i =0; i < FrasedeMovimientoScooter.Length; i++){
            Aux += "-";
        }
        Console.WriteLine(@$"
| {Aux}
| {FrasedeMovimientoScooter}
| {Aux}");
    }
}

public class Bicicleta: Vehiculo{
    private int NumeroLLantas = 2;
    public Bicicleta(string nombre, string marca, string estado){
        setNombre(nombre);
        setTipodeCombustible("Ezfuerzo");
        setMarca(marca);
        setEstado(estado);
        
    }
    public void Moverse(){
        string Aux = "";
        string FrasedeMovimientoBicileta = $"Pedalenado Con {getTipodeCombustible}";
        for(int i =0; i < FrasedeMovimientoBicileta.Length; i++){
            Aux += "-";
        }
        Console.WriteLine(@$"
| {Aux}
| {FrasedeMovimientoBicileta}
| {Aux}");
    }
}
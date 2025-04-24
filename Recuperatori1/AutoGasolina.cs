public class AutoGasolina: Vehiculo{
    private int NumeroLLantas = 4;
    public AutoGasolina(string nombre, string marca, string estado){
        setNombre(nombre);
        setTipodeCombustible("Gasolina");
        setMarca(marca);
        setEstado(estado);
        FrasedeMovimiento = "Conduciendo usando gasolina";
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
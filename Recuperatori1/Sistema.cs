using System.Data;

public class Sistema{
    public List<Vehiculo> Vehiculos;

    public Sistema(){
        Vehiculos = new List<Vehiculo>();
    }
    public void RegistrarVehiculos(){
        bool TieneEntrada = false;
        while(TieneEntrada == false){
            Console.Write(@"
-------------------------
|        REGISTRO       |
-------------------------
| 1. AUTOS              |
| 2. BICICLETAS         |
| 3. SCOOTER            |
| 4. OTROS              |
-------------------------
ENTRADA(Ejem: 2): ");
            string Entrada = Console.ReadLine();
            if(Entrada == "1"){
                Console.Clear();
                Console.Write("INTRODUZCA EL NOMBRE DEL AUTO: ");
                string nombre = Console.ReadLine();
                Console.Write("INTRODUZCA LA MARCA DEL AUTO: ");
                string marca = Console.ReadLine();
                Console.Write("INTRODUZCA EL ESTADO DEL AUTO: ");
                string estado = Console.ReadLine();
                TieneEntrada = true;
                AutoGasolina newAuto = new AutoGasolina(nombre, marca, estado);
                Vehiculos.Add(newAuto);
                
            }
            else if(Entrada == "2"){
                Console.Clear();
                Console.Write("INTRODUZCA EL NOMBRE DE LA BICICLETA: ");
                string nombre = Console.ReadLine();
                Console.Write("INTRODUZCA LA MARCA DE LA BICICLETA: ");
                string marca = Console.ReadLine();
                Console.Write("INTRODUZCA EL ESTADO DE LA BICICLETA: ");
                string estado = Console.ReadLine();
                TieneEntrada = true;
                Bicicleta newBicicleta = new Bicicleta(nombre, marca, estado);
                Vehiculos.Add(newBicicleta);
            }
            else if(Entrada == "3"){
                Console.Clear();
                Console.Write("INTRODUZCA EL NOMBRE DEL SCOOTER: ");
                string nombre = Console.ReadLine();
                Console.Write("INTRODUZCA LA MARCA DEL SCOOTER: ");
                string marca = Console.ReadLine();
                Console.Write("INTRODUZCA EL ESTADO DEL SCOOTER: ");
                string estado = Console.ReadLine();
                TieneEntrada = true;
                Scooter newScooter = new Scooter(nombre, marca, estado);
                Vehiculos.Add(newScooter);
            }
            else if(Entrada == "4"){
                Console.Clear();
                Console.Write("INTRODUZCA EL NOMBRE DEL VEHICULO: ");
                string nombre = Console.ReadLine();
                Console.Write("INTRODUZCA EL TIPO DE COMBUSTIBLE DEL VEHICULO: ");
                string tipodecombustible = Console.ReadLine();
                Console.Write("INTRODUZCA LA MARCA DEL VEHICULO: ");
                string marca = Console.ReadLine();
                Console.Write("INTRODUZCA EL ESTADO DEL VEHICULO: ");
                string estado = Console.ReadLine();
                Console.Write("INTRODUZCA EL MOVIMIENTO DEL VEHICULO: ");
                string movimiento = Console.ReadLine();
                TieneEntrada = true;
                Vehiculo newVehiculo = new Vehiculo(nombre, tipodecombustible, marca, estado, movimiento);
            }
            else{
                Console.WriteLine("ERROR: ENTRADA INVALIDA");
            }
            Console.Clear();
        }
    }
    public void MovientoDeVehiculos(){
        foreach(Vehiculo i in Vehiculos){
            Vehiculo Aux = i;
            Aux.Moverse();
            string aux = Console.ReadLine();
            Console.Clear();
        }
    }
    public void MostrarVehiculosRegistrados(){
        foreach(Vehiculo i in Vehiculos){
            string nombre = i.getNombre();
            string TipoDeCombustible = i.getTipodeCombustible();
            string Marca = i.getMarca();
            string Estado = i.getEstado();
            Console.WriteLine($@"
------------------------------------------------------------------------------------------
{nombre}   {TipoDeCombustible}    {Marca}    {Estado}
------------------------------------------------------------------------------------------");
        }
    }
    public void SistemaMenu(){
        bool TieneEntrada = false;
        while(TieneEntrada == false){
            Console.Write(@"
-----------------------------------------------
|        BIENVENIDO AL ESTACIONAMIENTO        |
-----------------------------------------------
| 1. MOSTRAR VEHICULOS                        |
| 2. MOVER VEHICULOS                          |
| 3. REGISTRAR VEHICULOS
| 3. SALIR                                    |
-----------------------------------------------
ENTRADA(Ejem: 1): ");
            string Entrada = Console.ReadLine();
            if(Entrada == "1"){
                Console.Clear();
                MostrarVehiculosRegistrados();
                TieneEntrada = true;
                SistemaMenu();
            }
            else if(Entrada == "2"){
                Console.Clear();
                MovientoDeVehiculos();
                TieneEntrada = true;
                SistemaMenu();
            }
            else if(Entrada == "3"){
                Console.Clear();
                RegistrarVehiculos();
                TieneEntrada = true;
                SistemaMenu();
            }
            else if(Entrada == "4"){
                TieneEntrada = true;
            }
            else{
                Console.WriteLine("ERROR: ENTRADA NO VALDIA");
            }
            Console.Clear();
        }
    }
}
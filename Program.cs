// See https://aka.ms/new-console-template for more information


EmpleadosInel Angie = new EmpleadosInel(2000, 50, 65, ComisionesFormat.ComisionBase, ComisionesFormat.ComisionAdicional);

EmpleadosInel Lucero = new EmpleadosInel (1300,50,55, ComisionesFormat.ComisionBase,ComisionesFormat.ComisionAdicional);

EmpleadosInel Barbara = new EmpleadosInel(1500, 50, 78, ComisionesFormat.ComisionBase, ComisionesFormat.ComisionAdicional);

Console.WriteLine($"El salario de mes Marzo Angie es:  {Angie.EvaluaSalario()}");
Console.WriteLine($"La comisión de Angie mes Marzo es:  {Angie.EvaluaComision()}");

Console.WriteLine($"Las comisiones varibles de Lucero son: {Lucero.EvaluaComision()}");

Console.WriteLine($"Las comisiones varibles de Lucero son:  { Barbara.EvaluaComision()}");




class EmpleadosInel
{

    private double SalarioBase;

    private double ComisionFija;

    private double ComisionAdicional;

    private int Meta = 50;

    private int TotalPart;


    public EmpleadosInel(double SalarioBase, int Meta, int TotalPart, ComisionesFormat ComisionFija, ComisionesFormat ComisionAdicional)
    {

        this.ComisionFija = (double)ComisionFija;

        this.SalarioBase = SalarioBase;

        this.ComisionAdicional = (double)ComisionAdicional;

        this.Meta = Meta;
        
        this.TotalPart = TotalPart;

    }

    public  double EvaluaSalario ()

    {

        if (Meta < 50) return SalarioBase;

        else
        {
            double TotalSalario;
            TotalSalario = SalarioBase + ComisionAdicional + ComisionFija;
            return TotalSalario;
        }      
    }

    public double EvaluaComision()
    {
        
        
            double ComisionVar;
            ComisionVar = TotalPart - Meta;

            double ComVar = (double) ComisionesFormat.ComisionVariable;

            double ComVariable;
            //SalarioBase = SalarioBase + ComisionAdicional + ComisionFija;
            ComVariable = ComisionVar * ComVar;

            
                    

       return ComVariable;

    }

    

   

}

enum ComisionesFormat { ComisionBase = 50, ComisionAdicional = 25, ComisionVariable=10 }





/*Bonus Antonio = Bonus.bueno;

double AntonioBonus = (double)Antonio;

Console.WriteLine(AntonioBonus);


Empleado Barbara = new Empleado(Bonus.extra, 1900.90);

Console.WriteLine(Barbara.GetSalario());*/




/*class Empleado
{

    public Empleado(Bonus BonusEmpleado, double SalarioBase) 
    { 
        _Bonus = (double)BonusEmpleado;  // esto es un casting y se hace para poder meter el valor del tipo Bonus de
                                        // dentro del campo de clase o variable _Bonus (_Bonus es de tipo double)
                                        // y BonusEmpleado es una variable de tipo Bonus, por eso hago el casting
                                        // para poder asignar el valor a las instancias de tipo Bonus

        this.SalarioBase=SalarioBase;

    }

    public double GetSalario() { return SalarioBase + _Bonus;}


    private double SalarioBase, _Bonus;
}

enum Bonus {bajo=500, normal=1000, bueno=1500, extra=2000}*/



/*Estaciones Alergias = Estaciones.Primavera;

Estaciones? Alergia = null; // sirve para guardar valores de tipo null

Console.WriteLine(Alergias);


enum Estaciones { Invierno, Otoño, Primavera, Verano}*/



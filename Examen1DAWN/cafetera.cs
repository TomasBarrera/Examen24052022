using System;
/// <remarks>descomente la linea del namespace y meti todo el codigo dentro del namespace</remarks>
namespace EDexamenT6a8
{
    class cafetera
    {
        /// <summary>
        /// "Encapsular campos"
        /// convierto las variables en propiedades cambiando su nombre por la primera letra mayuscula y asignando get y un set con condiciones
        /// tambien creo los campos privados para cada propiedad
        /// </summary>
        /// <remarks>Hecha la refactorizacion y correccion de errores a parte de las tabulaciones</remarks>
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = Marca;
            }
        }

        public string Referencia
        {
            get
            {
                return referencia;
            }
            set
            {
                referencia = Referencia;
            }
        }

        public double Agua
        {
            get
            {
                return agua;
            }
            set
            {
                if(value > 0)
                {
                    agua = value;
                }
            }
        }

        public double TotalDeDapsulas
        {
            get
            {
                return totalDeCapsulas;
            }
            set
            {
                if(value > 0)
                {
                    totalDeCapsulas = value;
                }
            }
        }

        private string marca;
        private string referencia;
        private double agua;
        private double totalDeCapsulas;
        /// <summary>
        /// cambio el antiguo nombre de las variables que eran solo una letra por una palabra mas descriptiva.
        /// </summary>
        /// <param name="m">antiguo nombre de la variable</param>
        /// <param name="r">antiguo nombre de la variable</param>
        public cafetera(string marca, string referencia, double agua, double totaldecapsulas)
        {
            this.Marca = marca; //marca de la maquina
            this.Referencia = referencia; //referencia del modelo
            this.TotalDeCapsulas = totaldecapsulas; //Total de cápsulas en la máquina. 
            this.Agua = agua; //Cantidad de agua en el recipiente. 
        }

        /// <summary>
        /// cambio el nombre del metodo (usando estilo PasCAL) y de la variable por referencia (usando estilo caMel)
        /// </summary>
        /// <param name="numeroDeCafe"></param>
        /// 
        /// <param name="ConsumoAgua"></param>
        ///<remarks>Cambio el nombre del metodo para que tenga mas sentido</remarks>
        public string ConsumoAgua(double numeroDeCafe) //numero de cafés a hacer
        {
            ///<summary>
            ///le cambio el nombre a la constante usando el estilo PasCal
            ///</summary>
            ///<param name="constante">antiguo nombre de la variable</param>

            const double Constante = 0.1;
            this.Agua = this.Agua - numeroDeCafe * Constante; // Constante de consumo de agua 0.1l por cada unidad de café.

            if (this.Agua < 0.1)
            {
                this.Agua = 0;
                return "Falta agua en el depósito, por favor, revisar los niveles.";
            }
            ///<summary>
            ///modifico el else para que los corchetes esten debajo igual que el if de arriba.
            /// </summary>
            else
            {
                return "Quedan" + this.Agua + " centilitros";
            }
        }
        /// <summary>
        /// cambio el nombre del metodo usando el estilo PasCal para que tenga sentido conforme al codigo
        /// tambien cambio el nombre de la variable numerodecafe
        /// </summary>
        /// <param name="consumocapsulas">antiguo nombre del metodo</param>
        /// <param name="numerodecafe">antiguo nombre de la variable</param>
        public string HacerCafes(double numeroDeCafe) //Hacer un café 
        {
            this.TotalDeCapsulas = this.TotalDeCapsulas - numeroDeCafe;

            if (this.TotalDeCapsulas < 0)
            {
                this.TotalDeCapsulas = 0;
                return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
            }
            else
            {
                return "Quedan" + this.TotalDeCapsulas + "unidades";
            }
        }
        /// <summary>
        /// cambio el nombre del metodo usando el estilo PasCal y el nombre de la variable de dentro usando estilo camel
        /// </summary>
        /// <param name="reponercapsulas">antiguo nombre del metodo</param>
        /// <param name="cantidadcapsulas">antiguo nombre del metodo</param>
        /// <remarks>Cambio el metodo por un void ya que no hace falta devolver nada solamente cambiar el valor de la propiedad, tambien elimino el return del metodo</remarks>
        public void ReponerCapsulas(double cantidadCapsulas)
        {
            this.TotalDeCapsulas = this.TotalDeCapsulas + cantidadCapsulas;
        }
        /// <summary>
        /// cambio el nombre del metodo usando el estilo PasCal y agrego "Deposito" para que sea mas entendible el metodo
        /// </summary>
        /// <param name="llenardep">antiguo nombre del metodo</param>
        /// <remarks>Cambio el metodo por un void ya que no hace falta devolver nada solamente cambiar el valor de la propiedad, tambien elimino el return del metodo</remarks>

        public void LlenarDeposito(double litros)
        {
            this.Agua = this.Agua + litros;
        }
        /// <summary>
        /// cambio el nombre del metodo usando el estilo PasCal
        /// cambio el nombre de las variables que se pasan por parametro para que sea mas entendible
        /// </summary>
        /// <param name="verespecificacion">antiguo nombre del metodo</param>
        /// <param name="r">elimino la variable</param>
        /// <param name="m">elimino la variable</param>
        /// <remarks>elimine las variables de parametro por refencia y cambie el codigo para que muestre las especificaciones</remarks>
        public void VerEspecificacion()
        {
            Console.WriteLine("Marca: " + Marca + "\n Referencia: " + Referencia);
        }

    }
    class ejemplodemicafetera
    {
        /// <summary>
        /// El main deberia estar ubicado arriba del todo
        /// </summary>
        static void main()
        {
            cafetera mi_cafetera_ejemplo = new cafetera("EspressoBarista", "Procoffee", 0.6, 7);

            Console.WriteLine(mi_cafetera_ejemplo.Agua);
            Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5));
            Console.WriteLine(mi_cafetera_ejemplo.totalDeCapsulas);
            Console.WriteLine(mi_cafetera_ejemplo.consumoagua(5));
            Console.WriteLine(mi_cafetera_ejemplo.Agua);
            mi_cafetera_ejemplo.LlenarDeposito(0.5);
            Console.WriteLine(mi_cafetera_ejemplo.Agua);
            mi_cafetera_ejemplo.ReponerCapsulas(3);
            Console.WriteLine(mi_cafetera_ejemplo.totalDeCapsulas);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conversiones.Models
{
    public class Convertir
    {
        private string UnidadIngresada { get; set; }
       private string UnidadEsperada { get; set; }
      private double Cantidad { get; set; }

        public string resultado(string unidadingresada,string unidadesperada, double cantidad)
        {
            this.UnidadIngresada = unidadingresada;
            this.UnidadEsperada = unidadesperada;
            this.Cantidad = cantidad;
            double resultado=0;
            string mensaje = "";

            switch (unidadingresada)
            {
                case "centimetro":
                    if (unidadesperada == "centimetro")
                    {
                        resultado = cantidad * 1;
                        mensaje=cantidad+" cm es igual a "+ resultado+" cm";
                    }
                    else if (unidadesperada == "metro")
                    {
                        resultado = cantidad / 100;
                        mensaje = cantidad + " cm es igual a " + resultado + " m";
                    }else if (unidadesperada == "kilometro")
                    {
                        resultado = cantidad /100000;
                        mensaje = cantidad + " cm es igual a " + resultado + " km";
                    }
                    else if (unidadesperada == "milla")
                    {
                        resultado = (cantidad / 160934);
                        mensaje = cantidad + " cm es igual a " + resultado + " mi";
                    }
                    break;
                case "metro":
                    if (unidadesperada == "centimetro")
                    {
                        resultado = cantidad * 100;
                        mensaje = cantidad + " m es igual a " + resultado + " cm";
                    }
                    else if (unidadesperada == "metro")
                    {
                        resultado = cantidad * 1;
                        mensaje = cantidad + " m es igual a " + resultado + " m";
                    }
                    else if (unidadesperada == "kilometro")
                    {
                        resultado = cantidad / 1000;
                        mensaje = cantidad + " m es igual a " + resultado + " km";
                    }
                    else if (unidadesperada == "milla")
                    {
                        resultado = cantidad * 0.000621371;
                        mensaje = cantidad + " m es igual a " + resultado + " mi";
                    }
                    break;
                case "kilometro":
                    if (unidadesperada == "centimetro")
                    {
                        resultado =cantidad*100000;
                        mensaje = cantidad + " km es igual a " + resultado + " cm";
                    }else if (unidadesperada == "metro")
                    {
                        resultado = cantidad*100;
                        mensaje = cantidad + " km es igual a " + resultado + " m";
                    }else if (unidadesperada == "kilometro")
                    {
                        resultado = cantidad * 1;
                        mensaje = cantidad + " km es igual a " + resultado + " km";
                    }else if (unidadesperada == "milla")
                    {
                        resultado = cantidad*0.621371;
                        mensaje = cantidad + " km es igual a " + resultado + " mi";
                    }
                    break;
                case "milla":
                    if (unidadesperada == "centimetro")
                    {
                        resultado = cantidad*160934;
                        mensaje = cantidad + " mi es igual a " + resultado + " cm";
                    }else if (unidadesperada == "metro")
                    {
                        resultado = cantidad*1609.34;
                        mensaje = cantidad + " mi es igual a " + resultado + " m";
                    }else if (unidadesperada == "kilometro")
                    {
                        resultado = cantidad*1.60934;
                        mensaje = cantidad + " mi es igual a " + resultado + " km";
                    }else if (unidadesperada == "milla")
                    {
                        resultado = cantidad * 1;
                        mensaje = cantidad + " mi es igual a " + resultado + " mi";
                    }
                    break;
            }
            return mensaje;
        }



    }
}
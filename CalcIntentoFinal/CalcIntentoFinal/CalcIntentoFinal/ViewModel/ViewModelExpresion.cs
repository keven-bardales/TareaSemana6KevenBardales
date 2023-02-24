using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CalcIntentoFinal.Models;
using Xamarin.Forms;

namespace CalcIntentoFinal.ViewModel
{
    public class ViewModelExpresion : INotifyPropertyChanged
    {
       
        double num1;
        string operacion;
        double resultado;
        double num2;
        public ViewModelExpresion()
        {
            CrearExpresion = new Command((parametro) =>
            {
                Expresion p1 = new Expresion()
                {
                    num1 = this.num1,
                    num2 = this.num2
                };

                if (parametro.ToString() == "suma")
                {
                    Resultado = p1.sumar();
                }
                else if (parametro.ToString() == "resta")
                {
                    Resultado = p1.restar();
                }else if(parametro.ToString() == "multiplicacion")
                {
                    Resultado = p1.multiplicar();
                }else if(parametro.ToString() == "division")
                {
                    Resultado = p1.dividir();
                }

                var arg = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, arg);

                Operacion = $"El resultado de la {parametro.ToString()} entre {num1} y {num2} es: {resultado}";
            });

        }

       
        string prueba;
        public string Prueba
        {

            get => prueba;
            set
            {

                prueba = value;
                var arg = new PropertyChangedEventArgs(nameof(Prueba));
                PropertyChanged?.Invoke(this, arg);

            }

        }




        public string Operacion
        {
            get => operacion; set
            {
                operacion = value;
                var arg = new PropertyChangedEventArgs(nameof(Operacion));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                var arg = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Num2
        {
            get => num2;
            set
            {
                num2 = value;
                var arg = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public double Num1
        {
            get => num1;
            set
            {
                num1 = value;
                var arg = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, arg);
            }
        }

        public Command CrearExpresion { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

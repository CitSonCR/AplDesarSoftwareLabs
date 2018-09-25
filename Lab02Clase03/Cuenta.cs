using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02Clase03
{
    public class Cuenta
    {
        public int numeroCuenta { get; set; }
        public decimal saldoCuenta { get; set; }

        public Cuenta(int numeroCuenta, decimal saldoCuenta)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldoCuenta = saldoCuenta;
        }

        public virtual decimal Vender(decimal monto)
        {
            saldoCuenta = saldoCuenta - monto;
            return saldoCuenta;
        }

        public virtual string GetData()
        {
            return "Cuenta: " + numeroCuenta + ", saldo: " + saldoCuenta;
        }
    }
}

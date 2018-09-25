namespace Lab02Clase03
{
    internal class Debito : Cuenta
    {
        public Debito(int numeroCuenta, decimal saldoCuenta) : base(numeroCuenta, saldoCuenta)
        {
           
        }

        public override decimal Vender(decimal monto)
        {
            if ((saldoCuenta - monto) < 0)
                return saldoCuenta - monto;            
            return base.Vender(monto);
        }

        public override string GetData()
        {
            return "Cuenta de debito: " + base.GetData();
        }


    }
}

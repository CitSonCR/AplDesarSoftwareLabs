namespace Lab02Clase03
{
    public class Credito : Cuenta
    {
        public Credito(int numeroCuenta, decimal saldoCuenta) : base(numeroCuenta, saldoCuenta)
        {

        }
        public override decimal Vender(decimal monto)
        {
            return base.Vender(monto);
        }

        public override string GetData()
        {
            return "Cuenta de credito: " + base.GetData();
        }
    }
}

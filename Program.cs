Coustumer firstCostumer = new Coustumer() { Name = "Mohmed", Balance = 150m };
PayStrategy payingProcess = new PayStrategy(firstCostumer);
payingProcess.Payby(new PayPalPay());
payingProcess.setPaying(20);
payingProcess.setPaying(500);
class Coustumer //must be singelton
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
}

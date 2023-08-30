class PayStrategy
{
    private Ipay PayMethod;
    private Coustumer _coustumer;
    public PayStrategy(Coustumer coustumer)
    {
        this._coustumer = coustumer;
    }
    public void Payby(Ipay _payMethod) 
    {
        this.PayMethod = _payMethod;
    }
    public void setPaying(decimal Amount) 
    {
        this.PayMethod.paymentData(this._coustumer);
        this.PayMethod.pay(Amount);
    }
}
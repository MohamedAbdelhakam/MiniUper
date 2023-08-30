class CreditCardPay : Ipay
{
    private decimal _amount { get; set; }
    private Coustumer coustumer;
    public void paymentData(Coustumer _coustumer) 
    {
        this.coustumer = _coustumer;
    }
    public bool pay(decimal Amount)
    {
        this._amount = Amount;

        bool checkSuccessOperation=PayChecing.PayAmount(coustumer.Balance, this._amount);

        if (checkSuccessOperation)
        {
            this.coustumer.Balance -= this._amount;
        }

        InvoicePayment.printInvoice(this.ToString(),this._amount,checkSuccessOperation);
        return checkSuccessOperation;
    }
}

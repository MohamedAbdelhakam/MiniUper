class InvoicePayment 
{
    public static void printInvoice(string paymentMethod, decimal Amount,bool checkSuccessOperation) 
    {
        if (checkSuccessOperation == true)
        {
            Console.WriteLine ($"payed {Amount} succesfully using {paymentMethod}");
        }
        else
        {
            Console.WriteLine($"Your balance is not enough to pay {Amount}");
        }
    }
}
class PayChecing
{
    public static bool PayAmount(decimal Balance, decimal Amount)
    {
        if (Amount <= Balance)
        {
            Balance -= Amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}

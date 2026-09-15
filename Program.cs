decimal solde = 1000m;
decimal montant = -1150m;

if (montant > 0)
{solde += montant;
}
else if (montant <0)
{
    
    decimal debit = -montant;
    
    if(debit <= solde)
    {
        solde -= debit;
    }
    else
    {
        Console.WriteLine("Solde insuffisant pour effectuer le retrait.");
    }
}
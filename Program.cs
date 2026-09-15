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
Console.WriteLine($"Solde final : {solde}");

static decimal debiter(decimal solde, decimal montant)
{
    if (montant <= 0)
    {
        Console.WriteLine("Erreur : le montant du débit doit être strictement positif.");
        return solde;
    }

    if (montant > solde)
    {
        Console.WriteLine("Solde insuffisant pour effectuer le retrait.");
        return solde;
    }

    return solde - montant;
}
public class Compte
{
    public decimal Solde { get; private set; }
    public string NumeroCompte { get; private set; }
    public string NomTitulaire { get; private set; }

    public Compte(string numeroCompte, string nomTitulaire)
    {
        NumeroCompte = numeroCompte;
        NomTitulaire = nomTitulaire;
        Solde = 0m;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du crédit doit être positif.");
            return;
        }

        Solde += montant;
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant du débit doit être positif.");
            return;
        }

        if (montant > Solde)
        {
            Console.WriteLine("Solde insuffisant.");
            return;
        }

        Solde -= montant;
    }
}
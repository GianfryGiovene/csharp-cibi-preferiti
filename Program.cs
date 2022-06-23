// See https://aka.ms/new-console-template for more information
/*
Create un progetto App Console CibiPreferiti con VS2022.
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
 La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
 Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push
BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. 
Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 
elementi in centro alla vostra classifica.  Buon pomeriggio e buon lavoro!
*/

string[] cibiPreferiti = { "Carbonara", "Cotoletta", "Pizza", "Arrosto", "Pasta al forno" };

//La lunghezza della classifica
Console.WriteLine("Lunghezza lista cibi preferiti:\n" + cibiPreferiti.Length);

// La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Console.WriteLine("Lista cibi preferiti");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine((i + 1) + "° " + cibiPreferiti[i]);
}

//Il vostro cibo top (prima posizione della classifica)

Console.WriteLine("Primo cibo Preferito \n" + cibiPreferiti[0]);

//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

Console.WriteLine("Ultimo cibo Preferito \n" + cibiPreferiti[cibiPreferiti.Length - 1]);

/*
BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. 
Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 
elementi in centro alla vostra classifica.
*/

float diviso = cibiPreferiti.Length / 2;
if (cibiPreferiti.Length % 2 != 0)
{
    Console.WriteLine("cibo di mezzo se lunghezza dispari " + cibiPreferiti[(int)Math.Ceiling(diviso)]);
}
else
{
    Console.WriteLine("primo cibo di mezzo se lunghezza pari " + cibiPreferiti[(cibiPreferiti.Length / 2) - 1]);
    Console.WriteLine("secondo cibo di mezzo se lunghezza pari " + cibiPreferiti[cibiPreferiti.Length / 2]);

}

/*
 chiedere all'utente qual'è il suo cibo preferito,
generare un numero random da 0 a lunghezza dell'array cibi preferiti,
per simulare che anche il pc scelga un cibo preferito. Quando stampo la lista cibi preferiti bisogna, 
nella riga in cui esce il cibo preferito (questo è il tuo cibo preferito quando è dell'utente) mentre (questo è il mio cibo preferito quando è del pc,
quando utente e pc hanno lo stesso cibo preferito compare la scritta "abbiamo gli stessi gusti"
se l'utente nn inserisce un cibo preferito contenuto nell'array richiederlo fino a che nn è contenuto
 */
Random rnd = new Random();

Console.WriteLine("Inserire Il cibo preferigvto");
int numeroRandom = rnd.Next(1, cibiPreferiti.Length);
string ciboUtente = Console.ReadLine();


for (int i = 0; i < cibiPreferiti.Length; i++)
{
    if (ciboUtente == cibiPreferiti[i] && cibiPreferiti[numeroRandom] == cibiPreferiti[i])
    {
        Console.WriteLine((i + 1) + "° " + cibiPreferiti[i] + " ---> Avete gli stessi gusti");
    }
    else if(ciboUtente == cibiPreferiti[i])
    {
        Console.WriteLine((i + 1) + "° " + cibiPreferiti[i] + " ---> Questo è il tuo cibo preferito");

    }else if (cibiPreferiti[i] == cibiPreferiti[numeroRandom]){

        Console.WriteLine((i + 1) + "° " + cibiPreferiti[i] + " ---> Questo è il cibo preferito del pc");
    }
    else
    {
        Console.WriteLine((i + 1) + "° " + cibiPreferiti[i]);
    }
}



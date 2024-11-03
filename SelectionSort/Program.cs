namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Förklaring av koden
            // Vi har en array numbers som innehåller värden som vi vill sortera:

            int[] numbers = { 6, 2, 8, 4, 10, 3 };

            // Yttre loop - Huvudloopen för att gå igenom varje element i listan:
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Här börjar vi från första elementet och går framåt tills vi når näst
                // sista elementet.
                // Vi stoppar vid numbers.Length - 1 eftersom sista elementet automatiskt
                // kommer vara sorterat när de andra är det.
                // i är vår "startposition" i listan där vi vill placera det minsta elementet.
                // Variabeln minIndex - För att hålla reda på den minsta positionen:
                int minIndex = i;

                // Här antar vi att det nuvarande elementet(i) är det minsta i den osorterade
                // delen av listan.Om vi hittar ett mindre värde senare, kommer vi att uppdatera
                // denna variabel.
                // Inre loop - Söka efter det minsta elementet i resten av listan:
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Här söker vi genom resten av listan, från i + 1 till slutet av listan.
                    // j är vår andra räknare, som letar efter ett mindre värde än det som finns
                    // på position minIndex.
                    // Kontroll av mindre värde:

                    // Ascending
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                    // Övning 3 - Descending
                    // if (numbers[j] > numbers[minIndex])
                    //      minIndex = j;
                }
                // Om elementet på position j är mindre än elementet på position minIndex,
                // uppdaterar vi minIndex till j.
                // Detta betyder att vi har hittat ett nytt, lägre värde, och minIndex kommer
                // nu att peka på det lägsta elementet vi hittat så här långt.
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
                // När vi har gått igenom hela listan och hittat det minsta värdet(på position minIndex),
                // byter vi plats mellan det minsta värdet och värdet på position i.
                // Här används en tillfällig variabel temp för att lagra värdet på numbers[minIndex],
                // så att vi inte förlorar det när vi gör bytet.
            }
            Console.ReadLine();
        }
    }
}

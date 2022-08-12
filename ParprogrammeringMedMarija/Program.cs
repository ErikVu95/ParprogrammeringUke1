namespace ParprogrammeringMedMarija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int søknadspoeng = 0;

            Console.WriteLine("Velkommen til Erik og Marija sitt lille parprogrammeringsprosjekt. Her søker du til GET.");
            Console.WriteLine("\n" + "Hva heter du?");
            string name = Console.ReadLine();

            Console.WriteLine("\n" + "Hvor gammel er du?");
            string age = Console.ReadLine();

            Console.WriteLine("\n" + "Sist men ikke minst, hvor bor du? (Skriv kun byen du bor i)");
            string location = Console.ReadLine();

            if (location.Length != 0)
            {
                var firstLetter = char.ToUpper(location[0]);
                var wordLength = location.Length;
                var secondLetter = location.Substring(1, wordLength - 1);

                location = firstLetter + secondLetter;
            }

            if (location == "Larvik")
            {
                Console.Beep();
                Console.WriteLine("Da bor du nærme GET.");
                søknadspoeng += 4;
            }
            else if (location == "Sandefjord")
            {
                Console.WriteLine("Da bor du nærme Therese. Kom med en vits.");
                string sandefjordVits = Console.ReadLine();
                Console.WriteLine("Vitsen var ikke morsom. Vi går videre.");
                søknadspoeng += 3;
            }
            else
            {
                Console.WriteLine("Da bor du langt vekk fra GET.");
                søknadspoeng += 1;
            }


            Console.WriteLine("\n" + "Viktig spørsmål. Vet du hva primtall er? Svar ja eller nei.");
            string jaEllerNei = Console.ReadLine();
            if (jaEllerNei == "Ja" || jaEllerNei == "ja")
            {
                Console.WriteLine("Da stoler vi på at du sier sannheten. Det er plusspoeng! (Terje vil gjerne ta en prat med deg).");
                søknadspoeng += 5;
            }
            else
            {
                Console.WriteLine("Ingen problem. Du får gratis time med Terje");
                søknadspoeng += 2;
            }

            Console.WriteLine("\n" + "Fortell oss hvor mye erfaring du har med koding med et tall fra 1-10, hvor 1 er ingen kunnskaper og 10 er masse kunnskaper.");
            string rating = Console.ReadLine();
            int ratingInNumber = Convert.ToInt32(rating);


            if (ratingInNumber <= 3)
            {
                Console.WriteLine("Heldigvis trenger du ikke å ha erfaring fra før :)");
                søknadspoeng += 1;
            }
            if (ratingInNumber >= 4 && ratingInNumber <= 6)
            {
                Console.WriteLine("Du har middels med kunnskap. Det kommer godt med.");
                søknadspoeng += 2;
            }
            if (ratingInNumber >= 7)
            {
                Console.WriteLine("Så bra, da er du godt forberedt.");
                søknadspoeng += 3;
            }

            Console.WriteLine("\n" + "Har du gjort din research? Hvor lang tid tar det å bli en IT-Utvikler hos GET?");
            Console.WriteLine("1 år, 1.5 år eller 2 år?");
            string lengdeSvar = Console.ReadLine();

            if (lengdeSvar is "1 år" or "1" or "et år")
            {
                Console.WriteLine("Dessverre feil svar, det er for kort. Riktig svar er 1.5 år.");
                søknadspoeng += 1;
            }
            else if (lengdeSvar is "1.5 år" or "1.5" or "et og halvt år")
            {
                Console.WriteLine("Det er helt riktig! Godt svart.");
                søknadspoeng += 3;
            }
            else if (lengdeSvar is "2 år" or "2" or "to år")
            {
                Console.WriteLine("Dessverre feil svar, det er for langt. Riktig svar er 1.5 år.");
                søknadspoeng += 1;
            }
            else
            {
                Console.WriteLine("FEIL");
                søknadspoeng -= 1;
            }

            Console.Clear();
            Console.WriteLine($"Du oppnådde en hemmelig søknadspoengsum på {søknadspoeng} poeng!");

            Console.WriteLine("\n" + $"Takk for søknaden, {name}. Du er {age} år gammel og bor i {location}." + "\n" +
                              $"Du svarte {jaEllerNei} til spørsmålet om du kunne primtall, og du" + "\n" + 
                              $"vurderte deg selv som en {rating} av 10 erfaringsmessig." + "\n" +
                              "Da vi spurte om du hadde gjort din research angående hvor mange år studiet tar," + "\n" + $"så svarte du {lengdeSvar}. " +
                              "Vi ser fram til å gå gjennom søknaden din.");
        }
    }
}
using System;
using System.Threading;

namespace slutprojekt
{
    static class Globals{
        static public int loop;
        static public int scen;
    }
    class Program
    {
        static void GameLoop(){//start av spelet
                    Globals.scen = 0;
                    Console.Clear();
                    System.Console.WriteLine("Du vaknar och kollar på klockan");
                    System.Console.WriteLine("Hon är bara 6:23");
                    Thread.Sleep(3000);
                    Console.Clear();

                    if (Globals.loop == 1){
                        System.Console.WriteLine("Trevligt att ses igen!");
                        System.Console.WriteLine("Verkar som att det inte gick så bra där :/");
                        System.Console.WriteLine("Bara att försöka igen");
                        System.Console.WriteLine("Du kommer nog hamna här ett antal gånger tyvärr");
                        System.Console.WriteLine("Du är nu på loop " + Globals.loop);
                    }

                    else if (Globals.loop > 1){
                        System.Console.WriteLine("Bara att fortsätta försöka");
                        System.Console.WriteLine("Du är nu på loop " + Globals.loop);

                    }

                    System.Console.WriteLine("Innan vi börjar hade det varit trevligt om jag kunde få ditt samtycke till att spela spelet.");
                    System.Console.WriteLine("Ingen speciell anledning till varför :)");
                    System.Console.WriteLine("Du får därför gärna svara med antingen ett \"start\" eller ett \"stopp\"");
                    System.Console.WriteLine("En varning innan, var försiktig med att inte komma åt enter tangenten när du inte ska svara på något, saker kommer gå fel");
                    string svar = Console.ReadLine();
                    svar.ToLower();

                    if (svar == "start"){
                        System.Console.WriteLine("Perfekt, då kan vi börja!");
                        System.Console.WriteLine("Glöm inte bort att försöka ha kul!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Globals.scen++;
                    }

                    else if (svar == "stopp"){
                        Console.Clear();
                        System.Console.WriteLine("Om du inte vill så behöver du inte.");
                        System.Console.WriteLine("Hejsvejs :)");
                        Globals.scen = 999;
                    }

                    else{
                        Console.Clear();
                        System.Console.WriteLine("Igen, ett \"start\" eller ett \"stopp\"");
                        Thread.Sleep(3000);
                    }
        }
        static void Main(string[] args){
                    Globals.scen = 0;
                    Globals.loop = 0;
                    GameLoop();
                    while(Globals.scen == 1){
                        if (Globals.loop == 9){
                            break;
                        }
                        string val = "null";
                        string val2 = "null";
                        string val3 = "null";
                        System.Console.WriteLine("Du kollar på klockan");
                        System.Console.WriteLine("Hon är bara 6:32");
                        System.Console.WriteLine("Skolan börjar inte förrän om X");
                        System.Console.WriteLine("Vill du \"gå upp\" redan nu eller vill du \"ligga kvar\" en stund?");
                        val = Console.ReadLine();
                        val.ToLower();

                        if (val == "gå upp"){
                            System.Console.WriteLine("Du bestämmer dig för att gå ner och göra frukost");
                        }

                        else if (val == "ligga kvar"){
                            System.Console.WriteLine("Du bestämmer dig för att ligga kvar en stund");
                            System.Console.WriteLine("Din syster springer in i rummet med ett baseboll trä och går berserk på ditt huvud");
                            Thread.Sleep(3000);
                            Console.Clear();
                            Globals.loop++;
                            GameLoop();
                            continue;
                        }                       

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            GameLoop();
                            continue;
                        } 
                        System.Console.WriteLine("När du kommer ner och kollar på köksklockan märker du att hon inte är 6:32 utan 9:23");
                        System.Console.WriteLine("Skolan börjar egentligen om y");
                        System.Console.WriteLine("Finns ingen chans att du hinner i tid om du gör frukost");
                        System.Console.WriteLine("Vill du göra \"frukost\" och komma försent eller \"skynda\" till skolan och kanske hinna i tid?");
                        val2 = Console.ReadLine();
                        val2.ToLower();

                        if (val2 == "frukost"){
                            System.Console.WriteLine("Du bestämmer dig för att hungern är viktigast just nu och gör en lätt frukost på endast en äggmacka");
                        }

                        else if (val2 == "skynda"){
                            System.Console.WriteLine("Du struntar i frukosten och börjar springa till dörren.");
                            System.Console.WriteLine("DU halkar och slår huvudet i kanten på ett bord som inte brukar stå där");
                            Thread.Sleep(5000);
                            Console.Clear();
                            Globals.loop++;
                            GameLoop();
                            continue;
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }

                        System.Console.WriteLine("Efter att du lite skyndat stoppar i dig frukosten går du till hallen och ropar hejdå");
                        Thread.Sleep(2750);
                        System.Console.WriteLine("Konstigt, inget svar tänker du");
                        if (Globals.loop > 0){
                            System.Console.WriteLine("Känns i alla fall som att din syster borde vara hemma med tanke på det som kanske hände?");
                        }

                        System.Console.WriteLine("Du kollar termperaturen ute, 23C");
                        System.Console.WriteLine("Ska du ta på dig något \"lättare\" eller lite \"varmare\"?");
                        val3 = Console.ReadLine();
                        val3.ToLower();

                        if (val3 == "lättare"){
                            System.Console.WriteLine("Du struntar i jacka och går ut med en t-shirt och jeans");
                            Thread.Sleep(3000);
                            Console.Clear();
                            Globals.scen = 2;
                        }

                        else if (val3 == "varmare"){
                            System.Console.WriteLine("Det var egentligen 32 grader ute");
                            System.Console.WriteLine("Du överhettar på bussen");
                            Thread.Sleep(5000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }
                    }

                    while (Globals.scen == 2){ //"del 2" av spelet
                        string val4 = "null";
                        string val5 = "null";
                        Console.Clear();
                        System.Console.WriteLine("Del 2: På g till skolan");
                        System.Console.WriteLine("På bussen finns alternativet till att \"stå\" eller \"sitta\"");
                        val4 = Console.ReadLine();
                        val4.ToLower();

                        if (val4 == "stå"){
                            System.Console.WriteLine("En unge springer ut på gatan");
                            System.Console.WriteLine("Chauffören väjer av en klippa");
                            Thread.Sleep(5000);
                            Console.Clear();
                            Globals.loop++;
                            GameLoop();
                            continue;
                        }

                        else if (val4 == "sitta"){
                            System.Console.WriteLine("Efter ett par stationer märker du en äldre dam går på bussen");
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }

                        System.Console.WriteLine("Ingen av de andra resenärerna ger henne deras säte");
                        System.Console.WriteLine("Vill du \"ge upp\" ditt säte eller sitta kvar och \"fortsätta?\"");
                        val5 = Console.ReadLine();
                        val5.ToLower();

                        if (val5 == "ge upp"){
                            Globals.scen = 999;
                            continue;
                        }

                        else if (val5 == "fortsätta"){
                            System.Console.WriteLine("Du sitter kvar i hopp om att någon annan \"ger upp\" sitt säte");
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }

                        System.Console.WriteLine("En av dina klasskamrater som hade på sig en t-shirt och jeans var tydligen på samma buss men det såg du inte");
                        System.Console.WriteLine("De väljer att ge den äldre damen sitt säte");
                        System.Console.WriteLine("De försvinner kort efter, men ingen annan verkar lägga märke till det");
                        System.Console.WriteLine("Tyst hör du någon säga \"Nu är det bara att stänga av\"");
                        System.Console.WriteLine("Men kan inte lista ut vem som sa det");
                        System.Console.WriteLine("Tryck enter när du läst klart");
                        Console.ReadLine();
                        Thread.Sleep(3000);
                        Console.Clear();
                        Globals.scen = 3;
                    }

                    while (Globals.scen == 3){ //"Del 3" av spelet
                        string val6 = "null";
                        string val7 = "null";
                        string val8 = "null";
                        System.Console.WriteLine("Del 3: I skolan");
                        System.Console.WriteLine("Du hinner på något sätt till skolan med z till godo");
                        System.Console.WriteLine("Osäkert om du hinner till klassrummet i tid");
                        System.Console.WriteLine("Vill du \"skynda\" och komma andfådd till klassrummet men kanske i tid eller ta det \"lugnt\" och kanske komma någon minut sent");
                        val6 = Console.ReadLine();
                        val6.ToLower();

                        if (val6 == "skynda"){
                            System.Console.WriteLine("Du springer upp till ditt klassrum precis i tid till uppropet");
                        }

                        else if (val6 == "lugnt"){
                            System.Console.WriteLine("Du går lugnt upp tillklassrummet men blir nedknuffad på vägen upp av en elev i t-shirt och jeans");
                            System.Console.WriteLine("Du ramlar på huvudet");
                            Thread.Sleep(5000);
                            Console.Clear();
                            Globals.loop++;
                            GameLoop();
                            continue;
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }
                        System.Console.WriteLine("Till din förvåning börjar läraren dela ut prov");
                        System.Console.WriteLine("Du har inte riktigt pluggat men känner att du lyssnat under lektionerna");
                        System.Console.WriteLine("Du kommer till en svår fråga som lyder");
                        System.Console.WriteLine("Vill du \"ge upp\" eller \"fortsätta\" med provet?");
                        val7 = Console.ReadLine();
                        val7.ToLower();

                        if (val7 == "ge upp"){
                            Globals.scen = 999;
                            continue;
                        }

                        else if (val7 == "fortsätta"){
                            System.Console.WriteLine("Trotts att du är osäker fortsätter du med provet");
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                            GameLoop();
                            continue;
                        }

                        System.Console.WriteLine("Efter 15 minuter ställer sig halva klassen upp samtidigt");
                        System.Console.WriteLine("Med tanke på att provet är 20 frågor har de förmodligen \"gett upp\"");
                        System.Console.WriteLine("Du hör någon säga \"Nu är det bara att stänga av\" igen");
                        System.Console.WriteLine("Men den här gången hör du det flera gånger");
                        System.Console.WriteLine("De elever som valde att ge upp försvinner ");
                        System.Console.WriteLine("Samma som på bussen, ingen märker det");
                        System.Console.WriteLine("Du känner att du behöver gå på toa");
                        System.Console.WriteLine("Läraren sover ståendes");
                        System.Console.WriteLine("Vill du \"väcka\" läraren och säga till eller bara \"gå\"?");
                        val8 = Console.ReadLine();
                        val8.ToLower();

                        if (val8 == "väcka"){
                            System.Console.WriteLine("Du väcker läraren och frågar om du får gå på toa");
                            System.Console.WriteLine("De svarar \"Nej du har en fråga kvar, gör den först\"");
                            Thread.Sleep(4000);
                            Console.Clear();
                            Globals.scen = 4;
                        }

                        else if (val8 == "gå"){
                            System.Console.WriteLine("Du säger inte till läraren");
                            System.Console.WriteLine("Dörren går i baklås när du tvättar händerna");
                            System.Console.WriteLine("Kranen går inte att stänga av");
                            System.Console.WriteLine("Du drunknar");
                            Thread.Sleep(5000);
                            Globals.loop++;
                            GameLoop();
                            continue;
                        }

                        else{
                            Console.Clear();
                            System.Console.WriteLine("Du ska lyssna på mig");
                            Thread.Sleep(3000);
                            Console.Clear();
                           GameLoop();
                           continue;
                        }
                    }

                    while (Globals.scen == 4){ //"del 4" av spelet
                        string nio = "null";
                        Console.Clear();
                        System.Console.WriteLine("Sista frågan är");
                        System.Console.WriteLine("\"Vet du vad som händer?\"");
                        System.Console.WriteLine("\"ja\" eller \"nej\"");
                        nio = Console.ReadLine();
                        nio.ToLower();

                        if (nio == "ja"){
                            Globals.loop = 9;
                            GameLoop();
                        }

                        else if(nio == "nej"){
                            System.Console.WriteLine("haha");
                            Globals.scen = 5;
                        }

                        else{
                            System.Console.WriteLine("Simpel fråga, \"ja\" eller \"nej\"");
                            Thread.Sleep(3000);
                        }
                    }

                    while (Globals.scen == 5){ //du vann :)
                        Console.Clear();
                        System.Console.WriteLine("Grattis du vann");
                        Thread.Sleep(5000);
                        System.Console.WriteLine("Hejdå");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }

                    while (Globals.scen == 999){
                        Thread.Sleep(3000);
                        Console.Clear();
                        System.Console.WriteLine("Nu är det bara att stänga av");
                        Thread.Sleep(4000);
                        Console.Clear();
                        System.Console.WriteLine("Varför sitter du kvar?");
                        Thread.Sleep(3000);
                        Console.Clear();
                        System.Console.WriteLine("Du \"gav upp\" så spelet är över.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        System.Console.WriteLine("Det finns inget här, hejdå :)");
                        Thread.Sleep(1000);
                        Console.Clear();
                        System.Console.WriteLine("Är du så inkapabel stänger jag av spelet åt dej");
                        System.Console.WriteLine("Hejdå >:(");
                        Thread.Sleep(850);
                        Environment.Exit(0);
                    }

                    while (Globals.loop == 9){
                        Console.Write("9");
                    }
                    Console.ReadLine();
                }
             }
        }
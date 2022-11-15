namespace Infotafel_Zoo {
    // Erstellen Sie ein Menü( gerne auch als statische Methode,
    // dies ist aber kein muss) mit dem der Anwender das Tier
    // wählen kann.

    // Nach der Wahl des Tieres, soll der Anwender nun entscheiden,
    // ob er eine Beschreibung oder eine Wegbeschreibung wünscht.

    // Je nach Auswahl soll nun eine entsprechende Ausgabe erscheinen:
    // Beschreibung oder Wegbeschreibung.

    internal class Menu {
        public static void MainMenu() {
            string eingabe1, eingabe2;

            Console.WriteLine( "Willkommen zum Zoo 'Anderswo'" );
            Console.WriteLine( "Über welches Tier dürfen wir sie Informieren?" );
            Console.WriteLine( "( Affe, Maulwurf, Vogel, Nielpferd, Leopard )" );
            eingabe1 = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine( "Möchten Sie eine [1] Beschreibung oder eine [2] Wegbeschreibung haben?" );
            eingabe2 = Console.ReadLine();

            switch(eingabe1, eingabe2) {
                case ("affe", "1" ):
                Tiere.affe.TierBeschreibung();
                break;
                case ("affe", "2" ):
                Tiere.affe.Wegbeschreibung();
                break;
                case ("maulwurf", "1" ):
                Tiere.maulwurf.TierBeschreibung();
                break;
                case ("maulwurf", "2" ):
                Tiere.maulwurf.Wegbeschreibung();
                break;
                case ("vogel", "1" ):
                Tiere.vogel.TierBeschreibung();
                break;
                case ("vogel", "2" ):
                Tiere.vogel.Wegbeschreibung();
                break;
                case ("nielpferd", "1" ):
                Tiere.nielpferd.TierBeschreibung();
                break;
                case ("nielpferd", "2" ):
                Tiere.nielpferd.Wegbeschreibung();
                break;
                case ("leopard", "1" ):
                Tiere.leopard.TierBeschreibung();
                break;
                case ("leopard", "2" ):
                Tiere.leopard.Wegbeschreibung();
                break;
                default:
                Console.WriteLine( "Sorry, aber solch ein Tier haben wir hier nicht" );
                break;
            }
        }
    }
}

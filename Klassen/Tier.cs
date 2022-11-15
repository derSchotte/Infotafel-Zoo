namespace Infotafel_Zoo.Klassen {
    // Entwickeln Sie die Klasse "Tier" mit allen ihrer Meinung
    // nach benötigten Feldern und einem vollständigen Konstruktor.

    internal class Tier {
        // Namen
        // Rasse
        // Farbe
        // Größe
        // Lieblingsfutter
        // Herkunft
        // Geschlecht
        // alter
        // Geburtsdatum
        // Gehege
        // Gesund

        // Fields
        public string name;
        public string rasse;
        public string farbe;
        public float groesse;
        public string lieblingsfutter;
        public string herkunft;
        public string geschlecht;
        public string gesund;
        public int alter;
        public DateOnly geburtsdatum;
        public int gehege;
        public string beschreibung;
        public string wegbeschreibung;

        // Constructor
        public Tier( string name, string rasse, string farbe, float groesse, string lieblingsfutter, string herkunft, string geschlecht, string gesund, int alter, DateOnly geburtsdatum, int gehege, string beschreibung, string wegbeschreibung ) {
            this.name = name;
            this.rasse = rasse;
            this.farbe = farbe;
            this.groesse = groesse;
            this.lieblingsfutter = lieblingsfutter;
            this.herkunft = herkunft;
            this.geschlecht = geschlecht;
            this.gesund = gesund;
            this.alter = alter;
            this.geburtsdatum = geburtsdatum;
            this.gehege = gehege;
            this.beschreibung = beschreibung;
            this.wegbeschreibung = wegbeschreibung;
        }

        // Methods
        public void TierBeschreibung() {
            Console.WriteLine( $"Name: {name}" );
            Console.WriteLine( $"Rasse: {rasse}" );
            Console.WriteLine( $"Herkunft: {herkunft}\n" );
            Console.WriteLine( $"Lieblingsfutter: {lieblingsfutter}" );
            Console.WriteLine( $"Farbe: {farbe}\n" );
            Console.WriteLine( $"Beschreibung:\n" );
            Console.WriteLine( beschreibung );
        }

        public void Wegbeschreibung() {
            Console.WriteLine( wegbeschreibung );
        }
    }
}

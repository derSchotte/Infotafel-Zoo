using Infotafel_Zoo.Klassen;
// Erstellen Sie 5 verschiedene Tiere mit allen Feldern.

namespace Infotafel_Zoo {
    internal class Tiere {
        public static Tier affe = new Tier( "Bobo","Affe","Schwarz",1.23f, "Bananen","Afrika", "Weiblich",
                    "Ja", 14, new (2008, 04, 01), 1,
                    "per mare, per terras, Diese Gattung des Primatus Longus, hält sich gerne in den Bäumen auf um von dort aus Die Touries besser zu sehen.",
                    "Geradeaus, Links am Nielpferd vorbei, gegenüber des Leoparden");

        public static Tier maulwurf = new Tier("Georg", "Maulwurf", "Grau", 0.30f, "Regenwürmer", "Ausm Boden", "Männlich",
                        "Ja", 3, new(2019, 01, 01), 2,
                        "Der Maulwurf ist eigentlich ein friedlicher Zeitgenosse, Aber Georg, naja .. sagen wir es so.. man sollte schon aufpassen wo man steht. Er bohrt gerne Löcher in die Schuhe.",
                        "Vorne am Eingang, im Blumenbeet");

        public static Tier vogel = new Tier("Steffie", "Papagei", "Rotweiss", 0.45f, "Sonnenblumenkerne", "Aufm Baum", "Weiblich",
                      "ja", 12, new (2011, 04, 01), 3,
                      "Ist ein stillschweigender Einzelgänger, zur Parungszeit hört man ihn leise gurgeln. Was seine Paarungsbereitschaft signalisiert.",
                      "Am Leopardengehe, rechts vorbei zu dem großen Baum, dort irgendwo in den Ästen.");

        public static Tier nielpferd = new Tier("Gustavo", "Nielpferd", "Grau", 1.50f, "Grässer", "Niel", "Männlich",
                        "Nein", 54, new DateOnly(1972, 06, 23),4,
                        "Nielpferde sind die möchtegern Panzerknacker dieser Welt, kein Touri ist vor ihnen Sicher. Sollten Sie eines sehen und es zwinkert sie an. LAUFEN SIE...",
                        "Sehen sie die große Wasserpfütze auf unserem Plan, dort ist das Nielpferd zuhause");

        public static Tier leopard = new Tier("Gordo", "Leopard", "Braun mit schwarzen Kreisen",1.20f,"Fleisch", "Savane", "Weiblich",
                       "Ja", 24, new (1998, 12, 12),5,
                   "Pirscht sich meistens an seine Ofper herran. Eine tolle Eigenschaft des Leoparden ist die Tarnung. Wenn er sich als Bettvorleger getarnt hat, ist er nur Schwer auszumachen.",
                  "Schau mal hinter dich");
    }
}

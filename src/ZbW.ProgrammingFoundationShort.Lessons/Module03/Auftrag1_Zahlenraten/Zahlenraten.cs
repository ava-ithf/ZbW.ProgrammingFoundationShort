namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    Random rng = new();

    int gluecksZahl = rng.Next(1, 101);
    int rateZahl = 0;
    int versuche = 0;

    while (gluecksZahl != rateZahl)
    {
      Console.WriteLine("Errate die Zahl zwischen 1 und 100:");
      rateZahl = int.Parse(Console.ReadLine());
      if (rateZahl < gluecksZahl)
      {
        Console.WriteLine("Die Zahl ist gösser.");
      }
      else if (rateZahl > gluecksZahl)
      {
        Console.WriteLine("Die Zahl ist kleiner.");
      }
      versuche++;
      // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
      //         var random = new Random();
      //         int geheimzahl = random.Next(1, 101);

      // TODO 2: Variablen für Versuchszähler und geraten-Flag

      // TODO 3: while-Schleife (!geraten)
      //         - Eingabe lesen
      //         - int.TryParse prüfen
      //         - Hinweis ausgeben (zu klein / zu gross / richtig)
      //         - Versuchszähler erhöhen

      // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben
    }
    Console.WriteLine($"Glueckwunsch du hast die richtige Zahl gefunden! Die Zahl war {gluecksZahl}. Du hast {versuche} gebraucht.");
  }
}

namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Startet den Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    double ersteZahl = 0;
    double zweiteZahl = 0;
    double resultat = 0;
    string operation = "";

    // TODO 1: Erste Zahl einlesen und prüfen
    //         Console.Write("Erste Zahl: ");
    //         if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
    //         {
    //           Console.WriteLine("Ungültige Zahl.");
    //           return;
    //         }

    Console.Write("Erste Zahl: ");
    string eingabeErsteZahl = Console.ReadLine() ?? "";
    ersteZahl = double.Parse(eingabeErsteZahl);

    // TODO 2: Zweite Zahl einlesen (gleiche Technik wie TODO 1)

    Console.Write("Zweite Zahl: ");
    string eingabeZweiteZahl = Console.ReadLine() ?? "";
    zweiteZahl = double.Parse(eingabeZweiteZahl);

    // TODO 3: Operation einlesen (+, -, *, /)
    //         string operation = Console.ReadLine() ?? "";

    Console.Write("Operator: ");
    operation = Console.ReadLine() ?? "";

    // TODO 4: Berechnen mit if / else if
    //         if (operation == "+") { result = zahl1 + zahl2; }
    //         else if (operation == "-") { ... }
    //         ...
    //         Achtung: Bei "/" zuerst prüfen, ob zahl2 == 0 ist!
    //         Unbekannte Operation → Meldung ausgeben

    if (operation == "+")
    {
      resultat = ersteZahl + zweiteZahl;
    }
    else if (operation == "-")
    {
      resultat = ersteZahl - zweiteZahl;
    }
    else if (operation == "*")
    {
      resultat = ersteZahl * zweiteZahl;
    }
    else if (operation == "/")
    {
      if (zweiteZahl == 0)
      {
        Console.WriteLine("Durch 0 nicht moeglich");
      }
      else
      {
        resultat = ersteZahl / zweiteZahl;
      }
    }
    else
    {
      Console.WriteLine("kein Gueltiger Operator");
    }


    // TODO 5: Ergebnis ausgeben: $"Ergebnis: {result:F2}"
    Console.WriteLine($"Ergebnis: {resultat:F2}");
  }
}

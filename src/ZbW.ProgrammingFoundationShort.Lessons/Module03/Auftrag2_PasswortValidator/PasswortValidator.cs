namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    bool gueltig = false;
    bool zifferEnthalten = false;
    bool passwortLaenge = false;
    string passwort = "";

    // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")

    do
    {
      Console.WriteLine("Bitte gib ein Passwort ein");
      passwort = Console.ReadLine();
      if (passwort == "Sascha")
      {
        Console.WriteLine("Er ist zu Kurz!!!");
        continue;
      }
      if (passwort.Length >= 8)
      {
        passwortLaenge = true;
      }
      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          zifferEnthalten |= true;
        }
      }
      if (passwortLaenge && zifferEnthalten)
      {
        gueltig = true;
      }
      else
      {
        gueltig = false;
        Console.WriteLine("Kein gueltiges Passwort. Passwort muss min. 8 Zeichen lang und eine Zahl enthalten");
      }
    }while (!gueltig);

    Console.WriteLine("Gueltiges Passwort");

    // TODO 3: bool hatZiffer = false;
    //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen

    // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
  }
}

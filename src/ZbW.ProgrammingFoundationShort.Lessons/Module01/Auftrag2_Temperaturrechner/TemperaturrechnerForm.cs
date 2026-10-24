namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  // TODO 1: Konstante für den absoluten Nullpunkt definieren
  //         private const double AbsoluteZero = -273.15;
  const double AbsoluteZero = -273.15;
  double celsius = 0;
  double fahrenheit = 0;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    // TODO 2: Wert aus TxtCelsius lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    if (!double.TryParse(TxtCelsius.Text, out double eingabecelsius))
    {
      MessageBox.Show("Bitte eine Zahl eingeben.", "Ungültige Eingabe");
    }
    else
    {
      // TODO 3: Prüfen ob Wert < AbsoluteZero
      //         → MessageBox mit Warnung, aber weiter rechnen
      if (celsius < AbsoluteZero)
      {
        MessageBox.Show("Zahl ist tiefer als Absolute Null.", "Warnung");
      }

      celsius = eingabecelsius;

      fahrenheit = celsius * 9.0 / 5.0 + 32;

      TxtFahrenheit.Text = fahrenheit.ToString();
      
    }



    // TODO 4: Formel anwenden: fahrenheit = celsius * 9.0 / 5.0 + 32

    // TODO 5: Ergebnis in TxtFahrenheit anzeigen ($"{fahrenheit:F2}")
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {

    if (!double.TryParse(TxtFahrenheit.Text, out double eingabefahrenheit))
    {
      MessageBox.Show("Bitte eine Zahl eingeben.", "Ungültige Eingabe");
    }
    else
    {
      // TODO 3: Prüfen ob Wert < AbsoluteZero
      //         → MessageBox mit Warnung, aber weiter rechnen

      fahrenheit = eingabefahrenheit;

      celsius = (fahrenheit - 32) * 5.0 / 9.0;

      TxtCelsius.Text = celsius.ToString();

      if (celsius < AbsoluteZero)
      {
        MessageBox.Show("Zahl ist tiefer als Absolute Null.", "Warnung");
      }

    }
    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0

    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")
  }
}

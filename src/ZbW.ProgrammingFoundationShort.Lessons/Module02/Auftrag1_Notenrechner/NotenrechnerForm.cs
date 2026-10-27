namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner;

// ============================================================
// AUFTRAG 1 – Notenrechner (⭐ Einfach | ~15 Min.)
//
// Berechne eine Note anhand von Punkten mittels if/else-Kette.
//
// Anforderungen:
//   - TxtPunkte: Punktezahl (0–100) einlesen
//   - if/else-Kette:
//       90–100 → Note 6 / "Sehr gut"
//       75–89  → Note 5 / "Gut"
//       60–74  → Note 4 / "Genügend"
//       < 60   → Note 3 / "Ungenügend"
//   - Ergebnis in LblNote und LblBewertung anzeigen
// ============================================================

public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  int note = 0;

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // TODO 1: Punkte aus TxtPunkte lesen (int.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return

    if (int.TryParse(TxtPunkte.Text, out int eingabeNote))
    {
      note = eingabeNote;
      if ((note < 0) || (note > 100)) {
        MessageBox.Show("Bitte eine gültige Zahl eingeben.", "Ungültige Eingabe");
      }
      else
      {
        if ((note < 101) && (note > 89))
        {
          MessageBox.Show("Note 6 «sehr gut»", "Note");
        }
        else if ((note < 90) && (note > 74))
        {
          MessageBox.Show("Note 5 «gut»", "Note");
        }
        else if ((note < 75) && (note > 59))
        {
          MessageBox.Show("Note 4 «genügend»", "Note");
        }
        else if (note < 60)
        {
          MessageBox.Show("Note 3 «ungenügend»", "Note");
        }
      }
    }
    else
    {
      MessageBox.Show("Bitte eine ganze Zahl eingeben.", "Ungültige Eingabe");
    }

    // TODO 2: if/else-Kette für Noten
    //         90-100 → Note 6 / "Sehr gut"
    //         75-89  → Note 5 / "Gut"
    //         60-74  → Note 4 / "Genügend"
    //         < 60   → Note 3 / "Ungenügend"

    // TODO 3: LblNote.Text und LblBewertung.Text setzen
  }
}

namespace ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp;

// ============================================================
// AUFTRAG 2 – WochentageApp (⭐⭐ Mittel | ~30 Min.)
//
// Zeige Infos zum gewählten Wochentag.
//
// Anforderungen:
//   - CmbWochentag: ComboBox mit Mo, Di, Mi, Do, Fr, Sa, So
//   - switch expression: Werktag oder Wochenende? ("Samstag" or "Sonntag" → Wochenende)
//   - Ternärer Operator für den Ausgabetext
//   - LblErgebnis: Wochentag + Typ anzeigen, z. B. "Samstag ist ein Wochenende."
// ============================================================

public partial class WochentageAppForm : Form
{
  public WochentageAppForm()
  {
    InitializeComponent();
    // TODO 1: ComboBox-Items befüllen: "Montag","Dienstag","Mittwoch","Donnerstag","Freitag","Samstag","Sonntag"
    //         CmbWochentag.SelectedIndex = 0;
    CmbWochentag.Items.AddRange(new object[]
    {
      "Montag", "Dienstag", "Mittwoch", "Donnerstag",
      "Freitag", "Samstag", "Sonntag"
    });
    CmbWochentag.SelectedIndex = 0;
  }

  string wochenTag = "";
  bool istWerktag = false;
  string typ = "";

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    // TODO 2: Gewählten Tag aus CmbWochentag lesen (CmbWochentag.Text)
    wochenTag = CmbWochentag.Text;

    // TODO 3: switch expression → bool istWerktag
    //         ("Samstag" or "Sonntag" → false, sonst true)

    istWerktag = wochenTag switch
    {
      "Samstag" or "Sonntag" => false,
      _ => true
    };

    // TODO 4: Ternären Operator → "Werktag" oder "Wochenende"
    //         string typ = istWerktag ? "Werktag" : "Wochenende";

    typ = istWerktag ? "Werktag" : "Wochenende";

    // TODO 5: LblErgebnis.Text setzen

    LblErgebnis.Text = wochenTag + " ist ein " + typ;
  }

  private void CmbWochentag_SelectedIndexChanged(object sender, EventArgs e)
  {

  }
}

using UnityEngine;

/// <summary>
/// Ermöglicht das Durchschalten einer Liste von GameObjects (z.B. Dialogen)
/// </summary>
public class PageFlip : MonoBehaviour
{
    // Liste mit den Seiten
    public GameObject[] pages;

    // Soll das Menü beim Start geöffnet werden
    public bool isOpenOnStart;

    // Welche Seite ist aktiv
    public int PageIndex { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        // Sicherstellen, dass immer mit der ersten Seite gestartet wird
        ShowPage(0);

        // Zum Start geöffnet?
        if (!isOpenOnStart)
        {
            Close();
        }
    }

    /// <summary>
    /// Zeige eine bestimmte "Seite" an
    /// </summary>
    /// <param name="pageIndex">Index beginnend bei 0 der zu öffnenden Seite.</param>
    public void ShowPage(int pageIndex)
    {
        Close();
        pages[pageIndex]?.SetActive(true);
        PageIndex = pageIndex;
    }

    /// <summary>
    /// Zeige die nächste "Seite" an. Beginne von vorne, wenn das Ende erreicht ist.
    /// </summary>
    public void Next()
    {
        // Index erhöhen und zyklisch anpassen
        PageIndex = (PageIndex + 1) % pages.Length;

        // Geöffnete Seite(n) schließen
        Close();

        // Neue Seite öffnen
        pages[PageIndex].SetActive(true);
    }

    /// <summary>
    /// Zeige die vorherige "Seite" an. Springe ans Ende, wenn der Anfang erreicht ist.
    /// </summary>
    public void Previous()
    {
        // Index verringern und zyklisch anpassen
        PageIndex = (PageIndex - 1 + pages.Length) % pages.Length;

        // Geöffnete Seite(n) schließen
        Close();

        // Neue Seite öffnen
        pages[PageIndex].SetActive(true);
    }

    /// <summary>
    /// Schließt alle "Seiten".
    /// </summary>
    public void Close()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
    }
}

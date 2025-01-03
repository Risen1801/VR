using UnityEngine;

/// <summary>
/// Erm�glicht das Durchschalten einer Liste von GameObjects (z.B. Dialogen)
/// </summary>
public class PageFlip : MonoBehaviour
{
    // Liste mit den Seiten
    public GameObject[] pages;

    // Soll das Men� beim Start ge�ffnet werden
    public bool isOpenOnStart;

    // Welche Seite ist aktiv
    public int PageIndex { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        // Sicherstellen, dass immer mit der ersten Seite gestartet wird
        ShowPage(0);

        // Zum Start ge�ffnet?
        if (!isOpenOnStart)
        {
            Close();
        }
    }

    /// <summary>
    /// Zeige eine bestimmte "Seite" an
    /// </summary>
    /// <param name="pageIndex">Index beginnend bei 0 der zu �ffnenden Seite.</param>
    public void ShowPage(int pageIndex)
    {
        Close();
        pages[pageIndex]?.SetActive(true);
        PageIndex = pageIndex;
    }

    /// <summary>
    /// Zeige die n�chste "Seite" an. Beginne von vorne, wenn das Ende erreicht ist.
    /// </summary>
    public void Next()
    {
        // Index erh�hen und zyklisch anpassen
        PageIndex = (PageIndex + 1) % pages.Length;

        // Ge�ffnete Seite(n) schlie�en
        Close();

        // Neue Seite �ffnen
        pages[PageIndex].SetActive(true);
    }

    /// <summary>
    /// Zeige die vorherige "Seite" an. Springe ans Ende, wenn der Anfang erreicht ist.
    /// </summary>
    public void Previous()
    {
        // Index verringern und zyklisch anpassen
        PageIndex = (PageIndex - 1 + pages.Length) % pages.Length;

        // Ge�ffnete Seite(n) schlie�en
        Close();

        // Neue Seite �ffnen
        pages[PageIndex].SetActive(true);
    }

    /// <summary>
    /// Schlie�t alle "Seiten".
    /// </summary>
    public void Close()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
    }
}

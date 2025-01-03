using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadUebung()
    {
        SceneManager.LoadScene("PA_Übungsraum");
    }

    public void LoadPruefung()
    {
        SceneManager.LoadScene("PA_Prüfraum");
    }

    public void LoadIntro()
    {
        SceneManager.LoadScene("PA_IntroDone");
    }
}

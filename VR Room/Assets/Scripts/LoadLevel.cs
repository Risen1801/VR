using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public void LoadUebung()
    {
        SceneManager.LoadScene("PA_�bungsraum");
    }

    public void LoadPruefung()
    {
        SceneManager.LoadScene("PA_Pr�fraum");
    }

    public void LoadIntro()
    {
        SceneManager.LoadScene("PA_IntroDone");
    }
}

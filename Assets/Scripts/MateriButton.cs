using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MateriButton : MonoBehaviour
{
    public void mainmenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void materi()
    {
        SceneManager.LoadScene("Materi");
    }

    public void materi2()
    {
        SceneManager.LoadScene("Materi_1");
    }

    public void materi3()
    {
        SceneManager.LoadScene("Materi_2");
    }

    public void profil1()
    {
        SceneManager.LoadScene("Profil_1");
    }

    public void profil2()
    {
        SceneManager.LoadScene("Profil_2");
    }

    public void profil3()
    {
        SceneManager.LoadScene("Profil_3");
    }

    public void profil4()
    {
        SceneManager.LoadScene("Profil_4");
    }


}

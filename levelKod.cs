using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelKod : MonoBehaviour
{
    public void levelBir()
    {
        SceneManager.LoadScene("giris");
    }
    public void levelIki()
    {
        SceneManager.LoadScene("ucuncuLevel");
    }
    public void levelUc()
    {
        SceneManager.LoadScene("levelBes");
    }
    public void levelAltii()
    {
        SceneManager.LoadScene("levelAltiSon");
    }
}

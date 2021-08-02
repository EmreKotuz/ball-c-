using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelBesCode : MonoBehaviour
{
    public GameObject kazandiPanel;
    public void exit()
    {
        Application.Quit();
    }
    public void yenidenn()
    {
        SceneManager.LoadScene("levelBes");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kazandi")
        {
            Time.timeScale = 0.0f;
            kazandiPanel.SetActive(true);
        }
    }
    public void menuler()
    {
        SceneManager.LoadScene("levelSistemi");
    }
}

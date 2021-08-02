using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ttuzk: MonoBehaviour
{
    public GameObject bittiPanel;
    public GameObject kazandiPanel;
    public Camera anaaKamera;
    public Camera sagKamera;
    public Camera solKamera;
    public GameObject runClose;
    public GameObject karakterTo;
    public TextMeshProUGUI skorTablo;
    public float skorSayi=30f;



    private void Start()
    {
        Time.timeScale = 0.0f;
    }
    private void Update()
    {
        if (karakterTo.transform.position.y < -1.46f)
        {
            bittiPanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (Time.timeScale == 1.0f)
        {
            skorSayi -= Time.deltaTime;
            skorTablo.text = skorSayi.ToString("f") + " seconds left";
        }  // <>
        if (skorSayi <= 0)
        {
            bittiPanel.SetActive(true);
            Time.timeScale = 0.0f;
            skorTablo.text = "game over";
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "tuzak")
        {
            Time.timeScale = 0.0f;
            bittiPanel.SetActive(true);
        }

        if (other.gameObject.tag == "kazandi")
        {
            Time.timeScale = 0.0f;
            kazandiPanel.SetActive(true);
        }        
    }

    public void baslaButton()
    {
        Time.timeScale = 1.0f;
        anaaKamera.enabled = true;
        sagKamera.enabled = false;
        solKamera.enabled = false;
        runClose.SetActive(false);
    }

    public void ana()
    {
        anaaKamera.enabled = true;
        sagKamera.enabled = false;
        solKamera.enabled = false;
    }

    public void sag()
    {
        anaaKamera.enabled = false;
        sagKamera.enabled = true;
        solKamera.enabled = false;
    }

    public void sol()
    {
        anaaKamera.enabled = false;
        sagKamera.enabled = false;
        solKamera.enabled = true;
    }
    public void tekrar()
    {
        SceneManager.LoadScene("ucuncuLevel");

    }
    public void menuler()
    {
        SceneManager.LoadScene("levelSistemi");
    }
    public void kapat()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class top : MonoBehaviour
{
    public TextMeshProUGUI zaman;
    private float zz = 45;
    public GameObject runButton;
    public GameObject bittiButton;
    public GameObject karakterTop;
    public Material[] materials;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        
    }

    // <> && karakterTop.transform.position.y < 1.1f 
    void Update()
    {
        
            if (Time.timeScale == 0.0f)
            {

            }
            else
            {
                zz -= Time.deltaTime;
                zaman.text = zz.ToString("f2");
            if (karakterTop.transform.position.y < -10.1f)
            {
                bittiButton.SetActive(true);
                Time.timeScale = 0.0f;
            }
            else {
            }

            }
            if (zz <= 0)
            {
                Time.timeScale = 0.0f;
                zaman.text = "GAME OVER";
                bittiButton.SetActive(true);

            }    
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "zamanon")
        {
            Destroy(other);
            zz = zz+ 10;
        }
        if (other.gameObject.tag == "bitti")
        {
            Time.timeScale = 0.0f;
            bittiButton.SetActive(true);
        }
    }
    public void run()
    {
        Time.timeScale = 1.0f;
        runButton.SetActive(false);


    }
    public void menuler()
    {
        SceneManager.LoadScene("levelSistemi");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void yenidenn()
    {
        SceneManager.LoadScene("giris");
    }
}

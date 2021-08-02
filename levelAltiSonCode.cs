using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class levelAltiSonCode : MonoBehaviour { 

public GameObject bittiPanel;
public GameObject kazandiPanel;
public Camera anaaKamera;
public Camera sagKamera;
public Camera solKamera;
public GameObject runClose;
public GameObject karakterTo;
public TextMeshProUGUI skorTablo;
public float skorSayi = 30f;
public GameObject shopPanel;
    public GameObject kontorButton;
    public GameObject ekZamanButton;
    public TextMeshProUGUI money;
    public float moneyFiyat = 0;
    public GameObject altinDönüs;
    protected Joystick joystick;
    protected Joystick joybutton;
    public GameObject top;
    public int hiz = 10;
    private void Start()
{
    Time.timeScale = 0.0f;
    joystick = FindObjectOfType<Joystick>();
    }
    private void Update()
{
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * hiz, rigidbody.velocity.y, joystick.Vertical * hiz);

        if (karakterTo.transform.position.y < -1.46f)
    {
        bittiPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    if (Time.timeScale == 1.0f)
    {
        skorSayi -= Time.deltaTime;
        skorTablo.text = skorSayi.ToString("f") + " seconds left";
            //altinDönüs.transform.Translate(0, 0, 2);
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
        if (other.gameObject.tag == "shopAl")
        {
            Time.timeScale = 0.0f;
            skorSayi = skorSayi + 20;
            Destroy(other.gameObject);
            shopPanel.SetActive(true);
        }
        if (other.gameObject.tag == "altin")
        {
            moneyFiyat =moneyFiyat + 16;
            skorTablo.text = skorSayi.ToString("f") + " seconds left";
            money.text = "Money: " + moneyFiyat.ToString() +" TL";
            Destroy(other.gameObject);
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
    SceneManager.LoadScene("levelAltiSon");

}
public void menuler()
{
    SceneManager.LoadScene("levelSistemi");
}
public void kapat()
{
    Application.Quit();
}
    public void ekZaman()
    {
        if(moneyFiyat >= 50)
        {
            moneyFiyat = moneyFiyat - 55;
            money.text = "Money " + moneyFiyat+ " TL";
            skorSayi = skorSayi + 20;
            skorTablo.text = skorSayi.ToString("f") + " seconds left";
            Destroy(ekZamanButton);
            Debug.Log("paket alındı");
        }
        else
        {
            Debug.Log("paran yetmedi");
        }
        
    }
    public void kontrol()
    {
        if (moneyFiyat >= 40)
        {
            moneyFiyat = moneyFiyat - 45;
            money.text = "Money " + moneyFiyat+" TL";
            hiz = 4;
            Destroy(kontorButton);
            Debug.Log("paket alındı");
        }
        else
        {
            Debug.Log("paran yetmedi");

        }


    }
    public void goOn()
    {
        Time.timeScale = 1.0f;
        shopPanel.SetActive(false);
    }
}
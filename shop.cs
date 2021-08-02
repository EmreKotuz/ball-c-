using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class shop : MonoBehaviour
{
    public GameObject shopPanel;
    public float skorSayii = 45f;
    public TextMeshProUGUI skorr;


    private void Update()
    {
        skorSayii -= Time.deltaTime;
        skorr.text = "Time: " + skorSayii.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shopAl")
        {
            Time.timeScale = 0.0f;
            shopPanel.SetActive(true);
            skorSayii = skorSayii += 40;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;

public class myScript : MonoBehaviour
{
    protected Joystick joystick;
    protected Joystick joybutton;
    public GameObject top;
    public int hiz = 10;
    bool d, dd;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();

    }
    private void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * hiz, rigidbody.velocity.y, joystick.Vertical * hiz);
    }
    public void levelIki()
    {
        
            SceneManager.LoadScene("levelSistemi"); 

}
    
}
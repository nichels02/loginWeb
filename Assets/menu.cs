using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject LoginPanel;
    [SerializeField] GameObject RegistroPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OpenRegister()
    {
        RegistroPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void OpenMenu()
    {
        menuPanel.SetActive(true);
        RegistroPanel.SetActive(false);
        LoginPanel.SetActive(false);
    }

    public void Openlogin()
    {
        menuPanel.SetActive(false);
        LoginPanel.SetActive(true);
    }
}

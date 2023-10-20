using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUIManager : MonoBehaviour
{
    public InputField userField;
    public InputField passField;
    HTTPLogin login;

    void Awake()
    {
        login = FindObjectOfType<HTTPLogin>();
    }

    public void SetUserInputText(string text)
    {
        login.loginData.username = text;
    }
    public void SetPassInputText(string text)
    {
        login.loginData.password = text;
    }
    public void LogIn()
    {
        login.AttempLogin();
    }
}
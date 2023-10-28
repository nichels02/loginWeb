using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUserUIManager : MonoBehaviour
{
    public InputField name;
    public InputField lastname;
    public InputField sex;
    public InputField address;
    public InputField dni;
    public InputField cellphone;
    public InputField username;
    public InputField password;

    public HTTPLogin login;

    void Awake()
    {
        //login = FindObjectOfType<HTTPLogin>();
    }

    public void SetNameInputText(string text)
    {
        login.createUser.name = text;
    }
    public void SetLastNameInputText(string text)
    {
        login.createUser.lastname = text;
    }
    public void SetSexInputText(string text)
    {
        login.createUser.sex = text;
    }
    public void SetAddressInputText(string text)
    {
        login.createUser.address = text;
    }
    public void SetDNIInputText(string text)
    {
        login.createUser.dni = text;
    }
    public void SetCellphoneInputText(string text)
    {
        login.createUser.cellphone = text;
    }
    public void SetUserNameInputText(string text)
    {
        login.createUser.username = text;
    }
    public void SetPasswordInputText(string text)
    {
        login.createUser.password = text;
    }

    public void CreateUser()
    {
        SetNameInputText(name.text);
        SetLastNameInputText(lastname.text);
        SetSexInputText(sex.text);
        SetAddressInputText(address.text);
        SetDNIInputText(dni.text);
        SetCellphoneInputText(cellphone.text);
        SetUserNameInputText(username.text);
        SetPasswordInputText(password.text);

        login.AttemptCreateUser();
    }

    public void outCreate()
    {
        name.text = "";
        lastname.text = "";
        sex.text = "";
        address.text = "";
        dni.text = "";
        cellphone.text = "";
        username.text = "";
        password.text = "";
        login.out_http();
    }
}

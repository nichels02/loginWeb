using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HTTPLogin : MonoBehaviour
{
    [SerializeField] public LoginData loginData;
    [SerializeField] public CreateUser createUser;

    public void AttemptLogin()
    {
        StartCoroutine("Login");
    }

    public void AttemptCreateUser()
    {
        StartCoroutine("CreateUser");
    }

    IEnumerator Login()
    {
        string json = JsonUtility.ToJson(loginData);

        using (UnityWebRequest www = new UnityWebRequest("https://www.elalamohospedaje.com/services/login.php", "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log(responseText);
            }

        }
    }

    IEnumerator CreateUser()
    {
        string json = JsonUtility.ToJson(createUser);

        using (UnityWebRequest www = new UnityWebRequest("https://www.elalamohospedaje.com/services/create_user.php", "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
            www.uploadHandler = new UploadHandlerRaw(bodyRaw);
            www.downloadHandler = new DownloadHandlerBuffer();
            www.SetRequestHeader("Content-Type", "application/json");

            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log(responseText);
            }

        }
    }
}
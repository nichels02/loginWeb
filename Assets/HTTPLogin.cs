using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HTTPLogin : MonoBehaviour
{
    [SerializeField] public LoginData loginData;

    public void AttempLogin()
    {
        StartCoroutine("Login");
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;

public class Test : MonoBehaviour {

    void Awake()
    {
        if (!FB.IsInitialized) {
            FB.Init(InitCallBack);
        }
    }

    void InitCallBack() {
        Debug.Log("FB has been initialized");
    }

    public void Login() {
        if (!FB.IsLoggedIn) {
            FB.LogInWithReadPermissions(new List<string> { "user_friends" }, LoginCallBack);
        }
    }

    void LoginCallBack(ILoginResult result) {
        if (result.Error == null)
        {
            Debug.Log("FB has logged in");
        }
        else {
            Debug.Log("Error during login: " + result.Error);
        }
    }
}

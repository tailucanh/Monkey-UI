using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Text usernameText;
    void Start()
    {
        string selectedAccount = PlayerPrefs.GetString("SelectedAccount");
        if (selectedAccount.Length > 0)
        {
            usernameText.text = selectedAccount;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onLoadUser()
    {
        SceneManager.LoadScene(1);
    }

}

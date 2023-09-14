using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackScene : MonoBehaviour
{
    public Text usernameText;

    public void onBack()
    {
        SceneManager.LoadScene(0);
    }
    public void backToName()
    {

        PlayerPrefs.SetString("SelectedAccount", usernameText.text);

        SceneManager.LoadScene(0);
    }
}

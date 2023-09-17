using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackSceneButton : BaseButton
{

    protected override void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}

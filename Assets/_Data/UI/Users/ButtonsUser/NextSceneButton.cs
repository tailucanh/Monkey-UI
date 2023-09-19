using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextSceneButton : BaseButton
{
    protected override void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}

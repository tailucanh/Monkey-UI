using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackSceneNameButton : BaseButton
{

    [SerializeField] protected Text usernameText;
    [SerializeField] protected Image imageUser;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItems();

    }
    protected virtual void LoadItems()
    {
        //TODO: Load text
        if (this.usernameText != null) return;
        this.usernameText = GetComponentInChildren<Text>();

        //TODO: Load image
        if (this.imageUser != null) return;
        this.imageUser = GetComponentInChildren<Image>();
    }


    protected override void OnClick()
    {
        PlayerPrefs.SetString("UserName", usernameText.text);
        PlayerPrefs.SetString("UserImage", "Assets/Images/" + imageUser.sprite.name + ".png");


        SceneManager.LoadScene(0);
    }
}

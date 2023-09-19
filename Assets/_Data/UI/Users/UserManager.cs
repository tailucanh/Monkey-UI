
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserManager : BaseMonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI usernameText;
    [SerializeField] protected Image imageUser;



    protected override void Start()
    {
        base.Start();
        this.ShowInfo();
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItems();

    }
    protected virtual void LoadItems()
    {

        //TODO: Load text
        if (this.usernameText != null) return;
        this.usernameText = GetComponentInChildren<TextMeshProUGUI>();

        //TODO: Load Image
        GameObject objImage = GameObject.FindGameObjectWithTag("UserImage");
        if (objImage == null) return;
        this.imageUser = objImage.GetComponent<Image>();

    }

    protected virtual void ShowInfo()
    {
        string selectedAccount = PlayerPrefs.GetString("UserName");
        if (selectedAccount.Length > 0)
        {
            this.usernameText.text = selectedAccount;
        }
        string imagePath = PlayerPrefs.GetString("UserImage");

        Texture2D texture = UnityEditor.AssetDatabase.LoadAssetAtPath<Texture2D>(imagePath);
        if (texture != null)
        {
            this.imageUser.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }


    }


}

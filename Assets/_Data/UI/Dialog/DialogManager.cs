using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : BaseMonoBehaviour
{
    protected static DialogManager instance;
    public static DialogManager Instance { get => instance; }
    [SerializeField] protected TextMeshProUGUI itemTextDialog;
    [SerializeField] protected Image imgDialog;

    protected override void Awake()
    {
        base.Awake();
        if (DialogManager.instance != null) Debug.LogError("Only 1 DialogManager allow to exist.");
        DialogManager.instance = this;
    }
    protected override void Start()
    {
        base.Start();
        this.CloseDialog();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDialog();
    }
    protected virtual void LoadDialog()
    {
        //TODO: Load itemTextDialog
        if (this.itemTextDialog != null) return;
        this.itemTextDialog = GetComponentInChildren<TextMeshProUGUI>();


        //TODO: Load Image Dialog
        GameObject objImgDialog = GameObject.FindGameObjectWithTag("ImageDialog");
        if (objImgDialog == null) return;
        this.imgDialog = objImgDialog.GetComponent<Image>();


    }
    public virtual void OpenDialog()
    {
        ItemButton currentItem = ItemManager.Instance.GetCurrentItem();
        if (currentItem != null)
        {
            gameObject.SetActive(true);
            CanvasSettingEvent.Instance.Disable();
            this.itemTextDialog.text = currentItem.Content.text;
            this.imgDialog.sprite = currentItem.ImageItem.sprite;

        }
    }

    public virtual void CloseDialog()
    {
        CanvasSettingEvent.Instance.Enable();
        gameObject.SetActive(false);

    }


}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : BaseMonoBehaviour
{
    protected static DialogManager manager;
    public static DialogManager Manager { get => manager; }
    [SerializeField] protected ItemButton itemButton;
    
    [SerializeField] protected TextMeshProUGUI itemTextDialog;
    [SerializeField] protected Image imgDialog;
    [SerializeField] protected CanvasGroup canvasGroup;
    public CanvasGroup CanvasGroup { get => canvasGroup; }

    protected override void Start()
    {
        base.Start();
        this.ShowDialog();

    }
    protected override void Update()
    {
        base.Update();

        if (this.itemButton.CanvasToToggle != null && this.itemButton.CanvasToToggle.gameObject.activeSelf == true)
        {

            this.canvasGroup.interactable = false;
            this.canvasGroup.blocksRaycasts = false;
        }
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDialog();
    }
    protected virtual void LoadDialog()
    {

        //TODO: Load canvasToToggle
        GameObject objTextDialog = GameObject.FindGameObjectWithTag("TextContentDialog");
        if (objTextDialog == null) return;
        this.itemTextDialog = objTextDialog.GetComponent<TextMeshProUGUI>();


        //TODO: Load Image Dialog
        GameObject objImgDialog = GameObject.FindGameObjectWithTag("ImageDialog");
        if (objImgDialog == null) return;
        this.imgDialog = objImgDialog.GetComponent<Image>();


        //TODO: Load  CanvasGroup
        GameObject objCanvasGroup = GameObject.FindGameObjectWithTag("CanvasGroup");
        if (objCanvasGroup == null) return;
        this.canvasGroup = objCanvasGroup.GetComponentInChildren<CanvasGroup>();

    }
    protected virtual void ShowDialog()
    {
        this.itemTextDialog.text = this.itemButton.Content.text;
        this.imgDialog = this.itemButton.ImageItem;
    }




}

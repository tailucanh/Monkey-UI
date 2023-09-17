using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : BaseMonoBehaviour
{
    protected static DialogManager manager;
    public static DialogManager Instance { get; private set; }
    [SerializeField] protected TextMeshProUGUI itemTextDialog;
    [SerializeField] protected Image imgDialog;

    [SerializeField] protected Canvas canvasToToggle;
    public Canvas CanvasToToggle { get => canvasToToggle; }

    [SerializeField] protected CanvasGroup canvasGroup;

    public CanvasGroup CanvasGroup { get => canvasGroup; }

    protected override void Start()
    {
        base.Start();
        this.CanvasToToggle.gameObject.SetActive(false);
        this.ShowDialog();

    }
    protected override void Update()
    {
        base.Update();

        if (this.CanvasToToggle != null && this.CanvasToToggle.gameObject.activeSelf == true)
        {

            this.canvasGroup.interactable = false;
            this.canvasGroup.blocksRaycasts = false;
        }
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
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

        //TODO: Load canvasToToggle
        GameObject objCanvasToToggle = GameObject.FindGameObjectWithTag("CanvasDialog");
        if (objCanvasToToggle == null) return;
        this.canvasToToggle = objCanvasToToggle.GetComponent<Canvas>();

        //TODO: Load  CanvasGroup
        GameObject objCanvasGroup = GameObject.FindGameObjectWithTag("CanvasGroup");
        if (objCanvasGroup == null) return;
        this.canvasGroup = objCanvasGroup.GetComponentInChildren<CanvasGroup>();

    }
    public virtual void ShowDialog()
    {
        ItemButton currentItem = ItemManager.Instance.GetCurrentItem();
        if (currentItem != null)
        {
            this.canvasToToggle.gameObject.SetActive(true);
            this.itemTextDialog.text = currentItem.Content.text;
            this.imgDialog.sprite = currentItem.ImageItem.sprite;

        }
    }




}

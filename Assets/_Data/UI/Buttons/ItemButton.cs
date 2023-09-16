using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : BaseButton
{
    protected ItemButton item;
    public ItemButton Item { get => item; set => item = value; }
    [SerializeField] protected Text content;
    public Text Content { get => content; }
    [SerializeField] protected Image imgItem;
    public Image ImageItem { get => imgItem; }
    [SerializeField] protected Canvas canvasToToggle;
    public Canvas CanvasToToggle { get => canvasToToggle; }


    protected override void Start()
    {
        base.Start();
        this.canvasToToggle.gameObject.SetActive(false);
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadItems();
    }

    protected virtual void LoadItems()
    {
        //TODO: Load Content
        if (this.content != null) return;
        this.content = GetComponentInChildren<Text>();

        //TODO: Load Image Item
        if (imgItem != null) return;
        this.imgItem = GetComponentInChildren<Image>();

        //TODO: Load canvasToToggle
        GameObject objCanvasToToggle = GameObject.FindGameObjectWithTag("CanvasDialog");
        if (objCanvasToToggle == null) return;
        this.canvasToToggle = objCanvasToToggle.GetComponent<Canvas>();
    }

    protected override void OnClick()
    {
        StartCoroutine(ShowCanvasWithDelay());

    }
    protected virtual void UpdateItemButton(ItemButton newItemButton)
    {
        Item = newItemButton;
    }

    private IEnumerator ShowCanvasWithDelay()
    {
        yield return new WaitForSeconds(0.1f);
        this.canvasToToggle.gameObject.SetActive(true);
        UpdateItemButton(this.item);


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : BaseButton
{
    [SerializeField] protected Text content;
    public Text Content { get => content; }
    [SerializeField] protected Image imgItem;
    public Image ImageItem { get => imgItem; }


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

    }

    protected override void OnClick()
    {
        ShowCanvasWithDelay();
    }
    protected void ShowCanvasWithDelay()
    {
        ItemManager.Instance.SetCurrentItem(this);
        DialogManager.Instance.ShowDialog();

    }
}

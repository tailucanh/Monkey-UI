using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CloseDialogButton : BaseButton
{
    [SerializeField] protected ItemButton itemButton;
    [SerializeField] protected DialogManager dialogManager;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadButton();
        this.LoadItems();
    }
    protected override void OnClick()
    {
        this.OnCloseDialog();

    }
    protected virtual void LoadItems()
    {
        //TODO: Load item button
        if (this.itemButton != null) return;
        this.itemButton = GetComponent<ItemButton>();

        if (this.dialogManager != null) return;
        this.dialogManager = GetComponentInParent<DialogManager>();

    }


    protected virtual void OnCloseDialog()
    {
        this.dialogManager.CanvasGroup.interactable = true;
        this.dialogManager.CanvasGroup.blocksRaycasts = true;

        DialogManager.Instance.CanvasToToggle.gameObject.SetActive(false);
    }

}

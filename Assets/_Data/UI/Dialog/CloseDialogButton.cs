using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CloseDialogButton : BaseButton
{

    protected override void OnClick()
    {
        DialogManager.Instance.CloseDialog();

    }

}

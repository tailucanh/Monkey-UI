using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemManager : BaseMonoBehaviour
{
    protected static ItemManager instance;
    public static ItemManager Instance { get => instance; }

    protected ItemButton currentItem;
    protected override void Awake()
    {
        base.Awake();
        if (ItemManager.instance != null) Debug.LogError("Only 1 ItemManager allow to exist.");
        ItemManager.instance = this;
    }

    public virtual void SetCurrentItem(ItemButton item)
    {
        currentItem = item;
    }

    public virtual ItemButton GetCurrentItem()
    {
        return currentItem;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemManager : BaseMonoBehaviour
{
    public static ItemManager Instance { get; private set; }

    private ItemButton currentItem;


    protected override void LoadComponents()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void SetCurrentItem(ItemButton item)
    {
        currentItem = item;
    }

    public ItemButton GetCurrentItem()
    {
        return currentItem;
    }
}

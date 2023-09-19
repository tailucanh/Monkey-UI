using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class CanvasSettingEvent : BaseMonoBehaviour
{
    protected static CanvasSettingEvent instance;
    public static CanvasSettingEvent Instance { get => instance; }
    [SerializeField] protected CanvasGroup canvasGroup;

    protected override void Awake()
    {
        base.Awake();
        if (CanvasSettingEvent.instance != null) Debug.LogError("Only 1 CanvasSettingEvent allow to exist.");
        CanvasSettingEvent.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCanvasGroup();
    }
    protected virtual void LoadCanvasGroup()
    {
        //TODO: Load  CanvasGroup
        if (this.canvasGroup != null) return;
        this.canvasGroup = GetComponent<CanvasGroup>();
    }

    public virtual void Disable()
    {
        this.canvasGroup.interactable = false;
        this.canvasGroup.blocksRaycasts = false;
    }

    public virtual void Enable()
    {
        this.canvasGroup.interactable = true;
        this.canvasGroup.blocksRaycasts = true;
    }




}

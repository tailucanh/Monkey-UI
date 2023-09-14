using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EventUI : MonoBehaviour
{
    public Text content;
    public Image imgItem;
    public Canvas canvasToToggle;
    public TextMeshProUGUI itemTextDialog;
    public Image imgDialog;
    public CanvasGroup canvasGroup;


    void Start()
    {
        canvasToToggle.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (canvasToToggle.gameObject.activeSelf == true)
        {
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }
    }

    public void onClickEvent()
    {

        StartCoroutine(ShowCanvasWithDelay());

    }



    private IEnumerator ShowCanvasWithDelay()
    {
        yield return new WaitForSeconds(0.1f);

        canvasToToggle.gameObject.SetActive(true);
        itemTextDialog.text = content.text;
        imgDialog.sprite = imgItem.sprite;

        Debug.Log("Tên khóa: " + content.text);
    }
    public void onCloseDialog()
    {

        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        canvasToToggle.gameObject.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolTip : MonoBehaviour
{
    private Text tooltipText;
    private RectTransform BackgroundRectTransform;

    private void Awake()
    {
        BackgroundRectTransform = transform.Find("Image").GetComponent<RectTransform>();
        tooltipText = transform.Find("Text").GetComponent<Text>();

        ShowTooltip("Random tooltip");
    }


    public void ShowTooltip(string tooltipString)
    {
        gameObject.SetActive(true);

        tooltipText.text = tooltipString;
        float textPaddingSize = 4f;
        Vector2 backgroundSize = new Vector2(tooltipText.preferredWidth + textPaddingSize * 2f, tooltipText.preferredWidth + textPaddingSize * 2f);
        BackgroundRectTransform.sizeDelta = backgroundSize;
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}

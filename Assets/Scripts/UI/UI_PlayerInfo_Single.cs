using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UI_PlayerInfo_Single : MonoBehaviour
{
    [SerializeField] private RectTransform barContainer;

    private Image image;
    private GameObject barTemplate;

    private void Awake()
    {
        image = GetComponent<Image>();
        barTemplate = barContainer.GetChild(0).gameObject;
        barTemplate.SetActive(false);
    }

    void SetImage(Sprite sprite)
    {
        image.sprite = sprite;
    }

    void SetValue(int value)
    {
        for(int i=1; i<barContainer.childCount; i++)
        {
            Destroy(barContainer.GetChild(i).gameObject);
        }

        for(int i=0; i<value; i++)
        {
            Instantiate(barTemplate, barContainer).SetActive(true);
        }
    }

    public void SetInfo(Sprite sprite, int value)
    {
        SetImage(sprite);
        SetValue(value);
    }
}

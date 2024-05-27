using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_PlayerInfoPanel : MonoBehaviour
{
    [SerializeField] PowerupStatsViewer_SO powerupStatsViewer_SO;

    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private RectTransform infoContainer;
    [SerializeField] private GameObject player;

    private GameObject infoTemplate;

    private void Awake()
    {
        infoTemplate = infoContainer.GetChild(0).gameObject;
        infoTemplate.SetActive(false);
        titleText.text = player.name;
    }

    private void Start()
    {
        UpdateAllStats(null, EventArgs.Empty);
    }

    private void OnEnable()
    {
        Pickup.OnPicked += UpdateAllStats;
    }

    private void OnDisable()
    {
        Pickup.OnPicked -= UpdateAllStats;
    }

    void UpdateAllStats(object sender, EventArgs e)
    {
        for(int i= infoContainer.childCount-1; i>0; i--)
        {
            Destroy(infoContainer.GetChild(i).gameObject);
        }

        Info[] infoTable = powerupStatsViewer_SO.GetValuesToDisplay(player);

        foreach(Info i in infoTable)
        {
            GameObject info = Instantiate(infoTemplate, infoContainer);
            info.SetActive(true);
            info.GetComponent<UI_PlayerInfo_Single>().SetInfo(i.sprite, i.value);
        }
    }
}

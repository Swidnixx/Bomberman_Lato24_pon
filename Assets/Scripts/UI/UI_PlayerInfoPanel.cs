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

    private void OnEnable()
    {
        Pickup.OnPicked += UpdateAllStats;
    }
    private void OnDisable()
    {
        Pickup.OnPicked -= UpdateAllStats;
    }

    private void Awake()
    {
        infoTemplate = infoContainer.GetChild(0).gameObject;
        infoTemplate.SetActive(false);
        titleText.text = player.name;
    }

    private void Start()
    {
        UpdateAllStats();
    }

    public void UpdateAllStats()
    {
        for(int i=1; i<infoContainer.childCount; i++)
        {
            Destroy(infoContainer.GetChild(i).gameObject);
        }

        Info[] infoTable = powerupStatsViewer_SO.GetValuesToDisplay(player);

        foreach(Info info in infoTable)
        {
            GameObject infoDisplay = Instantiate(infoTemplate, infoContainer);
            infoDisplay.SetActive(true);
            infoDisplay.GetComponent<UI_PlayerInfo_Single>().SetInfo(info.sprite, info.value);
        }
    }
}

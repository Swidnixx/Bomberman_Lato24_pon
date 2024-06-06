using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Info
{
    public Sprite sprite;
    public int value;
}

[CreateAssetMenu(fileName = "PowerupStatsViewer_SO")]
public class PowerupStatsViewer_SO : ScriptableObject
{
    [SerializeField] private Sprite speedPickupImage;
    [SerializeField] private Sprite rangePickupImage;
    [SerializeField] private Sprite bombPickupImage;

    public Info[] GetValuesToDisplay(GameObject player)
    {
        BombController bombController = player.GetComponent<BombController>();
        MovementController movementController = player.GetComponent<MovementController>();

        return new Info[]
        {
            new Info
            {
                sprite = speedPickupImage,
                value =  (int)(movementController.Speed / 0.5f)
            },

            new Info
            {
                sprite = rangePickupImage,
                value = bombController.GetExplosionRadius()
            },

            new Info
            {
                sprite = bombPickupImage,
                value = bombController.BombAmount
            },
        };
    }
}

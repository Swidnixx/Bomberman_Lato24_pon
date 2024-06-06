using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBomb : Pickup
{
    protected override void Picked(GameObject player)
    {
        player.GetComponent<BombController>().IncreaseBombAmount();
        base.Picked(player);
    }
}

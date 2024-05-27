using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRange : Pickup
{
    protected override void Picked(GameObject player)
    {
        player.GetComponent<BombController>().IncreaseBombRange();
        base.Picked(player);
    }
}

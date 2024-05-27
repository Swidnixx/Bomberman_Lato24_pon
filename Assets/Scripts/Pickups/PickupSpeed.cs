using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpeed : Pickup
{
    protected override void Picked(GameObject player)
    {
        player.GetComponent<MovementController>().IncreaseSpeed();
        base.Picked(player);
    }
}

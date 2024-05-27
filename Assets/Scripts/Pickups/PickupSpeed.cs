using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpeed : Pickup
{
    protected override void Picked(GameObject player)
    {
        player.GetComponent<MovementController>().IncreaseMovementSpeed();
        base.Picked(player);
    }
}

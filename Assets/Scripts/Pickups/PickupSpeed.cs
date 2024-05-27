using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpeed : Pickup
{
    protected override void Picked(GameObject player)
    {
        base.Picked(player);
        player.GetComponent<MovementController>().IncreaseMovementSpeed();
    }
}

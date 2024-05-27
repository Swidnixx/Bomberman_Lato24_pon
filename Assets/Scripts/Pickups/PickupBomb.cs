using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBomb : Pickup
{
    protected override void Picked(GameObject player)
    {
        // dzia³anie pickupa
        player.GetComponent<BombController>().GrantExtraBomb();
        base.Picked(player);
    }
}

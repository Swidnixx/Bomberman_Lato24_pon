using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public static event EventHandler OnPicked;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerController.PLAYER_TAG))
        {
            Picked(other.gameObject);
        }
    }

    protected virtual void Picked(GameObject player)
    {
        OnPicked?.Invoke(this, EventArgs.Empty);
        Destroy(gameObject);
    }
}

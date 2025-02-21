using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombController : MonoBehaviour
{
    [Header("Key bindings")]
    [SerializeField] private KeyCode inputKey = KeyCode.Space;

    [Header("Bomb parameters")]
    [SerializeField] private  int bombAmount = 1;
    [SerializeField] private int explosionRadius = 2;
    public int GetExplosionRadius() => explosionRadius;

    private int bombsRemaining;
    private bool stayOnBomb = false;
    
    private void Awake()
    {
        bombsRemaining = bombAmount;
    }

    private void Update()
    {
        if (bombsRemaining > 0 && Input.GetKeyDown(inputKey))
        {
            PlaceBomb();
        }
    }

    private void PlaceBomb()
    {
        // przerywamy je�li gracz stoi na bombie
        
        // zmniejszamy liczb� dost�pnych bomb
        
        // stawiamy bomb� korzystaj�c z BombSpawnera
        // podajemy w�asn� aktualn� pozycj�
        
        // ustawiamy �e stoimy na bombie aby zapobiec
        // stawianiu kolejnej do czasu odej�cia z kolejnej
        
    }
}

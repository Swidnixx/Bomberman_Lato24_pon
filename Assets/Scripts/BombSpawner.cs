using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BombSpawner : MonoBehaviour
{
    
    public static BombSpawner Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            DestroyImmediate(gameObject);
    }

    [SerializeField] private GameObject bombPrefab;

    public void PlaceBomb(Vector3 position, BombController owner)
    {
        // znormalizuj podan¹ w parametrze pozycjê u¿ywaj¹c
        // metody NormalizePosition() z klasy HelperFunctions
        position = HelperFunctions.NormalizePosition(position);
        // stwórz obiekt bomby na scenie w znormalizowanej pozycji
        GameObject bombObject = Instantiate(bombPrefab, position, Quaternion.identity);

        bombObject.GetComponent<Bomb>().SetOwner(owner);
    }
}

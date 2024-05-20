using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovementController : MonoBehaviour
{
    [SerializeField] private bool isRotating = true;

    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float rotationSpeed = 7f;

    public Vector3 Direction { get; private set; } = Vector3.zero;
    public Rigidbody Rigidbody { get; private set; }

    // Start is called before the first frame update
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveObject();
        if(isRotating) RotateObject();
    }

    private void MoveObject()
    {
        // Obliczamy moveVector jako kierunek pomno�ony razy
        // pr�dko�� i czas od ostatniego ticka silnika fizyki
        
        // przesuwamy pozycj� rigidbody gracza
        // jako obecna plus moveVector
        
    }

    private void RotateObject()
    {
        // je�li kierunek jest ustawiony (r�ny od Vector3.zero)
        // oblicz obr�t i obr�� posta� o wyliczony obr�t

    }

    // dodaj ustawianie kierunku

}

using UnityEngine;

[RequireComponent(typeof(MovementController))]
public class PlayerController : MonoBehaviour
{
    public const string PLAYER_TAG = "Player";
    public static int PLAYER_LAYER_MASK { get => LayerMask.NameToLayer("Player"); }

    [SerializeField] private KeyCode upKey = KeyCode.W;
    [SerializeField] private KeyCode downKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private MovementController movementController;

    private void Awake()
    {
        movementController = GetComponent<MovementController>();
    }

    void Update()
    {
        // Ustawiamy kierunek na podstawie Inputu gracza
        if(Input.GetKeyDown(rightKey))
            movementController.SetDirection(Vector3.right);
        if (Input.GetKeyDown(leftKey))
            movementController.SetDirection(Vector3.left);
        if (Input.GetKeyDown(upKey))
            movementController.SetDirection(Vector3.forward);
        if (Input.GetKeyDown(downKey))
            movementController.SetDirection(Vector3.back);

        if (!Input.anyKey)
            movementController.SetDirection(Vector3.zero);
    }
}

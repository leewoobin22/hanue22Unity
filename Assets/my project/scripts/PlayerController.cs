using UnityEngine;

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private InputActionReference moveInput;
    [SerializeField] private float speed = 5f;

    private Vector2 moveDir;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // WASD 입력
        moveDir = moveInput.action.ReadValue<Vector2>().normalized;
    }

    private void FixedUpdate()
    {
        // 2D 이동
        rb.MovePosition(rb.position + moveDir * speed * Time.fixedDeltaTime);
    }
}

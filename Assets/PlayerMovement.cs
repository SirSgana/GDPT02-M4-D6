using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    private Rigidbody _rb;

    [Header("Movement")]
    [SerializeField] private float _moveSpeed = 5f;

    private Vector3 _dir;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Input
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        _dir = new Vector3(h, 0f, v).normalized;
    }

    private void FixedUpdate()
    {
        _rb.velocity = _dir * _moveSpeed;
    }
}
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class InteractableItem : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private float _defoultGravityScale = 1;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Zeroize()
    {
        _rigidbody2D.gravityScale = 0;
        _rigidbody2D.velocity = Vector3.zero;
    }

    public void Reset()
    {
        _rigidbody2D.gravityScale = _defoultGravityScale;
    }

}

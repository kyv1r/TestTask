using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DragAndDrop : MonoBehaviour
{
    [SerializeField] private InteractableItem _interactableItem;

    private Vector3 _offset;
    private bool _isDragging = false;

    private void OnMouseDown()
    {
        _isDragging = true;
        _interactableItem.Zeroize();

        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z));
        _offset = transform.position - mouseWorldPoint;
    }

    private void OnMouseDrag()
    {
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z));
        transform.position = mouseWorldPoint + _offset;
    }

    private void OnMouseUp()
    {
        _isDragging = false;
        _interactableItem.Reset();
    }

    public bool IsDragging()
    {
        return _isDragging;
    }
}

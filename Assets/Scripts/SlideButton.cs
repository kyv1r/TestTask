using UnityEngine;
using UnityEngine.EventSystems;

public class SlideButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed = 5f;

    [Header("Camera Bounds")]
    [SerializeField] private float _minX = 0f;
    [SerializeField] private float _maxX = 40f;

    private bool _isPressed;


    private void Update()
    {
        if (_isPressed && _camera != null)
        {
            MoveCamera();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isPressed = false;
    }

    private void MoveCamera()
    {
        Vector3 newPosition = _camera.transform.position + _direction * _speed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, _minX, _maxX);
        _camera.transform.position = newPosition;
    }
}

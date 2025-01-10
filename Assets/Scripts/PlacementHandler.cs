using UnityEngine;

public class PlacementHandler : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out InteractableItem interactableItem))
        {
            interactableItem.Zeroize();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out InteractableItem interactableItem))
            interactableItem.Reset();
    }
}

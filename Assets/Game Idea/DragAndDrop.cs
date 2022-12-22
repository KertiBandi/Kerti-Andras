using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] SpriteRenderer highlight;



    private void OnMouseEnter()
    {
        if(highlight != null)
            {
            highlight.enabled = true;
        }
    }

    private void OnMouseExit()
    {
        if (highlight != null)
        {
            highlight.enabled = false;
        }
    }

    Vector2 cardStartPosotion;
    Vector2 mouseStartPosotion;

    private void OnMouseDown()
    {
        
        cardStartPosotion = transform.position;
        mouseStartPosotion = Camera.main.ScreenToWorldPoint(Input.mousePosition);


    }

    private void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 offsetVector = mousePosition - mouseStartPosotion;
        transform.position = cardStartPosotion + offsetVector;

    }

    private void OnMouseUp()
    {
        
    }


}

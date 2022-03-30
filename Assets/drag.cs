using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;
public class drag : MonoBehaviour
{
    bool Drag;
    public bool May = true;
    //rbb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    private void OnMouseDown()
    {
        Drag = true;
    }
    private void OnMouseUp()
    {
        Drag = false;
    }
    private void Update()
    {
        if (Drag && May)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }
    }
}

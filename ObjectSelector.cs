using UnityEngine;

public class ObjectSelector : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                SelectableObject selectable = hit.collider.GetComponent<SelectableObject>();

                if (selectable != null)
                {
                    selectable.selected = !selectable.selected;
                }
                
            }
        }
    }
}


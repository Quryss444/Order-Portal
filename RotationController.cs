using UnityEngine;

public class RotationController : MonoBehaviour
{
    public bool isSelected;

    public float rate = 25f;

    public float RX   = 0f;
    public float RY   = -180f;
    public float RZ   = 0f;

    public float RX2 = 0f;
    public float RY2 = 0f;
    public float RZ2 = 0f;

    public Vector3 V;  

    private Quaternion targetRotation;

    /////////////////////////////////////////////////////////////////////////

    void Start()
    {
        targetRotation = Quaternion.Euler(RX, RY, RZ);
        V = new Vector3(RX2, RY2, RZ2);
    }

    void Update() 
    {
        isSelected = GetComponentInChildren<SelectableObject>().selected;
        RotationEngine(rate);        
    }

/////////////////////////////////////////////////////////////////////////

    public void SetSelected(bool s)
    {
        isSelected = s;
    }

    private void RotationEngine(float r)
    {
        if (isSelected)
        {
            transform.Rotate(V, r * Time.deltaTime);
        }

        if (!isSelected) 
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, r/2 * Time.deltaTime);
        }

    }

}

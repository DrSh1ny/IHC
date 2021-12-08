using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera m_MainCamera;
    private void OnMouseDrag()
    {
        this.transform.localScale = new Vector3(2, 2, 2);
        m_MainCamera.GetComponent<updateDraggedObject>().draggedObject = this.gameObject;
    }

    private void OnMouseUp()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
        m_MainCamera.GetComponent<updateDraggedObject>().draggedObject = null;
    }

}

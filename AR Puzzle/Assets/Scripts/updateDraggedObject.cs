using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateDraggedObject : MonoBehaviour
{
    public Vector3 lastOrientation;
    public GameObject draggedObject = null;
    // Start is called before the first frame update

    private void LateUpdate()
    {
        
        if (draggedObject != null)
        {
            Vector3 diffAngle = new Vector3(this.transform.localEulerAngles.x - lastOrientation.x, this.transform.localEulerAngles.y - lastOrientation.y, this.transform.localEulerAngles.z - lastOrientation.z);
            draggedObject.transform.RotateAround(this.transform.position, Vector3.up, diffAngle.y);
            draggedObject.transform.RotateAround(this.transform.position, this.transform.right, diffAngle.x);
        }

    }

}

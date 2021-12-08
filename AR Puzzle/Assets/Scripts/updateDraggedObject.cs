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
            Vector3 diffAngle = new Vector3(this.transform.eulerAngles.x - lastOrientation.x, this.transform.eulerAngles.y - lastOrientation.y, this.transform.eulerAngles.z - lastOrientation.z);
            draggedObject.transform.RotateAround(this.transform.position, new Vector3(0, 1, 0), diffAngle.y);
            draggedObject.transform.RotateAround(this.transform.position, new Vector3(1, 0, 0), diffAngle.x);
        }

    }

}

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

        //check if its over the target puzzle position
        RaycastHit[] hits;
        hits = Physics.RaycastAll(m_MainCamera.transform.position,this.transform.position- m_MainCamera.transform.position, 100.0f);
        int counterSameTag = 0;
        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            string objTag = hit.transform.tag;
         
            if (objTag == this.tag)
            {
                counterSameTag += 1;
            }
        }

        if (counterSameTag == 2)
        {
            GameObject[] allObjts = GameObject.FindGameObjectsWithTag(this.tag);
            for (int i = 0; i < allObjts.Length; i++)
            {
                allObjts[i].GetComponent<Renderer>().enabled = true;
            }
            this.gameObject.SetActive(false);
            m_MainCamera.GetComponent<updateDraggedObject>().draggedObject = null;
        }
    }

    private void OnMouseUp()
    {
        this.transform.localScale = new Vector3(1, 1, 1);
        m_MainCamera.GetComponent<updateDraggedObject>().draggedObject = null;
    }

}

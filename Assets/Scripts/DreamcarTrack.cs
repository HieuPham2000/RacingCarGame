using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamcarTrack : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject MarkParent;
    public int MarkTracker;
    public int MarkCount;

    void Start()
    {
        MarkCount = MarkParent.transform.childCount;
    }
    void Update()
    {
        var Mark = MarkParent.transform.GetChild(MarkTracker);
        TheMarker.transform.position = Mark.transform.position;
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Dreamcar")
        {
            this.GetComponent<BoxCollider>().enabled = false;

            MarkTracker += 1;
            if(MarkTracker == MarkCount)
            {
                MarkTracker = 0;
            }

            yield return  new WaitForSeconds(1);

            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

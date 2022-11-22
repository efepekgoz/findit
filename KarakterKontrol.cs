using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class KarakterKontrol : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public GameObject targetDest;
    public Ray ray;
    public RaycastHit hit;
    public RaycastHit hitPoint;


    void start()
    {
 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           
        if (Physics.Raycast(ray, out hitPoint)) { 
            if (hitPoint.collider != null)
            {
                Debug.Log("clicked" + hitPoint.collider.name);
            }
            }

            if (Physics.Raycast(ray,out hitPoint))
            {
                targetDest.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
                
            }
        }
      




    }



}

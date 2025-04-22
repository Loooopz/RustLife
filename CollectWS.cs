using UnityEngine;

public class Test : MonoBehaviour
{
    public int resourseStoneCollected = 0;
    public int resourseWoodCollected = 0;
    public GameObject Shelter;
    public Vector3 spawnposition;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
               if(Physics.Raycast(transform.position,transform.forward, out hit, 2f)) 
               {
                   if(hit.collider.tag == "Stone")
                   {
                       Destroy(hit.collider.gameObject);
                       print(resourseWoodCollected);
                        resourseStoneCollected += 1;
                        
                   }
                   if(hit.collider.tag == "Wooden_Planks")
                   {
                       resourseWoodCollected += 1;
                       print(resourseWoodCollected);
                       Destroy(hit.collider.gameObject);
                   }
               }


        }
            if(resourseWoodCollected == 10) 
            {
               //Shelter.SetActive(true);
            }
         //if(Physics.Raycast(ray, out hit))
         //{
          // Transform objectHit = hit.transform;
            //print(objectHit.name);
        // }
    }
}

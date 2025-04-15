using UnityEngine;

public class TriggerCigaka : MonoBehaviour
{
    public GameObject Ciganka;
    public void OnTriggerEnter(Collider other) 
    {
         if(other.gameObject.tag == "Player") 
         {
            Ciganka.GetComponent<NPCmove>().speed = 3f;

         }
    }
        public void OnTriggerExit(Collider other) 
    {
         if(other.gameObject.tag == "Player") 
         {
            Ciganka.GetComponent<NPCmove>().speed = 0f;

         }
        
        
    }
}

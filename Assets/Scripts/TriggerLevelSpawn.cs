using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLevelSpawn : MonoBehaviour
{    
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            other.GetComponent<Player>().passedPoint?.Invoke();
        }
    }
}

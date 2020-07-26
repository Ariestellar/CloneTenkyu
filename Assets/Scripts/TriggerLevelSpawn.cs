using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLevelSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _triggerDefeat;

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            other.GetComponent<Player>().passedPoint?.Invoke();
            _triggerDefeat.SetActive(false);
        }
    }
}

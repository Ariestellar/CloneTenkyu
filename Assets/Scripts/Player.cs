using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] public UnityAction passedPoint;
    [SerializeField] public UnityAction defeat;

    public void Init(LevelSpawn levelSpawn)
    {
        passedPoint += levelSpawn.CreateLevel;
        defeat += levelSpawn.StartLevel;
    }
}

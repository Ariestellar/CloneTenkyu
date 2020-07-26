using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private LevelSpawn _levelSpawn;
    public void ButtonRestart()
    {
        _levelSpawn.StartLevel();
    }
}

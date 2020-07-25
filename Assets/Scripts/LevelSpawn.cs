using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{    
    [SerializeField] private Transform _levelPrefab;
    [SerializeField] private Transform _playerPrefab;
    [SerializeField] private CameraMovement _cameraMovement;

    [SerializeField] private List<Transform> _currentLevels;

    private void Start()
    {        
        Transform currentLevel = Instantiate(_levelPrefab);
        Transform player = Instantiate(_playerPrefab);
        _currentLevels.Add(currentLevel);
        _cameraMovement.Init(player);
    }

    public void CreateLevel()
    {
        Transform currentPosition = _currentLevels[_currentLevels.Count - 1];
        Transform _newLevel = Instantiate(_levelPrefab);
        _newLevel.position = new Vector3(currentPosition.position.x - 120, currentPosition.position.y - 60, currentPosition.position.z);
        _currentLevels.Add(_newLevel);

        if (_currentLevels.Count > 2)
        {
            Destroy(_currentLevels[0]);
            _currentLevels.RemoveAt(0);
        }
    }
}

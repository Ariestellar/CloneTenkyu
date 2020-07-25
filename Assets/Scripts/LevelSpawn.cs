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
        player.GetComponent<Player>().Init(this);
        _currentLevels.Add(currentLevel);
        _cameraMovement.Init(player);
    }

    public void CreateLevel()
    {
        Transform currentPosition = _currentLevels[_currentLevels.Count - 1];
        Transform _newLevel = Instantiate(_levelPrefab);
        _newLevel.position = new Vector3(currentPosition.position.x, currentPosition.position.y - 120, currentPosition.position.z - 60);
        _currentLevels.Add(_newLevel);

        if (_currentLevels.Count > 2)
        {
            Destroy(_currentLevels[0].gameObject);
            _currentLevels.RemoveAt(0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{    
    [SerializeField] private Transform _levelPrefab;
    [SerializeField] private Transform _playerPrefab;
    [SerializeField] private CameraMovement _cameraMovement;    

    [SerializeField] private List<Transform> _currentLevels;
    private Transform _player;

    private void Start()
    {
        StartLevel();
    }

    public void CreateLevel()
    {
        Transform currentPosition = _currentLevels[_currentLevels.Count - 1];
        Transform _newLevel = Instantiate(_levelPrefab);        
        _newLevel.position = new Vector3(currentPosition.position.x, currentPosition.position.y - 50, currentPosition.position.z - 20);
        _currentLevels.Add(_newLevel);

        if (_currentLevels.Count > 2)
        {
            Destroy(_currentLevels[0].gameObject);
            _currentLevels.RemoveAt(0);
        }
    }

    public void StartLevel()
    {
        if (_currentLevels.Count > 0)
        {
            for (int i = 0; i < _currentLevels.Count; i++)
            {
                Destroy(_currentLevels[i].gameObject);                
            }
            _currentLevels.Clear();
        }
        Transform currentLevel = Instantiate(_levelPrefab);

        if (_player == null)
        {
            _player = Instantiate(_playerPrefab);
            _player.GetComponent<Player>().Init(this);
        }
        else
        {
            _player.position = new Vector3(0, 2.5f, 0);
        }
        
        _currentLevels.Add(currentLevel);
        _cameraMovement.Init(_player);
    }
}

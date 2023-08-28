using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using UnityEngine.SceneManagement;

public class NetworkRunnerHandle : MonoBehaviour
{
    [SerializeField] private NetworkRunner _networkRunnerPrefab;
    private NetworkRunner _networkRunner;

    private void Start()
    {
        StartGame(GameMode.AutoHostOrClient);
    }

    private async void StartGame(GameMode mode)
    {
        _networkRunner = Instantiate(_networkRunnerPrefab);
        await _networkRunner.StartGame(new StartGameArgs()
        {
            GameMode = mode,
            SessionName = "TestRoom",
            Scene = SceneManager.GetActiveScene().buildIndex,
            SceneManager = gameObject.AddComponent<NetworkSceneManagerDefault>()
        });
    }
}
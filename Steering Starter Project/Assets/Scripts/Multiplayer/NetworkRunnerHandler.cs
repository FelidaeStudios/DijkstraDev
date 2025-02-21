/*using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkRunnerHandler : MonoBehaviour
{
    [SerializeField]
    NetworkRunner networkRunnerPrefab;

    NetworkRunner networkRunner;

    private void Awake()
    {
        networkRunner networkRunnerInScene = FindObjectOfType<NetworkRunner>();

        if (networkRunnerInScene != null)
        {
            networkRunner = networkRunnerInScene;
        }
    }

    void Start()
    {
        if (networkRunner == null)
        {
            networkRunner = Instantiate(networkRunnerPrefab);
            networkRunner.name = "Network Runner";

            GameMode gameMode = GameMode.Client;

            gameMode = GameMode.AutoHostOrClient;
        }
    }

    protected virtual Task InitializeNetworkRunner(NetworkRunner runner, GameMode gameMode, string sessionName, NetAddress address, SceneRef scene, Action<NetworkRunner> initialized)
    {
        var sceneManager = GetSceneManager(runner);
        runner.ProvideInput = true;

        Utils.DebugLog($"InitializeNetworkRunner done");

        return runner.StartGame(new StartGameArgs
        {
            GameMode = gameMode,
            Address = address,
            Scene = scene,
            SessionName = sessionName,
            Initialized = initialized,
            SceneManager = sceneManager
        });
    }

    INetworkSceneManager GetSceneManager(NetworkRunner runner)
    {

    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<Wave> _waves = new List<Wave>();
    [SerializeField] private int _currentWaveIndex = 0;

    void Start()
    {
        StartCoroutine(StartWaveRoutine());
    }

    IEnumerator StartWaveRoutine()
    {
        while (_currentWaveIndex < _waves.Count)
        {
            var currentWave = _waves[_currentWaveIndex].sequence;
            var waveContainer = new GameObject("Wave_Container");

            Debug.Log("***** Wave " + (_currentWaveIndex + 1) + " *****");
            foreach (var obj in currentWave)
            {
                Instantiate(obj, waveContainer.transform);
                yield return new WaitForSeconds(1.0f);
            }

            // delay for human inspection
            yield return new WaitForSeconds(5.0f);

            Destroy(waveContainer);

            _currentWaveIndex++;
        }
        Debug.Log("All Waves Completed!");
    }
}

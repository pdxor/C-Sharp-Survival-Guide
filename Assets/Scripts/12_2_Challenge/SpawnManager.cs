using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Challenge 12-2
/// - Create a list/array of 3 gameObjects to spawn.
/// - When the Space key is pressed,
/// - randomly spawn them with a random position on the screen between -10 and +10 on the X/Y plane
/// - Every object spawned should be stored intp a list called objectsCreated
/// - When 10 objects have been spawned, stop spawning
/// - Turn all objects green, and clear the list
/// </summary>
namespace RandomSpawnSpace
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objsToSpawn = new GameObject[3];
        [SerializeField] private List<GameObject> _objectsCreated = new List<GameObject>();
        private GameObject _objectCreated;
        [SerializeField] private int _maxObjectsToSpawn;
        public int SpawnCount { get; set; }
        private int _objIndex;
        private float _randomXPosition;
        private float _randomYPosition;
        private Vector3 _spawnPosition;
        private bool _initColorChange;

        void Start()
        {
            _maxObjectsToSpawn = 10;

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);

            _objsToSpawn[0] = cube;
            _objsToSpawn[1] = sphere;
            _objsToSpawn[2] = capsule;

            foreach (var obj in _objsToSpawn)
            {
                obj.gameObject.SetActive(false);
            }

            _initColorChange = false;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_objectsCreated.Count == _maxObjectsToSpawn)
                {
                    _initColorChange = true;
                    return;
                }
                else if (SpawnCount < _maxObjectsToSpawn)
                {
                    _objIndex = Random.Range(0, _objsToSpawn.Length);
                    _randomXPosition = Random.Range(-10f, 10f);
                    _randomYPosition = Random.Range(-10f, 10f);
                    _spawnPosition = new Vector3(_randomXPosition, _randomYPosition, 0f);
                    _objectCreated = Instantiate(_objsToSpawn[_objIndex], _spawnPosition, Quaternion.identity);
                    _objectsCreated.Add(_objectCreated);
                    _objectsCreated[SpawnCount].gameObject.SetActive(true);
                    SpawnCount++;
                }
            }

            if (_initColorChange == true)
            {
                StartCoroutine(ColorChangeRoutine());
            }
        }

        IEnumerator ColorChangeRoutine()
        {
            _initColorChange = false;

            yield return new WaitForSeconds(2.0f);
            foreach (var obj in _objectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            _objectsCreated.Clear();
        }
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enums
/// - Can assign int value for selected item, or use default
/// - Creates drop down list in Inspector
/// </summary>
namespace SelectDifficlutyEnumSpace
{
    public class SelectDifficulty : MonoBehaviour
    {
        public enum LevelSelector
        {
            Easy = 0,        // default is 0
            Normal = 42,     // default is 1
            Hard = 55,       // default is 2
            Expert = 66      // default is 3
        }

        [SerializeField] private LevelSelector _currentLevel;

        private void Awake()
        {
            _currentLevel = 0;   // default level
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (_currentLevel)
                {
                    case LevelSelector.Easy:
                        Debug.Log("Selected Level: " + _currentLevel.ToString());
                        break;
                    case LevelSelector.Normal:
                        Debug.Log("Selected Level: " + _currentLevel.ToString());
                        break;
                    case LevelSelector.Hard:
                        Debug.Log("Selected Level: " + _currentLevel.ToString());
                        break;
                    case LevelSelector.Expert:
                        Debug.Log("Selected Level: " + _currentLevel.ToString());
                        break;
                    default:
                        Debug.LogError("Selected Level: Invalid");
                        break;
                }
            }
        }
    } 
}

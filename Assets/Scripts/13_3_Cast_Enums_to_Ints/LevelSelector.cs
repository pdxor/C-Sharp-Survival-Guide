using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CastEnumToIntSpace
{
    public class LevelSelector : MonoBehaviour
    {
        public enum DifficultyLevel
        {
            Easy,   // 0
            Normal, // 1
            Hard,   // 2
            Expert  // 3
        }

        public DifficultyLevel selectedDifficultyLevel;

        private void Start()
        {
            SceneManager.LoadScene((int)selectedDifficultyLevel);
        }
    } 
}

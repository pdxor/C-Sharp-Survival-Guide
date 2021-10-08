using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Unity Template Script
/// </summary>
namespace UnityScriptTemplateSpace
{
    //[System.Serializable]   // for non-MonoBehaviour classes
    public class UnityScriptTemplate : MonoBehaviour
    {
        #region Variable Declarations
        [Header("Visible Section")]               // for Inspector organization
        [SerializeField] private string _field;   // to appear in the inspector
        public string field;                      // appears in Inspector
        #endregion

        #region Unity Methods
        private void Awake()
        {

        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {

        }
        #endregion

        #region Public Methods
        // Reachable from outside of this class

        #endregion

        #region Private Methods
        // Reachable from inside of this class

        #endregion
        
        #region Protected Methods
        // Reachable from inside of this class and those that inherit or impement

        #endregion


    }
}

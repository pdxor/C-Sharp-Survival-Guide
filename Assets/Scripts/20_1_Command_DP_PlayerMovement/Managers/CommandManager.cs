using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Command_DP_Practical_Space
{
    public class CommandManager : MonoBehaviour
    {
        private static CommandManager _instance;
        public static CommandManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("The CommandManager instance is NULl");
                    return null;
                }
                return _instance;
            }
        }

        private List<ICommand> _commandBuffer = new List<ICommand>();

        private Transform _playerTransform;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            _playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().transform;
        }

        public void AddCommand(ICommand command)
        {
            _commandBuffer.Add(command);
        }

        // ToDo: reset player position to origin
        public void ResetPlayerPosition()
        {
            _playerTransform.position = Vector3.zero;
        }

        // clear command buffer
        public void ResetCommandBuffer()
        {
            _commandBuffer.Clear();
            ResetPlayerPosition();
        }

        // replay commands in forward order
        public void Play()
        {
            ResetPlayerPosition();
            StartCoroutine(PlayRoutine());
        }

        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");
            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForEndOfFrame();
            }
            Debug.Log("Finsihed Playing!");
        }

        // replay the commands in reverse order
        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }

        IEnumerator RewindRoutine()
        {
            Debug.Log("Rewinding...");
            foreach (var command in Enumerable.Reverse(_commandBuffer))
            {
                command.Undo();
                yield return new WaitForEndOfFrame();
            }
            Debug.Log("Finished Rewinding!");
        }
    } 
}

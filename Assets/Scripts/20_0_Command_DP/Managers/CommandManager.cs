using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Play, Rewind, Reset, Done commands
/// </summary>
namespace Command_DP_Space
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
                    Debug.LogError("CommandManager::Instance: The Command Manager instance is NULL.");
                    return null;
                }
                else
                {
                    return _instance;
                }
            }
        }

        private List<ICommand> _commandBuffer = new List<ICommand>();

        private void Awake()
        {
            _instance = this;
        }

        // Add - adds commands to the buffer
        // when mouse button is clicked, add color to the command buffer
        public void AddCommand(ICommand command)
        {
            _commandBuffer.Add(command);
        }

        // Play routine triggered by a play method that's going to play back all the commands
        // 1 second delay
        // when Play button is pressed, play all commands in the buffer in reverse
        public void Play()
        {
            // step through command buffer in reverse
            StartCoroutine(PlayRoutine());
        }

        IEnumerator PlayRoutine()
        {
            Debug.Log("Playing...");

            foreach (var command in _commandBuffer)
            {
                command.Execute();
                yield return new WaitForSeconds(1f);
            }

            Debug.Log("Finished Playing!");
        }

        public void Rewind()
        {
            StartCoroutine(RewindRoutine());
        }

        IEnumerator RewindRoutine()
        {
            Debug.Log("Rewinding...");

            foreach (var command in Enumerable.Reverse(_commandBuffer))
            {
                // in reverse order!
                command.Undo();
                yield return new WaitForSeconds(1f);
            }

            Debug.Log("Finished Rewinding!");
        }

        // Done - Finished with changing colors, turn all cubes white
        // when the Done button is pressed, turn all cubes white
        public void Done()
        {
            Debug.Log("End Recording...");
            // iterate through cubes and change their color to white
            var cubes = GameObject.FindGameObjectsWithTag("Cube");
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            Debug.Log("Done Recording!");
        }

        // Reset - Clear the command buffer
        // when Reset button is pressed, clear the command buffer
        public void Reset()
        {
            Debug.Log("Clearing Command Buffer...");
            // reset the command buffer
            _commandBuffer.Clear();
            Debug.Log("Command Buffer Cleared!");
        }
    } 
}

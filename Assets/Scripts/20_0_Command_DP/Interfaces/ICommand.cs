using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Command Design Pattern
/// - Records actions and events
/// - Decouples code: Isolates features/actions into their own classes
/// - Usage: Tactical rewind or queuing system
/// - Pro: Can change one system without affecting another
/// - Cons: Adds additional layer of complexity and classes
/// </summary>
namespace Command_DP_Space
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

}
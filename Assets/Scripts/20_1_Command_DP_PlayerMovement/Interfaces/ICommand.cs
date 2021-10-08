using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_DP_Practical_Space
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    } 
}

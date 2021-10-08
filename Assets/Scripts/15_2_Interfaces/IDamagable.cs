using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interfaces
/// - a contract for sub class to implement
/// - methods and properties, only (no attributes/fields)
/// - all public
/// - naming convention is I[word]able
/// - faux multiple inheritance of super class
/// - allows for Polymorphism
/// </summary>
namespace InterfaceSpace
{
    public interface IDamagable
    {
        int Health { get; set; }

        void Damage(int damageAmount);
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Polymorphism
/// - many forms (different parameter signatures)
/// </summary>
namespace GenericInterfacesSpace
{
    // Generic Type <T>
    public interface IDamagable<T>
    {
        T Health { get; set; }

        // must specify all types, not efficient
        //void Damage(int damageAmount);
        //void Damage(float damageAmount);

        // use Generics, instead
        void Damage(T damageAmount);
    } 
}

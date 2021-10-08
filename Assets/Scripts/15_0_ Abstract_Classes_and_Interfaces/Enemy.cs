using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract Classes
/// - Force implementation of a method
/// - Can only be used via inheritance
/// - Cannot be instantiated, cannot attach to a Unity game object
/// - 
/// </summary>
namespace AbstractClassesSpace
{
    public abstract class Enemy : MonoBehaviour
    {
        public int speed;
        public int health;
        public int gems;

        public abstract void Attack(); // signature only - no implementation in {}
                                       // sub class is required to implement (override) this method

        public virtual void Die()
        {
            Destroy(this.gameObject);
        }
    } 

    public class MossGiant : Enemy
    {
        public override void Attack()
        {
            throw new System.NotImplementedException();
            // MossGiant Attack behavior
        }

        public override void Die()
        {
            // display custom partcles
            base.Die();
        }
    }

    public class Skeleton : Enemy
    {
        public override void Attack()
        {
            throw new System.NotImplementedException();
            // Skeleton Attack behavior
        }

        public override void Die()
        {
            // display custom partcles
            base.Die();
        }
    }

    public class Spider : Enemy
    {
        public override void Attack()
        {
            throw new System.NotImplementedException();
            // Spider Attack behavior
        }

        public override void Die()
        {
            // display custom partcles
            base.Die();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZig : Enemy
{ 
    {
        public override void Move ()
        {
            Vector3 temPos = pos;
            temPos.x = Mathf.Sin(Time.time * Mathf.PI * 2) * 4;
            pos = temPos;
            base.Move();
        }
    }
}
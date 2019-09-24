using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{

    public float speed = 10f;
    public float firerate = 0.3f;

    void Update()

    {
        Move();
    }

    public virtual world Move()

    {
        Vector3 temPos = pos;
        temPos.y -= speed * Time.deltaTime;
        pos = temPos;

    }

    void OnCollisonEnter( Collision coll)

    {
        GameObject other = coll.gameObject;
        switch (other.tag)

        {
            case "Hero":
                break;
            case "HeroLaser":
                Destroy(this.gameObject);
                break;
        }
    }

    public Vector3 pos

    {
        get

        {
            return (this.transform.position);
        }

        set

        {
            this.transform.position = value;
        }

    }

}

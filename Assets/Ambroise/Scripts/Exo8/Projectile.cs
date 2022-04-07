using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour, IMissile, IMovable
{
    Vector2 dir;
    float speed;
    public void Initialize(Vector2 dir, float speed)
    {
        this.speed = speed;
        this.dir = dir;
    }

    void Update()
    {
        Move(dir * speed * Time.deltaTime);
    }

    public void Move(Vector2 dir)
    {
        transform.position += new Vector3(dir.x, dir.y);
    }


    public void OnTouch()
    {
        throw new System.NotImplementedException();
    }
}

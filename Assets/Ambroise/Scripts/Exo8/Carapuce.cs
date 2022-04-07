using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carapuce : Pokemon, IMovable
{
    int numberTouch = 0;
    bool move = false;
    GameObject target;
    [SerializeField]
    float speed;
    public override void OnSpawn()
    {
        MissileSpawner.instance.Spawn(new SpawnInformationMissile(transform.position, Vector3.zero, Color.blue, 2f, 0));
    }
    public override bool TryCatch()
    {
        numberTouch++;
        return numberTouch > 1;
    }

    public override void Attack(GameObject target)
    {
        this.target = target;
        move = true;
    }

    public void Move(Vector2 dir)
    {
        transform.position += new Vector3(dir.x, dir.y,0);
    }

    void Update()
    {
        if(move)
        {
            Move((target.transform.position - transform.position).normalized * speed * Time.deltaTime);
        }
    }
}

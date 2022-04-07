using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawner
{
    void Spawn(SpawnInformation toSpawn);
}

public interface ISpawned
{
    void OnSpawn();
}

public interface ICatchable
{
    bool TryCatch();
}

public interface IMissile
{
    void Initialize(Vector2 dir, float speed);
    void OnTouch();
}

public interface IMovable
{
    void Move(Vector2 dir);
}

public interface IEndGame
{
    void EndGame();
}

public interface IScore
{
    void Score(ETypePokemon pokemon);
    public Dictionary<ETypePokemon, int> GetScore();
}

public enum ETypePokemon
{
    Salameche,
    Pikachu,
    Carapuce
}

public interface IAttacker
{
    void Attack(GameObject target);
}
public class SpawnInformation
{
    public Vector3 position;
}

public class SpawnInformationPokemon : SpawnInformation
{
    public GameObject toSpawn;
}

public class SpawnInformationMissile : SpawnInformation
{
    public SpawnInformationMissile(Vector3 position, Vector3 trajectoire, Color color, float scale, float speed)
    {
        this.position = position;
        this.direction = trajectoire;
        this.colorMissile = color;
        this.scale = scale;
        this.speed = speed;
    }
    public Vector3 direction;
    public Color colorMissile;
    public float scale;
    public float speed;
    
}
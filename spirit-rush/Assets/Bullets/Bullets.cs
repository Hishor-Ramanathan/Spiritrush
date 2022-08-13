using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Bullet", menuName =("Bullets"))]
public class Bullets : ScriptableObject
{
    public new string name;
    public string description;
    public string equation;
    public GameObject projectile;
    public float damage;
    public float speed;
    public float size;
    public float firerate;
    public float amount;
    public float pierce;
}

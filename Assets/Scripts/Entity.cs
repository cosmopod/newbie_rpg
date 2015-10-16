using UnityEngine;
using System.Collections;

public class Entity : ScriptableObject
{

	public string name;
	public int age;
	public string faction;
	public string occupation;
	public int level = 1;
	public int health = 1;
	public int strength = 1 ;
	public int magic = 0;
	public int defense = 0;
	public int speed = 1;
	public int damage = 1;
	public int armor = 0;
	public int numAttacks = 1;
	public string weapon;
	public Vector2 position;


	public void takeDamage (int amount)
	{
		health -= Mathf.Clamp (amount - armor, 0, int.MaxValue);
	}

	public void attack (Entity entity)
	{
		entity.takeDamage (strength);
	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject SpherePrefab; //array for cube prefabs
    public float spawntime; //variable for the delay before the first spawn
    public float spawndelay; //variable for the delay in between spawns
    public float spherespeed = 5f; //cube speed
    public float min, max;
    void Start()
    {
        Spawn();
        InvokeRepeating("Spawn", spawntime, Random.Range(min, max)); //repeats spawning

    }
    void Update()
    {
        //Debug.Log("Cube Position: " + transform.position);
        Rigidbody SphereRigid = GetComponent<Rigidbody>();
        if (SphereRigid != null)
        {
           
        }
    }
    public void Spawn()
    {
        //int random = Random.Range(0, SpherePrefabs.Length); //finds random number between 0 and 1
      //GameObject Spherespawn = Instantiate(SpherePrefabs[random], transform.position, Quaternion.identity); //instantiate a sphere prefab in spawner location
        GameObject Spherespawn = Instantiate(SpherePrefab, transform.position + new Vector3(1.0f,0.0f,0.0f), transform.rotation); // instantiate a sphere prefab with spawner's rotation
        Rigidbody SphereRigid = Spherespawn.GetComponent<Rigidbody>();//adds rigidbody to sphere
        if (SphereRigid != null) //checks if sphere has rigid body
        {
            SphereRigid.angularVelocity = Vector3.zero; // Stop rotation
            SphereRigid.velocity = -transform.forward * spherespeed;//sets a velocity for the sphere
        }
    }
}

﻿/** John Mordi* 
 * Assignment#5 - 3D Prototype* 
 * Makes the gun shoot using raycasts and manages those objects hit by the ray*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, 
            cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //get target script off the hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if target script is found, make target take damage
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}

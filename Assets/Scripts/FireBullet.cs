using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FireBullet : MonoBehaviour
{
    public float speed = 50f;
    public GameObject bulletObj;
    public Transform frontOfGun;
    public Animator aniGun;

    public static event Action GunFired;

    public void Fire()
    {
        GetComponent<AudioSource>().Play();
        aniGun.SetTrigger("Fire");
        GameObject spawnedBullet = Instantiate(bulletObj, frontOfGun.position, frontOfGun.rotation);
        //spawnedBullet.GetComponent<Rigidbody>().AddForce(frontOfGun.transform.forward * speed, ForceMode.Impulse);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
        Destroy(spawnedBullet, 5f);
        //GunFired?.Invoke();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject Bala;
    public Transform Ponta;

    public int ammo;
    private int ammoInicial;
    public int ammoReserva;

    public float fireRate;
    private float canshoot;

    // Start is called before the first frame update
    void Start()
    {
        ammoInicial = ammo;
    }

    // Update is called once per frame
    void Update()
    {
        canshoot += Time.deltaTime;

        Shoot();
        Reload();
    }

    void Shoot(){
        if(Input.GetMouseButton(0)){
            if(canshoot >= fireRate && ammo > 0){
                Instantiate(Bala, Ponta.position, Ponta.rotation);
                ammo--;
                canshoot = 0;
            }
        }
    }

    void Reload(){
        if(Input.GetKeyDown(KeyCode.R) && ammo != ammoInicial){
            ammoReserva += ammo;

            if(ammoReserva > ammoInicial){
                ammo -= ammo; 
                ammo = ammoInicial;
                ammoReserva -= ammoInicial;
            }
            if(ammoReserva == ammoInicial){
                ammo = ammoReserva;
                ammoReserva = 0;
            }
            if(ammoReserva < ammoInicial){
                ammo = ammoReserva;
                ammoReserva = 0;
            }
        }
    }
}

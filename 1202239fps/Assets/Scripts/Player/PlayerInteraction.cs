using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
public Transform startPosition;
private void OnTriggerEnter(Collider other){


    if (other.gameObject.CompareTag("GunAmmo"))
        {
           GameManager.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Muerte") || other.gameObject.CompareTag("Enemy"))
        {
             GameManager.Instance.LoseVida(2);

             
            GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = startPosition.position;
            GetComponent<CharacterController>().enabled = true;

            Debug.Log("Haz muerto!!");

        }




}


}

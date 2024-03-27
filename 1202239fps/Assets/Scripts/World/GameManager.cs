using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Text ammoText;
    public static GameManager Instance {get; private set;}
   public int gunAmmo = 10;
   public Text vidaText;
    public int vida=10;

   private void Awake(){
    Instance = this; 
   }

   private void Update(){
    ammoText.text = gunAmmo.ToString();
    vidaText.text = vida.ToString();
   }


    public void LoseVida(int vidaToR){
    vida -= vidaToR;
    gunAmmo = 10;
    CheckHealt();
   }

   
    public void CheckHealt(){
    if(vida <=0 || WinCheck.Instance.isWin){
        Debug.Log("Haz muerto!!");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
       
   }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCheck : MonoBehaviour
{
    public static WinCheck Instance;
    [SerializeField] private Button buttonRestart;
    [SerializeField] private Transform space;
    public bool isWin = false;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Hide();
        buttonRestart.onClick.AddListener(() => ResetGame());

    }

    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Finish");
        
        if (enemigos.Count() == 0)
        {
            Show();
        }

        

    }

    private void Show()
    {
        isWin = true;
        space.gameObject.SetActive(true);
    }

    private void Hide()
    {
        isWin = false;
        space.gameObject.SetActive(false);
    }

}

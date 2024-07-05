using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] MainMenu menu;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameOverPanel.gameObject.SetActive(true);
            menu.PauseGame();
        }
    }
}

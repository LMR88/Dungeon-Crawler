using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    [SerializeField] private FightPositionData posData;
    [SerializeField] private Transform playerGrid;
    [SerializeField] private Transform enemyGrid;
    [SerializeField] private List<TMP_Text> EnnemieHPbarList = new List<TMP_Text>();
    [SerializeField] private List<TMP_Text> PlayerHPbarList = new List<TMP_Text>();
    private Monster dataE;
    private Player dataP;
    [SerializeField] 
    private Monster monsterPrefab;
    [SerializeField] 
    private Player playerPrefab;
    
    
    private void Start()
    {
        
        foreach (var EnnemieHpbar in EnnemieHPbarList)
        {
            EnnemieHpbar.gameObject.SetActive(false);
        }
        foreach (var PlayerHpbar in PlayerHPbarList)
        {
            PlayerHpbar.gameObject.SetActive(false);
        }
        
        
    }
    void Awake()
    {
        
        Vector3 spawnPos;
        // Remplissage de la grille des ennemies
        for (int i = 0; i < posData.enemyArray.Length; i++)
        {
            // Apparition d'un ennemi
            if (posData.enemyArray[i] != null)
            {
                spawnPos = enemyGrid.GetChild(i).position;
<<<<<<< Updated upstream

                Instantiate(posData.enemyArray[i], spawnPos, Quaternion.Euler(Vector3.zero));
=======
                
                // Orientation selon le monde d'apparition
                // i <= 3 : case du haut
                // i > 3  : case du bas
                if (i <= 3)
                {
                    Instantiate(posData.enemyArray[i], spawnPos, Quaternion.Euler(new Vector3(0f, 180f, 0f)));
                }
                else
                {
                    Instantiate(posData.enemyArray[i], spawnPos, Quaternion.Euler(new Vector3(180f, 180f, 0f)));
                }

                var monster = dataE.dataMonster;
                var enemy = Instantiate(monsterPrefab);
                enemy.ApplyData(monster);
                EnnemieHPbarList[i].gameObject.SetActive(true);
                EnnemieHPbarList[i].text = dataE.dataMonster.m_hp.ToString();
>>>>>>> Stashed changes
            }
        }
        
        // Remplissage de la grille des joueur
        for (int i = 0; i < posData.playerArray.Length; i++)
        {
            // Apparition d'un joueur
            if (posData.playerArray[i] != null)
            {
                spawnPos = playerGrid.GetChild(i).position;
                
<<<<<<< Updated upstream
                Instantiate(posData.playerArray[i], spawnPos, Quaternion.Euler(Vector3.zero));
=======
                // Orientation selon le monde d'apparition
                // i <= 3 : case du haut
                // i > 3  : case du bas
                if (i <= 3)
                {
                    Instantiate(posData.playerArray[i], spawnPos, Quaternion.Euler(new Vector3(0f, 0f, 0)));
                    
                }
                else
                {
                    Instantiate(posData.playerArray[i], spawnPos, Quaternion.Euler(new Vector3(180f, 0f, 0f)));
                    // Je sais que l'ennemi regarde vers la droite mais ¯\_o_/¯    - Alexandre
                }
                
                PlayerHPbarList[i].gameObject.SetActive(true);
                PlayerHPbarList[i].text = dataP.dataPlayer.m_hp.ToString();
>>>>>>> Stashed changes
            }
        }
    }
}

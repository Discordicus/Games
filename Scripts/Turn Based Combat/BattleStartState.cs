using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStartState {
    private BasePlayer newEnemy = new BasePlayer();
    private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseMageClass(), new BaseWarriorClass()};
    private string[] enemyNames = new string[] { "mage enemy", "fighter enemy" };

    public void PrepareBattle()
    {
        //create enemy

        //choose who goes first

    }

    private void CreateNewEnemy()
    {
        newEnemy.PlayerName = enemyNames[Random.Range(0, enemyNames.Length - 1)];
        newEnemy.PlayerLevel = Random.Range(Mathf.Abs(GameInformation.PlayerLevel - 2), GameInformation.PlayerLevel + 2);
        newEnemy.PlayerClass = classTypes[Random.Range(0, classTypes.Length - 1)];

    }
}

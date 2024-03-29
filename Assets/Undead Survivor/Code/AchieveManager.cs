using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchieveManager : MonoBehaviour
{
    public GameObject[] lockCharacter;
    public GameObject[] unLockCharacter;
    public GameObject uiNotice;

    enum Achieve { UnlockChar2, UnlockChar3 }
    Achieve[] achieves;
    WaitForSecondsRealtime wait;

    private void Awake() {
        achieves = (Achieve[])Enum.GetValues(typeof(Achieve));
        wait = new WaitForSecondsRealtime(3);

        if(!PlayerPrefs.HasKey("MyData")){
            Init();
        }
    }

    void Init(){
        PlayerPrefs.SetInt("MyData", 1);

        foreach(Achieve achieve in achieves){
            PlayerPrefs.SetInt(achieve.ToString(), 0);
        }
    }

    private void Start() {
        UnlockCharacter();
    }

    void UnlockCharacter(){
        for  (int i = 0; i < lockCharacter.Length; i++){
            string achieveName = achieves[i].ToString();
            bool isUnlock = PlayerPrefs.GetInt(achieveName) == 1;
            lockCharacter[i].SetActive(!isUnlock);
            unLockCharacter[i].SetActive(isUnlock);
        }
    }

    private void LateUpdate() {
        foreach(Achieve achieve in achieves){
            CheckAchieve(achieve);
        }
    }

    void CheckAchieve(Achieve achieve){
        bool isAchieve = false;

        switch(achieve){
            case Achieve.UnlockChar2:
                isAchieve = GameManager.instance.kill >= 100;
                break;
            case Achieve.UnlockChar3:
                isAchieve = GameManager.instance.gameTime == GameManager.instance.maxGameTime;
                break;
        }

        if (isAchieve && PlayerPrefs.GetInt(achieve.ToString()) == 0){
            PlayerPrefs.SetInt(achieve.ToString(), 1);
            for (int i = 0; i < uiNotice.transform.childCount; i++){
                bool isActive = i == (int)achieve;
                uiNotice.transform.GetChild(i).gameObject.SetActive(isActive);
            }
            StartCoroutine(NoticeRoutine());
        }
    }

    IEnumerator NoticeRoutine(){
        uiNotice.SetActive(true);
        AudioManager.instance.PlaySfx(AudioManager.Sfx.LevelUp);

        yield return wait;

        uiNotice.SetActive(false);
    }
}

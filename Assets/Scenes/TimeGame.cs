using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour {

    float roundStartDelayTime = 5;
    float roundStartTime;
    int waitTime;
    bool roundStarted;
    void Start() {
        Debug.Log("Aperte espaço quando achar que o tempo passou!");
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted) {
            InputReceived();
        }
    }

    void InputReceived () {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        Debug.Log("Você esperou por " + playerWaitTime + " segundos." + "Isso foi " + error + " segundos fora da marca! " + GenerateMessage(error));
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage (float error) {
        string message;
        if(error < .15f){
            message = "Ótimo!";
        } else if(error < .75f){
            message = "Muito bom!";
        } else if(error < 1.25f){
            message = "Tá ok!";
        } else if(error < 1.75f){
            message = "Você consegue fazer melhor.";
        }else {
            message = "Muito Ruim...";
        }
        return message;
    }

    void SetNewRandomTime () {
        waitTime = Random.Range(5, 15);
        roundStartTime = Time.time;
        roundStarted = true;
        Debug.Log(waitTime + "segundos...");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class problemmanager : MonoBehaviour
{
    public Text problem;
    public int prnumber;
    public GameObject change;
    // Start is called before the first frame update
    void Start()
    {
        problem.text = "press the next button to learn.";
        prnumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Nextproblem(){

        prnumber += 1; 

        if(prnumber == 1){
            problem.text = "1 problem";
        }
        else if(prnumber == 2){
            problem.text = "2 problem";
        }
        else if(prnumber == 3){
            problem.text = "3 problem";
        }
        else if(prnumber == 4){
            problem.text = "4 problem";
        }
        else if(prnumber == 5){
            problem.text = "5 problem";
        }
        //여기에 문제 추가 가능.
        
        else if(prnumber == 6){
            problem.text = "final problem.";
            prnumber = 0;
        }
    }
}

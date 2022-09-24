using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class problemmanager : MonoBehaviour
{
    public Text problem;
    public bool solveproblem;
    public int prnumber;
    public GameObject change;
    public GameObject answerbox;
    public int LP;
    // Start is called before the first frame update
    void Start()
    {
        //problem.text = "press the next button to learn.";
        prnumber = 1;
        loadpr();
        solveproblem = false;
        LP = PlayerPrefs.GetInt("LP");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Dontsolveproblembutnext(){
        problem.text = "Let's back to the problem. or, use skip. let's back to problem.";
    }

    public void Nextproblem(){
        if(prnumber == 6){
            problem.text = "This is final problem.";
        }else{
            if(solveproblem == true){
            prnumber += 1; 
            loadpr();
        }else{
            problem.text = "You don't solve the problem.";
            Invoke("Dontsolveproblembutnext",3f);
            Invoke("loadpr",6f);
            
        }
        }
    }

    public void Checkanswer(){
        string answer = answerbox.GetComponent<TMP_InputField>().text;

        if(prnumber == 1){
            if(answer == "4"){
                problem.text = "Right!"; 
                LP += 1; 
                PlayerPrefs.SetInt("LP",LP);
                Invoke("loadpr",2f);
                solveproblem = true;
            }else{
                problem.text = "Wrong!";
                Invoke("loadpr",2f);
            }
            }
            else if(prnumber == 2){
                if(answer == "2"){
                problem.text = "Right!";
                Invoke("loadpr",2f);
                solveproblem = true;
                }else{
                problem.text = "Wrong!";
                Invoke("loadpr",2f);
                }
            }
            else if(prnumber == 3){
                if(answer == "3"){
                problem.text = "Right!";
                Invoke("loadpr",2f);
                solveproblem = true;
                }else{
                problem.text = "Wrong!";
                Invoke("loadpr",2f);
                }
            }
            else if(prnumber == 4){
                if(answer == "4"){
                problem.text = "Right!";
                Invoke("loadpr",2f);
                solveproblem = true;
                }else{
                problem.text = "Wrong!";
                Invoke("loadpr",2f);
                }
            }
            else if(prnumber == 5){
                if(answer == "5"){
                problem.text = "Right!";
                Invoke("loadpr",2f);
                solveproblem = true;
                }else{
                problem.text = "Wrong!";
                Invoke("loadpr",2f);
                }
            }else if(prnumber == 0){
                problem.text = "plz choose problem.";
            }
        
    } 

    public void SkipProblem(){
        prnumber += 1; 
        loadpr();
        
    } 


    public void loadpr(){
        if(prnumber == 1){
                problem.text = "1. 반지름의 길이가 6이고 호의 길이가 4ㅠ인 부채꼴의 중심각의 크기는? \n\n ① ㅠ/6 \t ② ㅠ/3 \t ③ ㅠ/2 \t ④ 2ㅠ/3 \t ⑤ 5ㅠ/6";
                solveproblem = false;
            }
            else if(prnumber == 2){
                problem.text = "2 problem";
                solveproblem = false;
            }
            else if(prnumber == 3){
                problem.text = "3 problem";
                solveproblem = false;
            }
            else if(prnumber == 4){
                problem.text = "4 problem";
                solveproblem = false;
            }
            else if(prnumber == 5){
                problem.text = "5 problem";
                solveproblem = false;
            }
            else if(prnumber == 6){
                problem.text = "final problem.";
                solveproblem = false;
                prnumber = 0;
            }else if(prnumber == 0){
                problem.text = "Problem not choosed.";
                solveproblem = false;
            }
    }

    public void Watchlecture(){
        
    } 
}

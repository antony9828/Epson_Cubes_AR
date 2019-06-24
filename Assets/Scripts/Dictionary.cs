using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    private string[] words;
    public string word;
    public static int next_count;
    public char current_letter;
    public GameObject[] Letters;
    public Material active_Material;
    public Material diabled_Material;

    void Start()
    {
        words = new string[5] {"APPLE","CAB","SMARTPHONE","TRAIN","MOUSE"};
        int randNum = Random.Range(0,words.Length);
        word = words[randNum];
        word = "CAB";
        next_count = -1;
    }

    void Update()
    {
        if(next_count != -1 && next_count < word.Length)
        {
            current_letter = word[next_count];
        }

        if (next_count != -1)
        {
            foreach (GameObject letter in Letters)
            {
                if (letter.CompareTag(current_letter.ToString()))
                {
                    letter.GetComponent<Renderer>().material = active_Material;
                }
                else
                {
                    letter.gameObject.GetComponent<Renderer>().material = diabled_Material;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            next_count++;
        }
        Debug.Log(next_count);
        Debug.Log(word.Length);

        if (next_count == word.Length)
        {
            Debug.Log("Congratulation!");
        }




        else if (States.State_Next && word.Length >= 10 && next_count < 10 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString())
                                                     && States.GetState(word[5].ToString())
                                                     && States.GetState(word[6].ToString())
                                                     && States.GetState(word[7].ToString())
                                                     && States.GetState(word[8].ToString())
                                                     && States.GetState(word[9].ToString()))
        {
            next_count = 10;
        }
        else if (States.State_Next && word.Length >= 9 && next_count < 9 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString())
                                                     && States.GetState(word[5].ToString())
                                                     && States.GetState(word[6].ToString())
                                                     && States.GetState(word[7].ToString())
                                                     && States.GetState(word[8].ToString()))
        {
            next_count = 9;
        }
        else if (States.State_Next && word.Length >= 8 && next_count < 8 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString())
                                                     && States.GetState(word[5].ToString())
                                                     && States.GetState(word[6].ToString())
                                                     && States.GetState(word[7].ToString()))
        {
            next_count = 8;
        }
        else if (States.State_Next && word.Length >= 7 && next_count < 7 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString())
                                                     && States.GetState(word[5].ToString())
                                                     && States.GetState(word[6].ToString()))
        {
            next_count = 7;
        }
        else if (States.State_Next && word.Length >= 6 && next_count < 6 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString())
                                                     && States.GetState(word[5].ToString()))
        {
            next_count = 6;
        }
        else if (States.State_Next && word.Length >= 5 && next_count < 5 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString())
                                                     && States.GetState(word[4].ToString()))
        {
            next_count = 5;
        }
        else if (States.State_Next && word.Length >= 4 && next_count < 4 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString()) 
                                                     && States.GetState(word[2].ToString())
                                                     && States.GetState(word[3].ToString()))
        {
            next_count = 4;
        }
        else if (States.State_Next && word.Length >= 3 && next_count < 3 && States.GetState(word[0].ToString())
                                                     && States.GetState(word[1].ToString())
                                                     && States.GetState(word[2].ToString()))
        {
            next_count = 3;
        }
        else if (States.State_Next && word.Length >= 2 && next_count < 2 && States.GetState(word[0].ToString()) 
                                                     && States.GetState(word[1].ToString()))
        {
            next_count = 2;
        }
        else if (States.State_Next && word.Length >= 1 && next_count < 1 && States.GetState(word[0].ToString()))
        {
            next_count = 1;
        }
        else if (States.State_Next && next_count < 0)
        {
            next_count = 0;
        }
    }
}

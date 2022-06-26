using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SurfaceArea : MonoBehaviour
{
    public TextMeshPro Text;
    public TextMeshPro Text2;
    public int areaCode;

    private int i = 0;
    private double[] nums = { 0, 0, 0, 0};
    private bool decimalHit = false;
    private double decimalCounter = 0;
    private int infoReceived = 0;
    private bool answerGiven = false;
    private double answer = 0;

    void Update()
    {

        int TextLength = Text.text.Length;
        if (TextLength > 10)
        {
            answerGiven = true;
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            printNum(1);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            printNum(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            printNum(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            printNum(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            printNum(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            printNum(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            printNum(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            printNum(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            printNum(9);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            printNum(0);
        }
        //.
        else if (Input.GetKeyDown(KeyCode.Period))
        {
            Debug.Log(".");
            if (decimalHit == false)
            {
                decimalHit = true;
                Text.text += ".";
            }
        }


        //circle
        if (areaCode == 1)
        {

            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "C =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "Ch =";
                    Text.text = "";
                }
                else if (infoReceived == 2)
                {
                    Text2.text = "a =";
                    Text.text = "";
                }

            }

            if (infoReceived == 3)
            {
                nums[2] *= nums[2]; //a
                answer = nums[2] * 6 * nums[0];
                Debug.Log(answer);
                double answerTwo = nums[1] * 2 * nums[2];
                answer = answer - answerTwo;
                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 2)
        {

            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "R =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "H =";
                    Text.text = "";
                }

            }

            if (infoReceived == 2)
            {
                answer = 2 * 3.14 * nums[0] * nums[1];

                nums[0] *= nums[0];
                nums[0] = nums[0] * 3.14 * 2;
                answer += nums[0];
                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 3)
        {
            if (answerGiven == false)
            {
                Text2.text = "R =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                nums[0] *= nums[0];
                answer = nums[0] * 3.14 * 4;
                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
            }
        }
        else if (areaCode == 4)
        {
            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "R =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "L =";
                    Text.text = "";
                }

            }

            if (infoReceived == 2)
            {
                answer = nums[0] * 3.14 * nums[1];
                nums[0] *= nums[0];
                nums[0] *= 3.14;

                answer += nums[0];
                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 5)
        {
            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "B =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "H =";
                    Text.text = "";
                }
                else if (infoReceived == 2)
                {
                    Text2.text = "W =";
                    Text.text = "";
                }
                else if (infoReceived == 3) {
                    Text2.text = "L =";
                    Text.text = "";
                }

            }

            if (infoReceived == 4)
            {
                double sOne = nums[2] * nums[3] * 2;
                double sThree = nums[0] * nums[2];
                answer = nums[0] * nums[1];
                answer += sOne + sThree;

                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 6)
        {
            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "A =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "B =";
                    Text.text = "";
                }
                else if (infoReceived == 2)
                {
                    Text2.text = "C =";
                    Text.text = "";
                }
                else if (infoReceived == 3)
                {
                    Text2.text = "D =";
                    Text.text = "";
                }

            }

            if (infoReceived == 4)
            {
                double sOne = nums[0] * nums[1];
                double sTwo = nums[0] * nums[2];
                double sThree = nums[1] * nums[3];
                answer = sOne + sTwo + sThree;

                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }
        else if (areaCode == 7)
        {
            if (infoReceived == 0 && answerGiven == false)
            {
                Text2.text = "B =";
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                infoReceived++;
                i++;
                decimalHit = false;
                decimalCounter = 0;

                if (infoReceived == 1)
                {
                    Text2.text = "H =";
                    Text.text = "";
                }
                else if (infoReceived == 2)
                {
                    Text2.text = "W =";
                    Text.text = "";
                }
                else if (infoReceived == 3)
                {
                    Text2.text = "L =";
                    Text.text = "";
                }

            }

            if (infoReceived == 4)
            {
                double sOne = nums[2] * nums[3]; ;
                double sTwo = nums[1] * nums[2];
                double sThree = nums[0] * nums[2];
                answer = nums[0] * nums[1];
                answer += sOne + sTwo + sThree;

                Text2.text = "SA =";
                Text.text = answer.ToString();
                answerGiven = true;
                infoReceived = 0;
            }
        }

    }

    public void printNum(int n)
    {
        if (answerGiven)
        {
            i = 0;
            nums[0] = 0;
            nums[1] = 0;
            nums[2] = 0;
            nums[3] = 0;
            decimalHit = false;
            decimalCounter = 0;
            infoReceived = 0;
            answerGiven = false;
            answer = 0;
            Text.text = "";

        }
        else if (decimalHit)
        {
            decimalCounter++;
            double decimalAdded = n;
            for (int a = 0; a < decimalCounter; a++)
            {
                decimalAdded = decimalAdded / 10;
            }
            nums[i] += decimalAdded;
            Text.text += n.ToString();
        }
        else
        {
            nums[i] *= 10;
            nums[i] += n;

            Text.text += n.ToString();
        }
    }
}

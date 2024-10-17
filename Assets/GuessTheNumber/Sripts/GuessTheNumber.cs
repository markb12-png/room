using TMPro;
using UnityEngine;

//
public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {

            messageText.text = "Please enter a valid number";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {

                messageText.text = "VICTORY!";
            }

            else if (playerNumber > randomNumber)
                    {
                    messageText.text = "Lower";

            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Higher";
            }
            else
            {
                messageText.text = "Please enter a valid number";
            }
            numberInput.text = "";
        }
    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated Number: " + randomNumber);
        messageText.text = "Guess the number";


    }

}

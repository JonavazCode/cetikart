using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine.Networking;

public class Login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Text HelpName;
    public Text HelpPassword, Prompt;
    public Button submitButton;


    public void CallLogin()
    {
        //creo que va aquí
        if ( CorrectNickname() && CorrectPassword() )
        {
            //Debug.Log("correcto");
            StartCoroutine(LoginPlayer());
        }

        
    }


    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("loginNickname", nameField.text);
        form.AddField("loginPassword", passwordField.text);

        using (UnityWebRequest www = UnityWebRequest.Post("https://cetikart.000webhostapp.com/UserController.php", form))
        {
            
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                var texto = www.downloadHandler.text;
                bool comprobarLogin = texto == "se logeo correctamente" ? true : false;
                if (texto == "error")
                {
                    Prompt.text = "Los datos son erróneos";
                }
                if (comprobarLogin)
                {
                    if (!DBManager.LoggedIn)
                    {
                        DBManager.nickname = nameField.text;
                        Debug.Log("El nickname: " + DBManager.nickname + " se guardó correctamente");
                        SceneManager.LoadScene("LobbyScene");
                    }
                }
                else
                {
                    Prompt.text = "Los datos son erróneos";
                    Debug.Log("datos erroneos");
                }
                    

            }
        }
    }

    public void VerrifyInputs()
    {

        submitButton.interactable = true;
    }

    public bool CorrectNickname()
    {
        if (nameField.text.Length >= 1)
        {
            HelpName.text = " ";
            return true;
        }
        else
        {
            HelpName.text = "Debe rellenar este campo";
            return false;
        }
    }

    public bool CorrectPassword()
    {
        if (passwordField.text.Length >= 6 && passwordField.text.Length <= 20 && VerifyUpper())
        {
            HelpPassword.text = " ";
            return true;
        }
        else
        {
            HelpPassword.text = "Contraseña: ";
            if (passwordField.text.Length == 0)
            {
                HelpPassword.text += "\nDebe llenar este campo";
                return false;
            }
            else
            {
                if (!VerifyUpper())
                    HelpPassword.text += "\nFalta 1 mayúscula";
                else
                    HelpPassword.text = " ";
                return false;
            }

        }
    }

    public bool VerifyUpper() //con expresiones regulares comprueba que la contraseña tenga una mayuscula
    {
        var reg = new Regex(@"^(?=\S*?[A-Z])");
        return reg.Match(passwordField.text).Success? true : false;
    }
}

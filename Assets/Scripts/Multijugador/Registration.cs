using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //extraer elementos de la UI
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions; //utilizar expresiones regulares
using UnityEngine.Networking;

public class Registration : MonoBehaviour
{
    public InputField nameField, nickField;
    public InputField passwordField, passwordFieldConfirmation;
    public Text HelpEmail, HelpNick, HelpPassword, HelpPasswordConfirmation, Prompt;

   

    public Button submitButton;

    public void CallRegister()
    {
        
        if (CorrectEmail() && CorrectNickname() && CorrectPassword() && PasswordMatch())
        {
            StartCoroutine(Register());
        }

        //StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("registroEmail", nameField.text);
        form.AddField("registroPassword", passwordField.text);
        form.AddField("registroNickname", nickField.text);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/UserController.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "email registrado")
                {
                    Prompt.text = "El email ya está registrado";
                }
                if (www.downloadHandler.text == "nickname registrado")
                {
                    Prompt.text = "El nickname está en uso";
                }
                if (www.downloadHandler.text == "se registro correctamente")
                {
                    SceneManager.LoadScene("Login_Multijugador");
                }
                //SceneManager.LoadScene("Seleccion_Dificultad");
            }
        }
        //if (www.text == "0")
        //{
        //    Debug.Log("User created succcesfully.");
        //    SceneManager.LoadScene("Menu_Principal");
        //}
        //else
        //{
        //    Debug.Log("User creation failed. Error #" + www.text);
        //}

        //(control + k) + (control + c) = comentar
        //(control + k) + (control + u) = descomentar
    }

    public void VerrifyInputs()
    {

        submitButton.interactable = true;
    }




    public bool CorrectEmail()
    {
        if (nameField.text.Length >= 6)
        {
            HelpEmail.text = "Email correcto";
            return true;
        }
        else
        {
            HelpEmail.text = "Debe ser mayor a 6 caracteres";
            return false;
        }           
    }

    public bool CorrectNickname()
    {
        if (nickField.text.Length >= 1)
        {
            HelpNick.text = "Nick correcto";
            return true;
        }
        else
        {
            HelpNick.text = "Debe rellenar este campo";
            return false;
        }
    }

    public bool CorrectPassword()
    {
        if (passwordField.text.Length >= 6 && passwordField.text.Length <= 20 && VerifyUpper())
        {
            HelpPassword.text = "Contraseña correcta";
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
                    HelpPassword.text += "\n correcta";
                return false;
            }

        }
    }

    public bool VerifyUpper() //con expresiones regulares comprueba que la contraseña tenga una mayuscula
    {
        var reg = new Regex(@"^(?=\S*?[A-Z])");
        return reg.Match(passwordField.text).Success ? true : false;
    }

    public bool PasswordMatch()
    {

        if (passwordFieldConfirmation.text.Equals(passwordField.text))
        {
            HelpPasswordConfirmation.text = "Contraseñas coinciden";
            return true;

        }
        else
        {
            HelpPasswordConfirmation.text = "Contraseñas no coinciden";
            return false;
        }
    }
}

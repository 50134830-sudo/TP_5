using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Password_Manager : MonoBehaviour
{
    public GameObject txtResultadoPasswd;
    public TextMeshProUGUI  txtResultadoPasswdTexto;
    public TMP_InputField input_Password;

    // Start is called before the first frame update
    void Start()
    {
        txtResultadoPasswd.SetActive(false);
    }

   public  void ValidatePassword()
    {
        txtResultadoPasswd.SetActive(true);
        txtResultadoPasswdTexto.text = input_Password.text;
    }


}


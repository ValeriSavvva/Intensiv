using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public GameObject text;
    public GameObject button;

    private int i = 0;

    private string[] replics = { "Всю Кострому охватил чудовищный по местным меркам пожар. И вот уже в который раз Костроме пришлось отстраиваться практически с нуля. Прокладывать новые улицы на пустырях, соединять центр с селениями.",
                                 "Наш музей костромского края просит вас заново воссоздать  Сусанинскую площадь. Она должна быть настолько привлекательной,  чтобы ни один человек не обронил нарочно зажженную спичку. Доверяем Вашему вкусу!"};
    private string[] answers = { "Какой ужас! Что нам делать?",
                                 "Давайте приступим!"};

    public void Start()
    {
        text.GetComponent<Text>().text = replics[i];
        button.GetComponent<Text>().text = answers[i];
        i++;
    }

    public void next()
    {
        if(i == 1)
        {
            text.GetComponent<Text>().text = replics[i];
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 2)
            SceneManager.LoadScene(1);
        i++;
    }
}

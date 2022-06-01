using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public GameObject text;
    public GameObject panel;
    public GameObject cards;
    public GameObject button;
    public GameObject ModelPrefab;
    public Transform scrollViewContent;

    private int i = 0;

    private string[] replics = { "Всю Кострому охватил чудовищный по местным меркам пожар. И вот уже в который раз Костроме пришлось отстраиваться практически с нуля. Прокладывать новые улицы на пустырях, соединять центр с селениями.",
                                 "Наш музей костромского края просит вас заново воссоздать  Сусанинскую площадь. Она должна быть настолько привлекательной,  чтобы ни один человек не обронил нарочно зажженную спичку. Доверяем Вашему вкусу! Мы выдадим вам карточки с информацией о памятниках культуры."};
    private string[] answers = { "Какой ужас! Что нам делать?",
                                 "Сейчас посмотрим!",
                                 "Давайте приступим!"};

    public void Start()
    {
        text.GetComponent<Text>().text = replics[i];
        button.GetComponent<Text>().text = answers[i];
        i++;

        for (int i = 0; i < DragPanel.models.Count; i++)
        {
            var dragObject = Instantiate(ModelPrefab, scrollViewContent);
            var script = dragObject.GetComponent<Card>();
            script.image.sprite = DragPanel.images[i];
            script.name.text = DragPanel.rusnames[i];
            script.desc.text = DragPanel.descriptionobj[i];
        }
    }

    public void next()
    {
        if(i == 1)
        {
            text.GetComponent<Text>().text = replics[i];
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 2)
        {
            panel.SetActive(false);
            cards.SetActive(true);
            button.GetComponent<Text>().text = answers[i];
        }
        if (i == 3)
        {
            SceneManager.LoadScene(3);
            Debug.Log("Начало");
        }
        i++;
    }
}

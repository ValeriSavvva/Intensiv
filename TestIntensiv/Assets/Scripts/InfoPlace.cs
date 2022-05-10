using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoPlace : MonoBehaviour, IPointerDownHandler
{
    private static string[] descriptions = new string[] {
    "Уже более ста лет существует легенда о костромском персонаже. Он жил в городе в конце XIX века в пожарной части, расположенной на площади Ивана Сусанина. Он был неотъемлемой частью местной пожарной команды. Этот персонаж всегда сопровождал пожарных на выездах, помогая вытаскивать из огня людей или вещи. Он был настоящей местной легендой, о его подвигах говорили все костромичи.",
    "Это здание было построено по инициативе губернатора К. И. Баумгартена (1768−1831). В ноябре 1823 года губернским архитектором П. И. Фурсовым составлены проектные чертежи здания, смета на строительство. В этом здании располагались: жилые помещения, предназначенные для служащих и бойцов пожарного депо; сараи, где размещались машины, наполненные водой бочки, а на смотровой башне дежурил караульный.",
    "Здесь стоит памятник архитектуры эпохи позднего классицизма, одна из достопримечательностей города, входящая в архитектурный ансамбль Сусанинской площади. Караульный дом, то есть место для размещения личного состава главного караула."
    };

    public static bool isCliked = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isCliked)
        {
            if (transform.tag == "bobka")
                setTextOnPanel(0);
            if (transform.tag == "kalancha")
                setTextOnPanel(1);
            if (transform.tag == "gaup")
                setTextOnPanel(2);
            isCliked = true;
            Places.mainui.SetActive(false);
        }
    }

    private void setTextOnPanel(int i)
    {
        Places.infoaboutplace.SetActive(true);
        Places.descplace.GetComponent<Text>().text = descriptions[i];
    }
}

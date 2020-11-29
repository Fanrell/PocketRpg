using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Text;


public class ProfileListBehaviour : MonoBehaviour
{
    public Dropdown dropProfileList;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in Directory.GetDirectories(Paths._profilePath))
        {
            string[] tmp = item.Split('/');
            dropProfileList.options.Add(new Dropdown.OptionData { text = tmp[tmp.Length - 1].ToString() });
        }
        Debug.Log(dropProfileList.options.Count);
        if(dropProfileList.options.Count == 0)
        {
            dropProfileList.captionText.text = "<<create profile>>";
        }
    }

}

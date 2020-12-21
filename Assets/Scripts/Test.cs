using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SimpleJSON;
using LitJson;
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(readJson());


    }

    IEnumerator readJson()
    {
        string spath = Application.persistentDataPath + "/testJson.json";

        WWW www = new WWW(spath);

        yield return www;

        string jsonString = System.Text.Encoding.UTF8.GetString(www.bytes);

        JsonData itemDate = JsonMapper.ToObject(jsonString.ToString());

        foreach (var item in itemDate.Keys)
        {
            Debug.Log(itemDate[item]);

            Debug.Log(itemDate[item].IsObject);
        }

    }

    //IEnumerator readJson()
    //{

    //    string spath = Application.persistentDataPath + "/testJson.json";

    //    WWW www = new WWW(spath);

    //    yield return www;

    //    string jsonString = System.Text.Encoding.UTF8.GetString(www.bytes);

    //    Debug.Log(jsonString);

    //    JSONNode jsonNode = JSONString.Parse(jsonString);
    //    JSONObject jsonobject = jsonNode.AsObject;
    //    foreach (var item in jsonobject.Keys)
    //    {
    //        Debug.Log(item);
    //    }

    //    foreach (var item in jsonobject.Values)
    //    {
    //        Debug.Log(item);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Page
{
    public int pageNum;

    public List<Section> sections;

    public Page(int _pageNum,List<Section> _sections)
    {
        pageNum = _pageNum;
        sections = _sections;
    }

}

public class Section
{
    public int SectionID;
    public string SectionName;
    public int sectionWidth;
    public int sectionHeight;

    public List<BtnNode> btnNodes;

    public Section(int _SectionID,int _sectionWidth,int _sectionHeight, string _SectionName, List<BtnNode> _btnNodes)
    {
        sectionWidth = _sectionWidth;
        sectionHeight = _sectionHeight;
        SectionID = _SectionID;
        SectionName = _SectionName;
        btnNodes = _btnNodes;
    }
}




public class A_udpSent
{
    public string address;
    public int Port;
    public string data;

    public A_udpSent(string _address, int _port, string _data)
    {
        address = _address;
        Port = _port;
        data = _data;
    }
}
